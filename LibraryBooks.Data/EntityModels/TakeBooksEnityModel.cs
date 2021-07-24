using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.EntityModels
{
    [Table("TakeBooks")]
    public class TakeBooksEnityModel
    {

        [Required]
        public Guid Id { get; set; }

        [Required]
        public string IdUser { get; set; }

        [Required]
        public Guid BookId { get; set; }

        [Required]
        public DateTime DateOfTake { get; set; }


        public BookEntityModel Book { get; set; }
        public UserEntityModel User { get; set; }


    }
}
