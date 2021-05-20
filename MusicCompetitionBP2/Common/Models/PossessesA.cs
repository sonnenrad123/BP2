using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class PossessesA
    {
        public PossessesA(int competitionID_COMP, int genreID_GENRE, Competition competition, Genre genre)
        {
            CompetitionID_COMP = competitionID_COMP;
            GenreID_GENRE = genreID_GENRE;
            Competition = competition;
            Genre = genre;
        }

        public int CompetitionID_COMP { get; set; }
        public int GenreID_GENRE { get; set; }

        public  Competition Competition { get; set; }
        public Genre Genre { get; set; }
    }
}
