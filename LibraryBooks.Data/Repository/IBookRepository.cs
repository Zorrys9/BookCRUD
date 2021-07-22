using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository
{
    public interface IBookRepository : IBaseRepository<BookEntityModel>
    {

        BookEntityModel CreateBook(BookEntityModel model);

        BookEntityModel UpdateBook(BookEntityModel model);

        void RemoveBook(BookEntityModel model);

        void RemoveBook(Guid id);

        List<BookEntityModel> GetBooks();

        List<BookEntityModel> GetBooks(SearchViewModel model);
    }
}
