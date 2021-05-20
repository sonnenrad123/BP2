using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ADDRESS
    {
        public ADDRESS(string hOME_NUMBER, string cITY, string sTREET)
        {
            HOME_NUMBER = hOME_NUMBER;
            CITY = cITY;
            STREET = sTREET;
        }

        public string HOME_NUMBER { get; set; }
        public string CITY { get; set; }
        public string STREET { get; set; }
    }
}
