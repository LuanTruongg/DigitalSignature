
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DigitalSignature.Ultilities.Http
{
	public class Response : IResponse
	{
		[JsonIgnore]
		public int __Id { get; set; }
		public virtual int StatusCode { get; set; } = StatusCodes.Status200OK;
	}
}
