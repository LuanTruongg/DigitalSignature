using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.Entities
{
	public class Department
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public List<AppUser> User { get; set; }
	}
}
