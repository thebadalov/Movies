using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Character : Entity
    {
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }     
        public string Surname { get; set; }

        public DateTime? Birthday { get; set; }  // null olabilir anlamına gelıyor.

        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
    }
}
