using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Data.Entities
{
    public class Movie : Entity
    {
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string MovieType { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public DateTime ReleaseAt { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public DateTime EndAt { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        [Column(TypeName = "int")]
        public int Duration { get; set; }

        [Column(TypeName = "int")]
        public int PGRating { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Photo { get; set; }

        public virtual ICollection<MoviePerson> MoviePersons { get; set; }
        public virtual ICollection<MovieRating> MovieRatings { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
