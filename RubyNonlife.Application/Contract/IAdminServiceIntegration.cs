using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Application.Utitlies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RubyNonlife.Application.Dtos.Responses.SingleProductClassResponse;

namespace RubyNonlife.Application.Contract
{
    public interface IAdminServiceIntegration
    {
        Task<BaseResponse<string>> GetSubjectType(int id);
        Task<BaseResponse<List<string>>> GetCostTypeNamesById(List<int> costTypeIds);
        Task<BaseResponse<List<string>>> RiderNamesById(List<int> riderIds);
        Task<BaseResponse<List<string>>> GetCostOfInsuranceNamesById(List<int> costOfInsuranceIds);
        Task<BaseResponse<List<string>>> GetSingleCover(List<int> ids);
        Task<BaseResponse<string>> GetCoverNameById(int id);
        Task<BaseResponse<List<string>>> GetSubjectOfInsuranceNamesById(List<int> costOfInsuranceIds);
        Task<BaseResponse<Dictionary<int, string>>> GetObjectOfInsuranceNamesById(List<int> objectOfInsuranceIds);
        Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflows(int id);
        Task<BaseResponse<AdminFunction>> GetFunctionById(int id);
        Task<BaseResponse<List<AdminFunction>>> GetAllFunctions();
        Task<BaseResponse<List<Approvalsetup>>> GetWorkflowApprovalSetup(int id);
        Task<BaseResponse<ApprovingOfficeLookup>> GetApprovingOfficeById(int id);
        Task<BaseResponse<ApprovingPosition>> ApprovingPositionId(int id);
        Task<BaseResponse<AdminWorkflowResponse>> GetWorkflow(int id);
        Task<BaseResponse<List<ApprovingOffice>>> GetUserApprovingOffices(Guid userId);
        Task<BaseResponse<List<UserOfficeFunctionsAdminResponse>>> GetUsersInformation(int functionId, int approvingOfficeId);
        Task<BaseResponse<List<ApprovingOfficeLookup>>> GetAllApprovingOffices(string search);
        Task<BaseResponse<List<ApprovingOfficeLookup>>> GetAllApprovingOfficesByIds(List<int> ids);
        Task<BaseResponse<List<Officer>>> GetAllApprovingOfficersWithApprovingOffice(int officeId);
        Task<BaseResponse<List<AdminFunction>>> GetFunctionWithIdList(List<int> ids);
        Task<BaseResponse<List<AdminModulesResponse>>> GetAllModules();
        Task<BaseResponse<List<GenericNameResponse>>> GetStates();
        Task<BaseResponse<List<UserOfficeFunctionsAdminResponse>>> GetUserId(int OfficeId);
        Task<BaseResponse<List<GenericNameResponse>>> GetExternalEntity(int typeId);
        Task<BaseResponse<List<AdminProductClassResponse>>> GetProductClass(int lineOfBusinessId);
        
        Task<BaseResponse<List<AdminRiderResponse>>> GetProductWithRiders(int productClassId, int lineOfBusiness);
        Task<BaseResponse<string>> GetSingleProductClass(int id);
        Task<BaseResponse<Dictionary<int, string>>> GetProductClassNames(List<int> productClassId);
        Task<BaseResponse<List<GenericNameResponse>>> GetBroker();
        Task<BaseResponse<List<GenericNameResponse>>> GetOfficeLocation();

        Task<BaseResponse<(string Token, bool IsAuthenticated)>> AuthenticateADUser(string username, string password);
        Task<BaseResponse<(string Token, bool IsAuthenticated)>> AuthenticateByFullName(string fullName);
        Task<BaseResponse<BrokerAccountDetailsResponse>> GetExternalEntityById(int id);
        Task<BaseResponse<List<CoInsuranceAccountDetailsResponse>>> GetExternalEntitiesByIds(int[] ids);

    }
}
