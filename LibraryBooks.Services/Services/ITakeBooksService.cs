using LibraryBooks.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Services.Services
{
    public interface ITakeBooksService
    {

        void ReceivingBook(TakeBookViewModel model);


        void ReturnBook(TakeBookViewModel model);


    }
}
