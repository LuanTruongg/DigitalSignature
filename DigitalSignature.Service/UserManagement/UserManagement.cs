using DigitalSignature.Data.EF;
using DigitalSignature.Data.Entities;
using DigitalSignature.Ultilities.Http;
using DigitalSignature.ViewModel.UserManagement;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Service.UserManagement
{
	public class UserManagement : IUserManagement
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly DigitalSignatureDbContext _dbContext;
		public UserManagement(UserManager<AppUser> userManager, DigitalSignatureDbContext dbContext)
        {
            _dbContext = dbContext;
			_userManager = userManager;
        }
        public async Task<CreateUserManagementResponse> CreateUserManagementAsync(CreateUserManagementRequest request)
		{
			var userExisting = await _userManager.FindByEmailAsync(request.Email);
			if (userExisting is null)
			{
				userExisting = new()
				{
					Id = Guid.NewGuid().ToString(),
					FirstName = request.FirstName,
					LastName = request.LastName,
					PhoneNumber = request.PhoneNumber,
					Email = request.Email,
					CIC = request.CIC,
					PositionId = request.PositionId,
					DepartmentId = request.DepartmentId,
					UserName = request.Email,
					CreateAt = DateTime.Now,
					CreateBy = "Admin",
					UpdateAt = DateTime.Now,
					UpdateBy = "Admin"
				};
				await _userManager.CreateAsync(userExisting);
			}
			else
			{
				throw new ErrorException(409, "Email was already used");
			}
			return new CreateUserManagementResponse()
			{
				UserId = userExisting.Id
			};
		}
	}
}
