using FrizerApp.API.Data.UserService;
using FrizerApp.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrizerApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly IClientService service;
        public AccountController(IClientService service)
        {
            this.service = service;
        }
        
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<ServiceResponse>> RegisterUserAsync(RegistrationModel model)
        {
            if (model is null) return BadRequest("Model is empty");
            var result = await service.RegisterUserAsync(model);
            return Ok(result);
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<ServiceResponse>> LoginUserAsync(LoginModel model)
        {
            if (model is null) return BadRequest();
            var result = await service.LoginUserAsync(model);
            return Ok(result);
        }

        
    }
}
