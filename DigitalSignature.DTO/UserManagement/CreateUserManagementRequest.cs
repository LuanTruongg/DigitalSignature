
namespace DigitalSignature.DTO.UserManagement
{
	public class CreateUserManagementRequest
	{
		public string EmployeeCode { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CIC { get; set; }
		public string DepartmentId { get; set; }
		public string PositionId { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
	}
}
