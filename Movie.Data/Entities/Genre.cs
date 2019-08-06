using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Genre : Entity
    {
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
