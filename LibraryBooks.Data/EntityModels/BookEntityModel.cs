using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.EntityModels
{
    [Table("Books")]
    public class BookEntityModel
    {

        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CountPages { get; set; }

        [Required]
        public int CountBooks { get; set; }

        [Required]
        public int Year { get; set; }



        public List<TakeBooksEnityModel> TakeBooks { get; set; }
    }
}
