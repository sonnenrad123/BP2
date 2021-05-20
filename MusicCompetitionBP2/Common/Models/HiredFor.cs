using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class HiredFor
    {
        public HiredFor(long juryMemberJMBG_SIN, int competitionID_COMP, JuryMember juryMember, Competition competition)
        {
            JuryMemberJMBG_SIN = juryMemberJMBG_SIN;
            CompetitionID_COMP = competitionID_COMP;
            JuryMember = juryMember;
            Competition = competition;
        }

        public long JuryMemberJMBG_SIN { get; set; }
        public int CompetitionID_COMP { get; set; }

        public JuryMember JuryMember { get; set; }
        public Competition Competition { get; set; }
    }
}
