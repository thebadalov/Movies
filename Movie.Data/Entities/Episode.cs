using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Episode : Entity
    {
        public int Number { get; set; }

        public int MovieId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public DateTime ReleaseAt { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Duration { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<MovieEpisodePerson> MovieEpisodePersons { get; set; }
    }
}
