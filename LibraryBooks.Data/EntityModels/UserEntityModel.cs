using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.EntityModels
{
    public class UserEntityModel :IdentityUser
    {

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Patronymic { get; set; }




        public List<TakeBooksEnityModel> TakeBooks { get; set; }

    }
}
