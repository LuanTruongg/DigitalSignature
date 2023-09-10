using System.Text.Json.Serialization;

namespace DigitalSignature.Ultilities.Http
{
	public interface IResponse
	{
		[JsonIgnore]
		int StatusCode { get; set; }
	}
}
