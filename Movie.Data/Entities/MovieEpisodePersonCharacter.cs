using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Data.Entities
{
    public class MovieEpisodePersonCharacter: Entity
    {
        public int MovieEpisodePersonId { get; set; }
        public int CharacterId { get; set; }

        public virtual MovieEpisodePerson MovieEpisodePerson { get; set; }
        public virtual Character Character { get; set; }
    }
}
