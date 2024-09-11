using FrizerApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerApp.API.Data.UserService
{
    public interface IClientService
    {
        Task<ServiceResponse> RegisterUserAsync(RegistrationModel model);
        Task<ServiceResponse> LoginUserAsync(LoginModel model);
    }
}
