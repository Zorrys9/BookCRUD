using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Services.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {

            _userRepository = userRepository;

        }



        public async Task<IdentityResult> Registration(RegistrationVIewModel model)
        {

            if(model != null)
            {

               return await _userRepository.Registration(model);

            }
            else
            {

                throw new Exception("Данные для регистрации не указаны...");

            }

        }

        public async Task<SignInResult> Authorization(AuthorizationViewModel model)
        {
            if (model != null)
            {

                return await _userRepository.Authorization(model);

            }
            else
            {

                throw new Exception("Данные для регистрации не указаны...");

            }
        }

        public void LogOut()
        {

            _userRepository.LogOut();

        }

        public string GetId(string userName)
        {

            if(userName != null)
            {

                var result = _userRepository.GetId(userName);

                if(result != null)
                {

                    return result;

                }
                else
                {

                    throw new Exception("Пользователя с таким логином не существует...");

                }

            }
            else
            {

                throw new Exception("Логин пользователя не указан, невозможно найти его id...");

            }
        }

    }
}
