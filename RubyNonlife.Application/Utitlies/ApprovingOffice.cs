using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Utitlies
{
    public class ApprovingOffice
    {
        public int Id { get; set; }
        public int? OfficeId { get; set; }
        public string UserId { get; set; }
        public int? PositionId { get; set; }
        public int? FunctionId { get; set; }
    }

    public class ApprovingOfficeLookup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public List<Officer> Officers { get; set; }
    }

    public class UserOfficeFunctionsAdminResponse
    {
        public int Id { get; set; }
        public int? OfficeId { get; set; }
        public string UserId { get; set; }
        public UserAdminResponse User { get; set; }
        public int? PositionId { get; set; }
        public int? FunctionId { get; set; }
    }

    public class UserAdminResponse
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool IsDeactivated { get; set; }
        public string DeactivationReason { get; set; }
        public int? StructuralBusinessUnitId { get; set; }
        public string AdUsername { get; set; }
        public Structuralbusinessunit StructuralBusinessUnit { get; set; }
    }

    public class Structuralbusinessunit
    {
        public int Id { get; set; }
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
    }

    public class BrokerAccountDetailsResponse
    {
        public string Name { get; set; }
        public string payableAccountNumber { get; set; }

    }

    public class CoInsuranceAccountDetailsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string payableAccountNumber { get; set; }

    }

    public class ExternalEntityResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PayableAccountNumber { get; set; }
        // You can include more fields if you ever need them
    }


}
