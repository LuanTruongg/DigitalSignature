using DigitalSignature.ViewModel.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Service.UserManagement
{
	public interface IUserManagement
	{
		Task<CreateUserManagementResponse> CreateUserManagementAsync(CreateUserManagementRequest request);
	}
}
