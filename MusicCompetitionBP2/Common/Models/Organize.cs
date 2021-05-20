using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Organize
    {
        public Organize(int publishingHouseID_PH, int competitionID_COMP, PublishingHouse publishingHouse, Competition competition)
        {
            PublishingHouseID_PH = publishingHouseID_PH;
            CompetitionID_COMP = competitionID_COMP;
            PublishingHouse = publishingHouse;
            Competition = competition;
        }

        public int PublishingHouseID_PH { get; set; }
        public int CompetitionID_COMP { get; set; }

        public PublishingHouse PublishingHouse { get; set; }
        public Competition Competition { get; set; }
    }
}
