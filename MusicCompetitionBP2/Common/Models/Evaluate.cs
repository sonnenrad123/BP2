using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Evaluate
    {
        public Evaluate(short mARK, string cOMMENT, long isExpertJuryMemberJMBG_SIN, int isExpertGenreID_GENRE, int musicPerformanceID_PERF, IsExpert isExpert, MusicPerformance musicPerformance)
        {
            MARK = mARK;
            COMMENT = cOMMENT;
            IsExpertJuryMemberJMBG_SIN = isExpertJuryMemberJMBG_SIN;
            IsExpertGenreID_GENRE = isExpertGenreID_GENRE;
            MusicPerformanceID_PERF = musicPerformanceID_PERF;
            IsExpert = isExpert;
            MusicPerformance = musicPerformance;
        }

        public short MARK { get; set; }
        public string COMMENT { get; set; }
        public long IsExpertJuryMemberJMBG_SIN { get; set; }
        public int IsExpertGenreID_GENRE { get; set; }
        public int MusicPerformanceID_PERF { get; set; }

        public IsExpert IsExpert { get; set; }
        public MusicPerformance MusicPerformance { get; set; }
    }
}
