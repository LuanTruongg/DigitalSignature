using DigitalSignature.Data.EF;
using DigitalSignature.Data.Entities;
using DigitalSignature.DTO.UserManagement;
using DigitalSignature.Ultilities.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
					EmployeeCode = request.EmployeeCode,
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

		public async Task<GetUserManagementListResponse> GetListUserManagementAsync(GetUserManagementListRequest request)
		{
			var listUser = _userManager.Users
				.AsQueryable();

			if (!string.IsNullOrEmpty(request.Search))
			{
				listUser = listUser.Where(x => x.EmployeeCode.Contains(request.Search));
			}

			var numberPage = request.Page <= 0 ? 1 : request.Page;
			var numberPageSize = request.PageSize <= 0 ? 10 : request.PageSize;

			var data = await listUser.Skip((numberPage - 1) * numberPageSize)
				.Take(request.PageSize)
				.Select(x => new UserManagementItem()
				{
					UserId = x.Id,
					Name = x.FirstName + " " + x.LastName,
					FirstName = x.FirstName,
					LastName = x.LastName,
					CIC = x.CIC,
					EmployeeCode = x.EmployeeCode,
					Email = x.Email,
					DepartmentId = x.DepartmentId,
					PositionId = x.PositionId,
				})
				.ToListAsync();

			return new GetUserManagementListResponse()
			{
				Results = data,
				Page = numberPage,
				PageSize = numberPageSize,
				Count = listUser.Count()
			};
		}
	}
}
