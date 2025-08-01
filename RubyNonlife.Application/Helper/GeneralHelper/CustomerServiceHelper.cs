using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Domain.Enums;

public static class CustomerServiceHelper
{
    public static async Task<CustomerResponse> GetCustomerAsync(string customerId, IConfiguration config)
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(config.GetSection("RubyLifeUrlBaseUrl").Value)
        };

        // Construct the request URL with the customer ID
        var requestUrl = $"api/v1/customers/customer-number?customerNumber={customerId}";

        try
        {
            // Send async GET request and read response
            var response = await httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode(); // Throws an exception for non-success status codes

            var responseContent = await response.Content.ReadAsStringAsync();

            // Deserialize JSON response into BaseResponse<CustomerResponse>
            var finalResponse = JsonConvert.DeserializeObject<BaseResponse<CustomerResponse>>(responseContent);

            return finalResponse?.Data;
        }
        catch (HttpRequestException e)
        {
            // Handle any request exceptions, log, and return null if an error occurs
            Console.WriteLine($"Request error: {e.Message}");
            return null;
        }
    }

    public static string GetCustomerName(CustomerResponse customer)
    {
        // Parse customer type from enum
        var customerType = Enum.Parse<CustomerTypeEnum>(customer.CustomerType);

        // Return the appropriate name based on the customer type
        return customerType switch
        {
            CustomerTypeEnum.Association => customer.AssociationName.ToString(),
            CustomerTypeEnum.Corporate => customer.CompanyName.ToString(),
            CustomerTypeEnum.Individual => $"{customer.FirstName} {customer.LastName}",
            CustomerTypeEnum.Sme => customer.CompanyName.ToString(),
            _ => string.Empty,
        };
    }
}
