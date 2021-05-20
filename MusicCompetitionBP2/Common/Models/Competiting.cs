using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Competiting
    {
        public Competiting(long competitorJMBG_SIN, int competitionID_COMP, Competitor competitor, Competition competition)
        {
            CompetitorJMBG_SIN = competitorJMBG_SIN;
            CompetitionID_COMP = competitionID_COMP;
            Competitor = competitor;
            Competition = competition;
        }

        public long CompetitorJMBG_SIN { get; set; }
        public int CompetitionID_COMP { get; set; }

        public Competitor Competitor { get; set; }
        public Competition Competition { get; set; }
    }
}
