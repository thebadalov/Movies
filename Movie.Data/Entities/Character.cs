using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Character : Entity
    {
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Surname { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public DateTime Birthday { get; set; }

        public virtual ICollection<MoviePerson> MoviePersons { get; set; }
        public virtual ICollection<MovieEpisodePersonCharacter> MovieEpisodePersonCharacters { get; set; }
    }
}
