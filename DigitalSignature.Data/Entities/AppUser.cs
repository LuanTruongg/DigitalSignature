﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.Entities
{
	public class AppUser : IdentityUser
	{
		public string EmployeeCode { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CIC { get; set; }
		public string DepartmentId { get; set; }
		public string PositionId { get; set; }
		public DateTime CreateAt { get; set; }
		public string CreateBy { get; set; }
		public DateTime UpdateAt { get; set; }
		public string UpdateBy { get; set; }
		public List<DocumentHistory> DocumentHistories { get; set; }
		public Department Department { get; set; }

	}
}
