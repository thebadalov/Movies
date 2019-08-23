using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Person : Entity
    {
        public string Name { get; set; }


        public string Surname { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
     
    }
}
