using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Common.ViewModels
{
    public class AuthorizationViewModel
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        
        [DefaultValue(false)]
        public bool RememberMe { get; set; }


    }
}
