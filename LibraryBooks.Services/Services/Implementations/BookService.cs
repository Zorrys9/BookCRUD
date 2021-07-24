using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using LibraryBooks.Data.Repository;
using LibraryBooks.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Services.Services.Implementations
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {

            _bookRepository = bookRepository;

        }

        public BookModel CreateBook(BookModel model)
        {

            if(model != null)
            {

                return _bookRepository.CreateBook(model);

            }
            else
            {

                throw new Exception("Данные о новой книге не указаны");

            }

        }

        public BookModel UpdateBook(BookModel model)
        {

            if(model != null)
            {

                return _bookRepository.UpdateBook(model);

            }
            else
            {

                throw new Exception("Данные об изменяемой книге не указаны");
                
            }

        }

        public void RemoveBook(BookModel model)
        {

            if(model != null)
            {

                _bookRepository.Delete(model);

            }
            else
            {

                throw new Exception("Книга не укзана");

            }


        }

        public void RemoveBook(Guid id)
        {

            _bookRepository.RemoveBook(id);

        }

        public void ReceivingBook(Guid bookId)
        {

            _bookRepository.ReceivingBook(bookId);

        }

        public void ReturnBook(Guid bookId)
        {

            _bookRepository.ReturnBook(bookId);

        }

        public bool InStock(Guid bookId)
        {

            return _bookRepository.InStock(bookId);

        }

        public List<BookViewModel> GetBooks()
        {

            var books = _bookRepository.GetBooks();

            return ConvertToViewModels(books);
            
        }

        public List<BookViewModel> GetBooks(SearchViewModel model)
        {

            var books = _bookRepository.GetBooks(model);

            return ConvertToViewModels(books);
        }

        static List<BookViewModel> ConvertToViewModels(List<BookEntityModel> entities)
        {
            List<BookViewModel> result = new();

            if (entities.Count != 0 || entities == null)
            {

                foreach (var book in entities)
                {

                    result.Add((BookModel)book);

                }

                return result;

            }
            else
            {

                return null;

            }


        }
        


    }
}
