using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Web.Models
{
    public class SignInViewModel
    {
        [Required]
        public string EmailAdress {get; set;}
        [Required]
        public string Password { get; set; }
    }
}
