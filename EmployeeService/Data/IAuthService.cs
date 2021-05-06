using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Data
{
    public interface IAuthService
    {
        public Task<AuthModel> RegisterAsync(RegisterModel model);
        public Task<AuthModel> LoginAsync(LoginModel model);
        public Task<string> AddRoleAsync(AddRoleModel model);
    }
}
