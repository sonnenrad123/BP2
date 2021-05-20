using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Singer
    {
        public Singer(long jMBG_SIN, string fIRSTNAME_SIN, string lASTNAME_SIN, DateTime bIRTHDATE_SIN, string eMAIL_SIN, string pHONE_NO_SIN, ADDRESS aDDRESS_SIN)
        {
            JMBG_SIN = jMBG_SIN;
            FIRSTNAME_SIN = fIRSTNAME_SIN;
            LASTNAME_SIN = lASTNAME_SIN;
            BIRTHDATE_SIN = bIRTHDATE_SIN;
            EMAIL_SIN = eMAIL_SIN;
            PHONE_NO_SIN = pHONE_NO_SIN;
            ADDRESS_SIN = aDDRESS_SIN;
        }

        public long JMBG_SIN { get; set; }
        public string FIRSTNAME_SIN { get; set; }
        public string LASTNAME_SIN { get; set; }
        public System.DateTime BIRTHDATE_SIN { get; set; }
        public string EMAIL_SIN { get; set; }
        public string PHONE_NO_SIN { get; set; }
        public string Type { get; set; }
        public ADDRESS ADDRESS_SIN { get; set; }
        public override string ToString()
        {
            return "JMBG: " + JMBG_SIN + "FirstName: " + FIRSTNAME_SIN + "LastName: " + LASTNAME_SIN + "BirthDate: " + BIRTHDATE_SIN.ToString("dd.MM.yy") + "Email: " + EMAIL_SIN + "PhoneNo: " + PHONE_NO_SIN +
                "Address: " + ADDRESS_SIN.STREET + ", " + ADDRESS_SIN.HOME_NUMBER + ", " + ADDRESS_SIN.CITY + ".";
        }
    }
}
