using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class User : Entity
    {
        
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? Birthday { get; set; } // null olabilir

        public string Email { get; set; }

        public string Password { get; set; }

        public virtual ICollection<MovieRating> MovieRatings { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}