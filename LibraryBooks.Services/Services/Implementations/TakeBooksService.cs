using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Services.Services.Implementations
{
    public class TakeBooksService :ITakeBooksService
    {

        private readonly ITakeBooksRepository _takeBooksRepository;

        public TakeBooksService(ITakeBooksRepository takeBooksRepository)
        {

            _takeBooksRepository = takeBooksRepository;

        }


        public void ReceivingBook(TakeBookViewModel model)
        {
            if(model != null)
            {

                _takeBooksRepository.ReceivingBook(model);

            }
            else
            {

                throw new Exception("Данные для взятия книги не указаны...");

            }
        }


        public void ReturnBook(TakeBookViewModel model)
        {

            if (model != null)
            {

                _takeBooksRepository.ReturnBook(model);

            }
            else
            {

                throw new Exception("Данные для возврата книги не укзаны...");

            }

        }


    }
}
