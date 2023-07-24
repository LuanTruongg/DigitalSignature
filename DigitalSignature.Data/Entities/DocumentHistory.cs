using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.Entities
{
	public class DocumentHistory
	{
		public string Id { get; set; }
		public string DocumentId { get; set; }		
		public string SignatureId { get; set; }
		public string UserId { get; set; }
		public string TimeStamp { get; set; }
		public DateTime CreateAt { get; set; }
		public Document Document { get; set; }
		public Signature Signature { get; set; }
		public AppUser User { get; set; }
	}
}
