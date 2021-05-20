using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class IsExpert
    {
        public IsExpert(long juryMemberJMBG_SIN, int genreID_GENRE, JuryMember juryMember, Genre genre)
        {
            JuryMemberJMBG_SIN = juryMemberJMBG_SIN;
            GenreID_GENRE = genreID_GENRE;
            JuryMember = juryMember;
            Genre = genre;
        }

        public long JuryMemberJMBG_SIN { get; set; }
        public int GenreID_GENRE { get; set; }

        public  JuryMember JuryMember { get; set; }
        public Genre Genre { get; set; }
    }
}
