using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class MoviePerson : Entity
    {
        public int MovieId { get; set; }

        public int PersonId { get; set; }

        public int CharacterId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string PersonType { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
        public virtual Character Character { get; set; }
    }
}
