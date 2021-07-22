using LibraryBooks.Common.ViewModels;
using LibraryBooks.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Services.Services
{
    public interface IBookService
    {

        BookModel CreateBook(BookModel model);

        BookModel UpdateBook(BookModel model);

        void RemoveBook(BookModel model);

        void RemoveBook(Guid id);

        List<BookViewModel> GetBooks();

        List<BookViewModel> GetBooks(SearchViewModel model);

    }
}
