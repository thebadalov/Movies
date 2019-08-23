﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Web.Models
{
    public class SeriesViewModel
    {
        public string Title { get; set; }

        public string MovieType { get; set; }
        public string MovieKind { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }

        public DateTime? ReleaseAt { get; set; }

        public DateTime? EndAt { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public int PGRating { get; set; }

        public string Photo { get; set; }
    }
}
