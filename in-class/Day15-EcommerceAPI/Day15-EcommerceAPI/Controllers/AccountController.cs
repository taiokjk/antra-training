using Core.Models.Request;
using Core.RepositoryContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day15_EcommerceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync _accountServiceAsync;

        public AccountController(IAccountServiceAsync a)
        {
            _accountServiceAsync = a;
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupModel info)
        {
            var result = await _accountServiceAsync.SignupAsync(info);

            if (result.Succeeded)
                return Ok();

            return BadRequest(result.Errors);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel info)
        {
            var result = await _accountServiceAsync.Login(info);

            if (!String.IsNullOrEmpty(result))
                return Ok(result);

            return Unauthorized();
        }
    }
}
