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
            Repositories.CompetitorRepository CR = new Repositories.CompetitorRepository(dbContext);

            Common.Models.Competitor cmp = new Common.Models.Competitor(1004998890046, "Ivan", "Gajic", DateTime.Now, "ivan.razor.gajic@gmail.com", "0654574892", new Common.Models.ADDRESS("85", "Novi Sad", "Bul. Papavla"));
            Console.WriteLine(CR.Remove(1004998890046)); 
            Console.ReadKey();
        }
    }
}
