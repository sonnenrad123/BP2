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
            Repositories.CompetitorRepository jr = new Repositories.CompetitorRepository(dbContext);

            /* Repositories.CompetitingRepository compRep = new Repositories.CompetitingRepository(dbContext);

             Repositories.CompetitionRepository comprepo = new Repositories.CompetitionRepository(dbContext);
            comprepo.Create(new Common.Models.Competition(-1, DateTime.Now, DateTime.Now.AddDays(1), "Takmicenje1", 10));
             comprepo.Create(new Common.Models.Competition(-1, DateTime.Now, DateTime.Now.AddDays(3), "Takmicenje2", 22));



            jr.Create(new Common.Models.Competitor(1004998890046, "Ivan", "Gajic", DateTime.Now, "ivan_gajic@uns.ac.rs", "0659999", new Common.Models.ADDRESS("85", "Novi Sad", "Bul Papavla")));

             Repositories.JuryMemberRepository ziri = new Repositories.JuryMemberRepository(dbContext);
             ziri.Create(new Common.Models.JuryMember(2512949, "Milan", "Gajic", DateTime.Now, "email", "012312", new Common.Models.ADDRESS("85", "Novi Sad", "Bul Papavla Drugi")));



             Repositories.PublishinHouseRepository pubhouseRepo = new Repositories.PublishinHouseRepository(dbContext);
            pubhouseRepo.Create(new Common.Models.PublishingHouse(-1, "Izdavacka kuca 1", new Common.Models.ADDRESS("10","Novi Sad","NN")));
             pubhouseRepo.Create(new Common.Models.PublishingHouse(-1, "Izdavacka kuca 2", new Common.Models.ADDRESS("20","Novi Sad","NN")));
           pubhouseRepo.Create(new Common.Models.PublishingHouse(-1, "Izdavacka kuca 3", new Common.Models.ADDRESS("30","Novi Sad","NN")));

             Repositories.PerformanceHallRepository perfHallRepo = new Repositories.PerformanceHallRepository(dbContext);
            perfHallRepo.Create(new Common.Models.PerformanceHall(-1, "Hal1", 10));
            perfHallRepo.Create(new Common.Models.PerformanceHall(-1, "Hal2", 20));

             //da organizujemo neka takmicenja
             Repositories.OrganizeRepository orgRepo = new Repositories.OrganizeRepository(dbContext);
            Console.WriteLine(orgRepo.Create(2,3));
             Console.WriteLine(orgRepo.Create(1, 2));


             //da iznajmimo halu
             Repositories.ReserveRepository reserveRepo = new Repositories.ReserveRepository(dbContext);
             Console.WriteLine(reserveRepo.Create(2,1,2,DateTime.Now,new TimeSpan(),new TimeSpan()));



             //dodamo zanr
             Repositories.GenreRepository genrerepo = new Repositories.GenreRepository(dbContext);
            genrerepo.Create(new Common.Models.Genre(5, "Narodnjakcina"));
             genrerepo.Create(new Common.Models.Genre(-1, "Rock"));

            Repositories.IsExpertRepository isexprepo = new Repositories.IsExpertRepository(dbContext);
             isexprepo.Create(1, 2512949);
            compRep.Create(1004998890046, 2);

             //sad da probamo dodati izvestaj o nastupu
            Repositories.MusicPerformanceRepository MPRepo = new Repositories.MusicPerformanceRepository(dbContext);
            long id_pevaca = 1004998890046;
            int id_takmicenja = 2;
            int id_zanra = 1;

             MPRepo.Create(id_takmicenja, id_pevaca, id_zanra, "Authorr", "OrigPerf", "SongName", DateTime.Now);


             //da pokusamo oceniti nesto

            MusicCompetitionDbContext dbContext2 = new MusicCompetitionDbContext();
            Repositories.EvaluateRepository evalrepo = new Repositories.EvaluateRepository(dbContext2);

            long ziri_JMBG = 2512949;
            int id_nastupa = 1;

            Console.WriteLine(evalrepo.Create(ziri_JMBG,id_nastupa, 10, "LepKomentar") ); 

           //evalrepo.Update(100, "Ovo je izmena", 2512949, 2);

           // Common.Models.Evaluate ocena = evalrepo.Read(2512949, 13);

           //jr.Remove(1004998890046);*/

            //Repositories.PerformanceHallRepository pf = new Repositories.PerformanceHallRepository(dbContext);
           // pf.Remove(2);

            Console.Read();
        }
    }
}
