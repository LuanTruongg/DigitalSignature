using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.ViewModel.UserManagement
{
	public class CreateUserManagementRequest
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CIC { get; set; }
		public string DepartmentId { get; set; }
		public string PositionId { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
	}
}
