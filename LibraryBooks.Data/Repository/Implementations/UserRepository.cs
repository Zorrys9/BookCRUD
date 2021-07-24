using LibraryBooks.Common.Enums;
using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository.Implementations
{
    public class UserRepository : BaseRepository<UserEntityModel>, IUserRepository
    {

        private readonly UserManager<UserEntityModel> _userManager;
        private readonly SignInManager<UserEntityModel> _signInManager;



        public UserRepository(LibraryContext context, UserManager<UserEntityModel> userManager, SignInManager<UserEntityModel> signInManager) :
            base(context)
        {

            _signInManager = signInManager;
            _userManager = userManager;

        }





        public async Task<IdentityResult> Registration(RegistrationVIewModel model)
        {

            var newUser = new UserEntityModel
            {
                SecondName = model.SecondName,
                FirstName = model.FirstName,
                Patronymic = model.Patronymic,
                UserName = model.UserName,
                Email = model.Email,
                PhoneNumber = model.Phone
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (result.Succeeded)
            {

                switch (model.Role)
                {

                    case Roles.Admin:
                        return await _userManager.AddToRoleAsync(newUser, "Admin");
                    case Roles.Client:
                        return await _userManager.AddToRoleAsync(newUser, "Client");
                    default:
                        return await _userManager.AddToRoleAsync(newUser, "Client");
                }

            }
            else
            {

                throw new Exception("При регистрации возникла ошибка...Повторите попытку, ну или не повторяйте...");

            }

        }

        public async Task<SignInResult> Authorization(AuthorizationViewModel model)
        {

            return await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

        }


        public async void LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        
        public string GetId(string userName)
        {
            return GetQuery().FirstOrDefault(user => user.UserName == userName).Id;
        }
        
    }
}
