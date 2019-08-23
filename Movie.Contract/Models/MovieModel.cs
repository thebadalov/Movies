﻿using System;

namespace Movie.Contract.Models
{
    public class MovieModel
    {
        public string Title { get; set; }

        public string MovieType { get; set; }
        public string MovieKind { get; set; }

        public DateTime? ReleaseAt { get; set; }

        public DateTime? EndAt { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public int PGRating { get; set; }

        public string Photo { get; set; }
    }
}