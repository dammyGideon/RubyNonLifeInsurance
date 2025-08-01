using Microsoft.VisualBasic.FileIO;

public record LocationSetupRequest{
    public int ProductId { get; set; }
    public string LocationName { get; set; }
    public bool RequireGenericLocation {  get; set; }
    public bool RequireSpecificGenericLocation { get; set; }
    public string AttributeName { get; set; }
    public string DataType { get; set; }
    public bool IsRequired { get; set; }
    public List<string> DropdownValues { get; set; }
}


public class UpdateLocationRequest
{
    public int ProductId { get; set; }
    public string LocationName { get; set; }
    public bool RequireGenericLocation { get; set; }
    public bool RequireSpecificGenericLocation { get; set; }
    public string? AttributeName { get; set; }
    public string? DataType { get; set; }
    public bool IsRequired { get; set; }
    public List<string>? DropdownValues { get; set; }
}

public class DeleteLocationRequest
{
    public int productId { get; set; }
    public string locationName { get; set; }
    public bool requireSpecificGenericLocation { get; set; }
}

public class UpdateFieldRequest
{
    public int AttributeId { get; set; } // ID of the field to update
    public string AttributeName { get; set; } // Optional: New field name
    public string AttributeType { get; set; } // Optional: New field type
    public bool? IsRequired { get; set; } // Optional: New required status
    public List<string> DropdownOptions { get; set; } // Optional: New dropdown options
}


