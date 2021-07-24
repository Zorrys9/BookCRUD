using LibraryBooks.Common.ViewModels;
using LibraryBooks.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Logic.Logics.Implementations
{
    public class LibraryLogic : ILibraryLogic
    {

        private readonly IBookService _bookService;
        private readonly ITakeBooksService _takeBooksService;
        private readonly IUserService _userService;


        public LibraryLogic(IBookService bookService, ITakeBooksService takeBooksService, IUserService userService)
        {

            _bookService = bookService;
            _takeBooksService = takeBooksService;
            _userService = userService;

        }


        public void ReceivingBook(string userName, Guid bookId)
        {

            if (_bookService.InStock(bookId))
            {

                TakeBookViewModel model = new()
                {

                    bookId = bookId,
                    userId = _userService.GetId(userName)

                };


                _takeBooksService.ReceivingBook(model);

                _bookService.ReceivingBook(model.bookId);

            }
            else
            {

                throw new Exception("Данной книги нет в наличии...");

            }



        }

        public void ReturnBook(string userName, Guid bookId)
        {

            TakeBookViewModel model = new()
            {

                bookId = bookId,
                userId = _userService.GetId(userName)

            };

            _takeBooksService.ReturnBook(model);


            _bookService.ReturnBook(model.bookId);

        }

    }
}
