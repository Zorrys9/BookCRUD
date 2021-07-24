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
    public class TakeBooksRepository : BaseRepository<TakeBooksEnityModel>, ITakeBooksRepository
    {

        public TakeBooksRepository(LibraryContext context)
            :base(context)  { }



        public void ReceivingBook(TakeBookViewModel model)
        {

            if (Check(model) == null)
            {

                TakeBooksEnityModel result = new()
                {

                    BookId = model.bookId,
                    IdUser = model.userId,
                    DateOfTake = DateTime.Now

                };

                Insert(result);

            }
            else
            {

                throw new Exception("Книга, которую Вы хотите взять уже находится у Вас на руках...");

            }


        }

        public void ReturnBook(TakeBookViewModel model)
        {

            var check = Check(model);

            if(check != null)
            {

                Delete(check);

            }
            else
            {

                throw new Exception("Книги, которую Вы хотите вернуть, у Вас нет...");

            }


        }


        TakeBooksEnityModel Check(TakeBookViewModel model)
        {
                return GetQuery().AsNoTracking().FirstOrDefault(x => x.BookId == model.bookId && x.IdUser == model.userId);
        }

    }
}
