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

            Repositories.JuryMemberRepository ziri = new Repositories.JuryMemberRepository(dbContext);
            ziri.Create(new Common.Models.JuryMember(2512949, "Milan", "Gajic", DateTime.Now, "email", "012312", new Common.Models.ADDRESS("85", "Novi Sad", "Bul Papavla Drugi")));

            Repositories.PublishinHouseRepository pubhouseRepo = new Repositories.PublishinHouseRepository(dbContext);
           // pubhouseRepo.Create(new Common.Models.PublishingHouse(-1, "Izdavacka kuca 1", new Common.Models.ADDRESS("10","Novi Sad","NN")));
            //pubhouseRepo.Create(new Common.Models.PublishingHouse(-1, "Izdavacka kuca 2", new Common.Models.ADDRESS("20","Novi Sad","NN")));
           // pubhouseRepo.Create(new Common.Models.PublishingHouse(-1, "Izdavacka kuca 3", new Common.Models.ADDRESS("30","Novi Sad","NN")));

            Repositories.PerformanceHallRepository perfHallRepo = new Repositories.PerformanceHallRepository(dbContext);
            //perfHallRepo.Create(new Common.Models.PerformanceHall(-1, "Hal1", 10));
            //perfHallRepo.Create(new Common.Models.PerformanceHall(-1, "Hal2", 20));

            //da organizujemo neka takmicenja
            Repositories.OrganizeRepository orgRepo = new Repositories.OrganizeRepository(dbContext);
            //Console.WriteLine(orgRepo.Create(4,2));
            //Console.WriteLine(orgRepo.Create(2, 1));


            //da iznajmimo halu
            Repositories.ReserveRepository reserveRepo = new Repositories.ReserveRepository(dbContext);
            //Console.WriteLine(reserveRepo.Create(2,4,2,DateTime.Now,new TimeSpan(),new TimeSpan()));

            Common.Models.Reserve retList = reserveRepo.Read(2, 4, 2);

            //jr.Create(new Common.Models.Competitor(1004998890046, "Ivan", "Gajic", DateTime.Now, "email", "012312", new Common.Models.ADDRESS("85", "Novi Sad", "Bul Papavla")));
            //List<Common.Models.Competiting> templist = compRep.ReadAll().ToList();

            //dodamo zanr
            Repositories.GenreRepository genrerepo = new Repositories.GenreRepository(dbContext);
            genrerepo.Update(new Common.Models.Genre(5, "Narodnjakcina"));
            // genrerepo.Create(new Common.Models.Genre(-1, "Rock"));

            Repositories.IsExpertRepository isexprepo = new Repositories.IsExpertRepository(dbContext);
          // isexprepo.Create(5, 2512949);


            //sad da probamo dodati izvestaj o nastupu
            Repositories.MusicPerformanceRepository MPRepo = new Repositories.MusicPerformanceRepository(dbContext);
            long id_pevaca = 1004998890046;
            int id_takmicenja = 3;
            int id_zanra = 5;

            //MPRepo.Create(id_takmicenja, id_pevaca, id_zanra, "Authorr", "OrigPerf", "SongName", DateTime.Now);
            List<Common.Models.MusicPerformance> mptemp = MPRepo.ReadAll().ToList();

            //da pokusamo oceniti nesto

            MusicCompetitionDbContext dbContext2 = new MusicCompetitionDbContext();
            Repositories.EvaluateRepository evalrepo = new Repositories.EvaluateRepository(dbContext2);
           
            long ziri_JMBG = 2512949;
            int id_nastupa = 13;

            //evalrepo.Create(ziri_JMBG,14,2, "LepKomentar");

            evalrepo.Update(5, "Ovo je izmena", 2512949, 13);

            Common.Models.Evaluate ocena = evalrepo.Read(2512949, 13);
            

            Console.Read();
        }
    }
}
