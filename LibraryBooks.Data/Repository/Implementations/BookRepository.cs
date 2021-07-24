using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository.Implementations
{
    public class BookRepository : BaseRepository<BookEntityModel>, IBookRepository
    {

        public BookRepository(LibraryContext context)
            : base(context) { }

        public BookEntityModel CreateBook(BookEntityModel model)
        {

            if (!CheckBook(model))
            {

                return Insert(model);

            }
            else
            {

                throw new Exception("Книга с такими данными уже существует...");

            }


        }

        public BookEntityModel UpdateBook(BookEntityModel model)
        {

            if (CheckBook(model.Id))
            {

                return Update(model);

            }
            else
            {

                throw new Exception("Книги с такими данными не существует");

            }

        }

        public void RemoveBook(BookEntityModel model)
        {

            if (CheckBook(model))
            {

                Delete(model);

            }
            else
            {

                throw new Exception("Книги с такими данными не существует...");

            }

        }

        public void RemoveBook(Guid id)
        {

            if(CheckBook(id))
            {

                var result = GetQuery().FirstOrDefault(book => book.Id == id);

                Delete(result);

            }
            else
            {

                throw new Exception("Книги с такими данными не существует...");

            }

        }

        public List<BookEntityModel> GetBooks()
        {

            return GetQuery().ToList();

        }

        /// <summary>
        /// Метод поиска всех книг, удовлетворяющих запросу (слишком много if... =с )
        /// </summary>
        /// <param name="model">Модель поиска книг</param>
        /// <returns>Список удовлетворяющих модели поиска книг</returns>
        public List<BookEntityModel> GetBooks(SearchViewModel model)
        {

            var result = GetQuery();

            // В наличии
            if (model.InStock)
            {

                result = result.Where(book => book.CountBooks != 0);

            }

            // Название
            if (model.Title != null && model.Title.Trim() != "")
            {

                result = result.Where(book => book.Title.ToLower().Contains(model.Title.ToLower()));

            }

            // Автор
            if (model.Author != null && model.Author.Trim() != "")
            {

                result = result.Where(book => book.Author.ToLower().Contains(model.Author.ToLower()));

            }

            // Дата
            if (model.StartValueYear != null && model.EndValueYear != null)
            {

                if(model.StartValueYear <= model.EndValueYear)
                {

                    result = result.Where(book => book.Year >= model.StartValueYear && book.Year <= model.EndValueYear);

                }
                else
                {

                    throw new Exception("Начальная дата не может быть больше конечной...");

                }

            }

            // Количество страниц
            if (model.StartValueCountPages != null && model.EndValueCountPages != null)
            {

                if(model.StartValueCountPages <= model.EndValueCountPages)
                {

                    result = result.Where(book => book.CountPages >= model.StartValueCountPages && book.CountPages <= model.EndValueCountPages);

                }
                else
                {

                    throw new Exception("Начальное значение не может быть больше конечного...");

                }

            }

            return result.ToList();

        }

        public void ReceivingBook(Guid id)
        {
            var book = GetQuery().FirstOrDefault(item => item.Id == id);

            book.CountBooks--;

            Update(book);
        }

        public void ReturnBook(Guid id)
        {
            var book = GetQuery().FirstOrDefault(item => item.Id == id);

            book.CountBooks++;

            Update(book);
        }


        public bool InStock(Guid bookId)
        {
            var result = GetQuery().AsNoTracking().FirstOrDefault(book => book.Id == bookId);

            if(result.CountBooks != 0)
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        bool CheckBook(BookEntityModel model)
        {

            var result = GetQuery().FirstOrDefault(book => 
                        book.Title == model.Title &&
                        book.Author == model.Author &&
                        book.Year == model.Year);

            if(result == null)
            {

                return false;

            }
            else
            {


                return true;

            }

        }

        bool CheckBook(Guid id)
        {

            var result = GetQuery().AsNoTracking().FirstOrDefault(book => book.Id == id);

            if (result == null)
            {

                return false;

            }
            else
            {


                return true;

            }

        }




    }
}
