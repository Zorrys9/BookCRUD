using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Common.ViewModels
{
    public class SearchViewModel
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public int? StartValueYear { get; set; } 

        public int? EndValueYear { get; set; }

        public int? StartValueCountPages { get; set; }

        public int? EndValueCountPages { get; set; }

        [DefaultValue(false)]
        public bool InStock { get; set; }
        

    }
}
