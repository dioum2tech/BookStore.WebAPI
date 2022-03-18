using BookStore.API.Models;
using Microsoft.AspNetCore.Identity;

namespace BookStore.API.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        public Task<string> SignInAsync(SignInModel signInModel);
    }
}
