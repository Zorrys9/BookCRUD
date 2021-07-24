using LibraryBooks.Common.ViewModels;
using LibraryBooks.Logic.Logics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Controllers
{
    [ApiController]
    public class LibraryController : Controller
    {

        private readonly ILibraryLogic _libraryLogic;

        public LibraryController(ILibraryLogic libraryLogic)
        {

            _libraryLogic = libraryLogic;

        }


        [HttpPost("[action]")]
        [Authorize(Roles = "Admin, Client")]
        public IActionResult ReceivingBook([FromForm]Guid bookId)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _libraryLogic.ReceivingBook(User.Identity.Name, bookId);

                    return Ok();

                }
                else
                {

                    throw new Exception("Данные указаны не верно");

                }

            }
            catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

        [HttpPost("[action]")]
        [Authorize(Roles = "Admin, Client")]
        public IActionResult ReturnBook([FromForm] Guid bookId)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _libraryLogic.ReturnBook(User.Identity.Name, bookId);

                    return Ok();

                }
                else
                {

                    throw new Exception("Данные указаны не верно");

                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

    }
}
