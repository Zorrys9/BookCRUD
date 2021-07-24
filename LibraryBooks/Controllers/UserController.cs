using LibraryBooks.Common.ViewModels;
using LibraryBooks.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Controllers
{
    [ApiController]
    public class UserController : Controller
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {

            _userService = userService;

        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public IActionResult Registration([FromForm] RegistrationVIewModel model)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    var result = _userService.Registration(model);

                    if (result.Result.Succeeded)
                    {

                        return Ok("Регистрация прошла успешно!");

                    }
                    else
                    {

                        throw new Exception("При регистрации возникла ошибка...");

                    }

                }
                else
                {

                    throw new Exception("Данные для регистрации указаны не верно...");

                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }


        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public IActionResult Authorization([FromForm]AuthorizationViewModel model)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    var result = _userService.Authorization(model);

                    if (result.Result.Succeeded)
                    {

                        return Ok("Вход в аккаунт успешно выполнен!");

                    }
                    else
                    {

                        throw new Exception("При авторизации возникла ошибка...");

                    }

                }
                else
                {

                    throw new Exception("Данные для авторизации указаны не верно...");

                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }


        }


        [HttpPost("[action]")]
        [Authorize(Roles = "Admin, Client")]
        public IActionResult LogOut()
        {

            try
            {

                _userService.LogOut();

                return Ok("Вы успешно вышли из аккаунта");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }


        }

    }
}
