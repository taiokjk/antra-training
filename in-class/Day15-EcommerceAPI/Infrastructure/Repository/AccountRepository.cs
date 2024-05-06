using Core.Entities;
using Core.Models.Request;
using Core.RepositoryContracts;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signinManager;
        public AccountRepository(UserManager<ApplicationUser> m,
                                    SignInManager<ApplicationUser> s)
        {
            _userManager = m;
            _signinManager = s;
        }

        public async Task<IdentityResult> SignupAsync(SignupModel info)
        {
            ApplicationUser user = new ApplicationUser()
            {
                UserName = info.Email,
                FirstName = info.FirstName,
                LastName = info.LastName
            };
            return await _userManager.CreateAsync(user, info.Password);
        }

        public async Task<SignInResult> Login(LoginModel info)
        {
            return await _signinManager.PasswordSignInAsync(info.UserName,
                                                            info.Password,
                                                            false,
                                                            false);
        }
    }
}
