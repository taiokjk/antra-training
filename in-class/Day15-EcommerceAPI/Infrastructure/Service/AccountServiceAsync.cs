using Core.Models.Request;
using Core.RepositoryContracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepository _repo;
        private readonly IConfiguration _config;

        public AccountServiceAsync(IAccountRepository r, IConfiguration c)
        {
            _repo = r;
            _config = c;
        }

        public Task<IdentityResult> SignupAsync(SignupModel info)
        {
            return _repo.SignupAsync(info);
        }

        public async Task<string> Login(LoginModel info)
        {
            var result = await _repo.Login(info);

            if (result.Succeeded)
            {
                var authClaim = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, info.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var authSignKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SecretKey"]));

                var token = new JwtSecurityToken(
                    issuer: _config["JWT:ValidIssuer"],
                    audience: _config["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaim,
                    signingCredentials: new SigningCredentials(authSignKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                var handler = new JwtSecurityTokenHandler().WriteToken(token);

                return handler;
            }
              
            return null;
        }
    }
}
