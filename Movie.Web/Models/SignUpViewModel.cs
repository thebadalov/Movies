﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Web.Models
{
    public class SignUpViewModel
    {
        public string Name { get; set; }        
        public string Surname { get; set; }
        public DateTime? Birthday { get; set; } // null olabilir     
        public string Email { get; set; }      
        public string Password { get; set; }
    }
}
