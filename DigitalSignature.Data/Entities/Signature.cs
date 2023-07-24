using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.Entities
{
	public class Signature
	{
		public string? Id { get; set; }
		public string? Description { get; set; }
		public List<DocumentHistory>? DocumentHistories { get; set; }
	}
}
