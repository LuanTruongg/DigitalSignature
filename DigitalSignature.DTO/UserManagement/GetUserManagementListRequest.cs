using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.DTO.UserManagement
{
	public class GetUserManagementListRequest
	{
		public string? UserId { get; set; }
		public string? EmployeeCode { get; set; }
		public string? DepartmentId { get; set; }
		public string? PositionId { get; set; }
		public int Page { get; set; }
		public int PageSize { get; set; }
		public bool? IsAscSorting { get; set; }
		public string? Search { get; set; }
	}
}
