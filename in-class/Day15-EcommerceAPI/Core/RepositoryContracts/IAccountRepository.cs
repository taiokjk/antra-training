using Core.Models.Request;
using Microsoft.AspNetCore.Identity;

namespace Core.RepositoryContracts
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignupAsync(SignupModel info);
        Task<SignInResult> Login(LoginModel info);
    }
}
