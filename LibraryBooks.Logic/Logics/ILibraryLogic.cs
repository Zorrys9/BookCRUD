using LibraryBooks.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Logic.Logics
{
    public interface ILibraryLogic
    {

        void ReceivingBook(string userName, Guid bookId);

        void ReturnBook(string userName, Guid bookId);

    }
}
