using DigitalSignature.DTO.UserManagement;

namespace DigitalSignature.Service.UserManagement
{
	public interface IUserManagement
	{
		Task<CreateUserManagementResponse> CreateUserManagementAsync(CreateUserManagementRequest request);
		Task<GetUserManagementListResponse> GetListUserManagementAsync(GetUserManagementListRequest request);
		Task<UserManagementItem> GetUserManagementAsync(string userId);
	}
}
