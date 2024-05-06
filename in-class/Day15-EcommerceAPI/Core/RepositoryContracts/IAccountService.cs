using Core.Models.Request;
using Microsoft.AspNetCore.Identity;

namespace Core.RepositoryContracts
{
    public interface IAccountServiceAsync
    {
        Task<IdentityResult> SignupAsync(SignupModel info);
        Task<string> Login(LoginModel info);
    }
}
