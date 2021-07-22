using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Common.ViewModels
{
    public class BookViewModel
    {
        
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public int CountPages { get; set; }

        public int CountBooks { get; set; }

        public int Year { get; set; }

        public Guid Id { get; set; }

    }
}
