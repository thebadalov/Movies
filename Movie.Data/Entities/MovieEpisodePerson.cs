using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Movie.Data.Entities
{
    public class MovieEpisodePerson : Entity
    {
        public int EpisodeId { get; set; }

        public int PersonId { get; set; }

        
        public bool IsDirector { get; set; }

        public virtual ICollection<MovieEpisodePersonCharacter> MovieEpisodePersonCharacters { get; set; }

        public virtual Episode Episode { get; set; }
        public virtual Person Person { get; set; }
    }
}
