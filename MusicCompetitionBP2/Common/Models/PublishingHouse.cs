using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class PublishingHouse
    {
        public PublishingHouse(int iD_PH, string nAME_PH, ADDRESS aDR_PH)
        {
            ID_PH = iD_PH;
            NAME_PH = nAME_PH;
            ADR_PH = aDR_PH;
        }

        public int ID_PH { get; set; }
        public string NAME_PH { get; set; }

        public ADDRESS ADR_PH { get; set; }
    }
}
