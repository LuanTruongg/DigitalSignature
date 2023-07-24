using System.ComponentModel.DataAnnotations;

namespace DigitalSignature.Data.Entities
{
	public class Form
	{
        public string Id { get; set; }
		public string Title { get; set; }
		public string FileName { get; set; }
		public string FilePath { get; set; }
		public DateTime CreateAt { get; set; }
	}
}
