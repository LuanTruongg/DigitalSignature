using DigitalSignature.Ultilities.Http;

namespace DigitalSignature.DTO.UserManagement
{
	public class GetUserManagementListResponse : PagingListResponse<UserManagementItem>
	{
	}
	public class UserManagementItem
	{
		public string UserId { get; set; }
		public string Name { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CIC { get; set; }
		public string Email { get; set; }
		public string DepartmentId { get; set; }
		public string PositionId { get; set; }
		public string EmployeeCode { get; set; }
	}
}
