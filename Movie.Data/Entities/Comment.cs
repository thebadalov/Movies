using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Comment : Entity
    {
        public int UserId { get; set; }

        public int MovieId { get; set; }

        public string Comments { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual User User { get; set; }

  
    }
}
