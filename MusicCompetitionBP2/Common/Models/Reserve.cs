using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Reserve
    {
        public Reserve(DateTime dATE_RES, TimeSpan sTART_TIME, TimeSpan eND_TIME, int organizePublishingHouseID_PH, int organizeCompetitionID_COMP, int performanceHallID_HALL, Organize organize, PerformanceHall performanceHall)
        {
            DATE_RES = dATE_RES;
            START_TIME = sTART_TIME;
            END_TIME = eND_TIME;
            OrganizePublishingHouseID_PH = organizePublishingHouseID_PH;
            OrganizeCompetitionID_COMP = organizeCompetitionID_COMP;
            PerformanceHallID_HALL = performanceHallID_HALL;
            Organize = organize;
            PerformanceHall = performanceHall;
        }

        public System.DateTime DATE_RES { get; set; }
        public System.TimeSpan START_TIME { get; set; }
        public System.TimeSpan END_TIME { get; set; }
        public int OrganizePublishingHouseID_PH { get; set; }
        public int OrganizeCompetitionID_COMP { get; set; }
        public int PerformanceHallID_HALL { get; set; }

        public Organize Organize { get; set; }
        public PerformanceHall PerformanceHall { get; set; }
    }
}
