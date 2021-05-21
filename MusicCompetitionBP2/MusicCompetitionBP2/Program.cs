using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCompetitionBP2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicCompetitionDbContext dbContext = new MusicCompetitionDbContext();
            Repositories.CompetitingRepository compRep = new Repositories.CompetitingRepository(dbContext);
            Repositories.CompetitorRepository jr = new Repositories.CompetitorRepository(dbContext);

            //jr.Create(new Common.Models.Competitor(1004998890046, "Ivan", "Gajic", DateTime.Now, "email", "012312", new Common.Models.ADDRESS("85", "Novi Sad", "Bul Papavla")));
            List<Common.Models.Competiting> templist = compRep.ReadAll().ToList();

            Console.Read();
        }
    }
}
