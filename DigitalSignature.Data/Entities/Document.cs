using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Data.Entities
{
	public class Document
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string FileName { get; set; }
		public string FilePath { get; set; }
		public DateTime CreateAt { get; set; }
		public DateTime UpdateAt { get; set; }
		public List<DocumentHistory> DocumentHistories { get; set; }
	}
}
