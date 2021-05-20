using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class MusicPerformance
    {
        public MusicPerformance(int iD_PERF, string oRIG_PERFORMER, string sONG_NAME, string sONG_AUTHOR, DateTime dATE_PERF, long? competitingCompetitorJMBG_SIN, int? competitingCompetitionID_COMP, int genreID_GENRE, Competiting competiting, Genre genre)
        {
            ID_PERF = iD_PERF;
            ORIG_PERFORMER = oRIG_PERFORMER;
            SONG_NAME = sONG_NAME;
            SONG_AUTHOR = sONG_AUTHOR;
            DATE_PERF = dATE_PERF;
            CompetitingCompetitorJMBG_SIN = competitingCompetitorJMBG_SIN;
            CompetitingCompetitionID_COMP = competitingCompetitionID_COMP;
            GenreID_GENRE = genreID_GENRE;
            Competiting = competiting;
            Genre = genre;
        }

        public int ID_PERF { get; set; }
        public string ORIG_PERFORMER { get; set; }
        public string SONG_NAME { get; set; }
        public string SONG_AUTHOR { get; set; }
        public System.DateTime DATE_PERF { get; set; }
        public Nullable<long> CompetitingCompetitorJMBG_SIN { get; set; }
        public Nullable<int> CompetitingCompetitionID_COMP { get; set; }
        public int GenreID_GENRE { get; set; }
        public virtual Competiting Competiting { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
