using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository
{
    public interface IUserRepository :IBaseRepository<UserEntityModel>
    {


        Task<IdentityResult> Registration(RegistrationVIewModel model);

        Task<SignInResult> Authorization(AuthorizationViewModel model);

        void LogOut();

        string GetId(string userName);



    }
}
