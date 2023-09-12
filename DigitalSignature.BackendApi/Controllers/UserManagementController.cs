using DigitalSignature.Service.UserManagement;
using DigitalSignature.DTO.UserManagement;
using Microsoft.AspNetCore.Mvc;

namespace DigitalSignature.BackendApi.Controllers
{
	[Route("user-managements")]
	[ApiController]
	public class UserManagementController : ControllerBase
	{
		private readonly IUserManagement _service;
		public UserManagementController(IUserManagement service)
        {
			_service = service;
        }

		[HttpPost]
		[ProducesResponseType(typeof(CreateUserManagementResponse), 200)]
		public async Task<IActionResult> CreateAsync([FromBody] CreateUserManagementRequest request)
		{
			if (ModelState.IsValid)
			{
				var result = await _service.CreateUserManagementAsync(request);
				if(result != null)
					return Ok(result.UserId);
			}

			return BadRequest();
		}
		[HttpGet]
		[ProducesResponseType(typeof(GetUserManagementListResponse), 200)]
		public async Task<IActionResult> GetListUserAsync([FromQuery] GetUserManagementListRequest request)
		{
			if (ModelState.IsValid)
			{
				var result = await _service.GetListUserManagementAsync(request);
				if (result != null)
					return Ok(result);
			}
			return BadRequest();
		}
		[HttpGet("{userId}")]
		[ProducesResponseType(typeof(GetUserManagementListResponse), 200)]
		public async Task<IActionResult> GetUserByIdAsync(string userId)
		{
			if (ModelState.IsValid)
			{
				var result = await _service.GetUserManagementAsync(userId);
				if (result != null)
					return Ok(result);
			}
			return BadRequest();
		}
	}
}
