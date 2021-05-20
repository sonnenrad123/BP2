using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Competition
    {
        public Competition(int iD_COMP, DateTime dATE_START, DateTime dATE_END, string nAME_COMP, int mAX_COMPETITORS)
        {
            ID_COMP = iD_COMP;
            DATE_START = dATE_START;
            DATE_END = dATE_END;
            NAME_COMP = nAME_COMP;
            MAX_COMPETITORS = mAX_COMPETITORS;
        }

        public int ID_COMP { get; set; }
        public System.DateTime DATE_START { get; set; }
        public System.DateTime DATE_END { get; set; }
        public string NAME_COMP { get; set; }
        public int MAX_COMPETITORS { get; set; }
    }
}
