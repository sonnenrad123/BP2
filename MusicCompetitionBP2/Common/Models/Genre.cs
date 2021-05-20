using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Genre
    {
        public Genre(int iD_GENRE, string gENRE_NAME)
        {
            ID_GENRE = iD_GENRE;
            GENRE_NAME = gENRE_NAME;
        }

        public int ID_GENRE { get; set; }
        public string GENRE_NAME { get; set; }
    }
}
