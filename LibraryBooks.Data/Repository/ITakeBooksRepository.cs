using LibraryBooks.Common.ViewModels;
using LibraryBooks.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository
{
    public interface ITakeBooksRepository : IBaseRepository<TakeBooksEnityModel>
    {

        void ReceivingBook(TakeBookViewModel model);

        void ReturnBook(TakeBookViewModel model);



    }
}
