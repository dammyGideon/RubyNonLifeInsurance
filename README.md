Thanks for clarifying! Since **Ruby** is actually the **name of your insurance application** and it’s a **.NET application**, here’s a tailored **README.md** for a .NET project:

---

# Ruby - Non-Life Insurance Application

**Ruby** is a **.NET-based non-life insurance application** that streamlines the entire insurance process, from **product setup** to **policy booking**. It is designed for insurance companies to efficiently manage non-life insurance products and their customers.

---

## **Features**

- **Product Setup**
  Create and manage non-life insurance products, including coverages, premiums, and terms.

- **Quotation Module**
  Generate and manage insurance quotations based on customer details and selected products.

- **Policy Booking Module**
  Convert approved quotations into active policies with automated policy number generation.

---

## **Tech Stack**

- **Framework:** .NET 8
- **Backend Language:** C#
- **Database:** SQL Server
- **ORM:** Entity Framework Core
- **Authentication:** JWT / Identity
- **Other Tools:** Swagger for API documentation

---

## **Installation & Setup**

1. **Clone the repository**

   ```bash
   git clone https://github.com/yourusername/ruby-insurance-app.git
   cd ruby-insurance-app
   ```

2. **Configure Database Connection**
   Update your `appsettings.json` file:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Your_Database_Connection_String"
     }
   }
   ```

3. **Apply Database Migrations**

   ```bash
   dotnet ef database update
   ```

4. **Run the Application**

   ```bash
   dotnet run
   ```

5. **Access the Application**
   Open your browser and go to:

   ```
   https://localhost:5001
   ```

---

## **Environment Variables**

Create a `.env` or use `appsettings.Development.json` for sensitive values:

```json
{
  "JwtSettings": {
    "SecretKey": "YourSecretKeyHere",
    "Issuer": "RubyInsurance",
    "Audience": "RubyInsuranceUsers"
  }
}
```

---

## **Project Structure**

```
RubyInsurance/
│-- Ruby.Api/
│-- Ruby.Domain/
│-- Ruby.Application/
│-- Ruby.Infrastruture/
│-- Migrations/
│-- appsettings.json
```

---

## **Future Enhancements**

- Claim Management Module
- Payment Gateway Integration
- Reporting & Analytics Dashboard
