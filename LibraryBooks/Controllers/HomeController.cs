using LibraryBooks.Common.ViewModels;
using LibraryBooks.Models;
using LibraryBooks.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;

        public HomeController(IBookService bookService)
        {

            _bookService = bookService;

        }

        [HttpPost("[action]")]
        public IActionResult CreateBook([FromForm]BookViewModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {

                   _bookService.CreateBook(model);

                }
                else
                {

                    throw new Exception("Данные указаны не верно...");

                }

                return Ok("Книга успешно добавлена!");

            }
            catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }


        [HttpPost("[action]")]
        public IActionResult UpdateBook([FromForm]BookViewModel model)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    _bookService.UpdateBook(model);

                }
                else
                {

                    throw new Exception("Данные указаны не верно...");

                }

                return Ok("Книга успешно изменена!");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }

        [HttpPost("[action]")]
        public IActionResult RemoveBookToModel([FromForm]BookViewModel model)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    _bookService.RemoveBook(model);

                }
                else
                {

                    throw new Exception("Данные указаны не верно...");

                }

                return Ok("Книга успешно удалена");

            }
            catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }

        [HttpPost("[action]")]
        public IActionResult RemoveBook([FromForm] Guid id)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    _bookService.RemoveBook(id);

                }
                else
                {

                    throw new Exception("Данные указаны не верно...");

                }

                return Ok("Книга успешно удалена");

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }

        [HttpPost("[action]")]
        public List<BookViewModel> GetAllBooks()
        {

            try
            {

                var result = _bookService.GetBooks();

                if(result != null)
                {

                    return result;

                }
                else
                {

                    throw new Exception("Книги не найдены...");

                }

            }
            catch
            {

                return null;

            }

        }

        [HttpPost("[action]")]
        public List<BookViewModel> GetBooks([FromForm]SearchViewModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    var result = _bookService.GetBooks(model);

                    if (result != null)
                    {

                        return result;

                    }
                    else
                    {

                        throw new Exception("Книги не найдены...");

                    }

                }
                else
                {

                    throw new Exception("Данные указаны не верно...");

                }

            }
            catch
            {

                return null;

            }

        }


    }
}
