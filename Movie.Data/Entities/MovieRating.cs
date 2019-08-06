﻿namespace Movie.Data.Entities
{
    public class MovieRating : Entity
    {
        public int UserId { get; set; }

        public int MovieId { get; set; }

        public int Rating { get; set; }

        public virtual User User { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
