using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Common;
using Common.Interfaces;

namespace MusicCompetitionBP2
{
    public class Server : IAllOperations
    {

        private MainRepository repo = new MainRepository(new MusicCompetitionDbContext());

        public bool AddCompetition(Common.Models.Competition c)
        {
            return repo.CompetitionRepository.Create(c);
        }

        public bool AddCompetitor(Common.Models.Competitor c)
        {
            return repo.CompetitorRepository.Create(c);
        }

        public bool AddCompetitorToCompetition(long competitorJMBG, int competitionID)
        {
            return repo.CompetitingRepository.Create(competitorJMBG, competitionID);
        }

        public bool AddEvaluationForMusicPerformance(long juryMemberJMBG, int genreID, int performanceID, short mark, string comment)
        {
            return repo.EvaluateRepository.Create(juryMemberJMBG, performanceID, mark, comment);
        }

        public bool AddGenre(Common.Models.Genre g)
        {
            return repo.GenreRepository.Create(g);
        }

        public bool AddGenreExpertise(int genreID, long juryMemberJMBG)
        {
            return repo.IsExpertRepository.Create(genreID, juryMemberJMBG);
        }

        public bool AddHallReservation(int competitionID, int phID, int hallID, DateTime dATE_RES, TimeSpan sTART_TIME, TimeSpan eND_TIME)
        {
            return repo.ReserveRepository.Create(phID, competitionID, hallID, dATE_RES, sTART_TIME, eND_TIME);
        }

        public bool AddJuryMember(Common.Models.JuryMember jM)
        {
            return repo.JuryMemberRepository.Create(jM);
        }

        public bool AddMusicPerformance(Common.Models.MusicPerformance mP)
        {
            return repo.MusicPerformanceRepository.Create(mP.CompetitingCompetitionID_COMP, mP.CompetitingCompetitorJMBG_SIN, mP.GenreID_GENRE, mP.SONG_AUTHOR, mP.ORIG_PERFORMER, mP.SONG_NAME, mP.DATE_PERF);
        }

        public bool AddPerformanceHall(Common.Models.PerformanceHall pH)
        {
            return repo.PerformanceHallRepository.Create(pH);
        }

        public bool AddPublishingHouse(Common.Models.PublishingHouse ph)
        {
            return repo.PublishingHouseRepository.Create(ph);
        }

        public bool AddPublishingHouseOrganization(int competitionID, int phID)
        {
            return repo.OrganizeRepository.Create(competitionID, phID);
        }


        public bool DeleteCompetition(int iD)
        {
            return repo.CompetitionRepository.Remove(iD);
        }

        public bool DeleteCompetitor(long JMBG)
        {
            return repo.CompetitorRepository.Remove(JMBG);
        }

        public bool DeleteGenre(int iD)
        {
            return repo.GenreRepository.Remove(iD);
        }

        public bool DeleteJuryMember(long JMBG)
        {
            return repo.JuryMemberRepository.Remove(JMBG);
        }

        public bool DeleteMusicPerformance(int iD)
        {
            return repo.MusicPerformanceRepository.Remove(iD);
        }

        public bool DeletePerformanceHall(int iD)
        {
            return repo.PerformanceHallRepository.Remove(iD);
        }

        public bool DeletePublishingHouse(int iD)
        {
            return repo.PublishingHouseRepository.Remove(iD);
        }


        public void EditCompetition(Common.Models.Competition c)
        {
            repo.CompetitionRepository.Update(c);
        }

        public void EditCompetitor(Common.Models.Competitor c)
        {
            repo.CompetitorRepository.Update(c);
        }

        public void EditGenre(Common.Models.Genre g)
        {
            repo.GenreRepository.Update(g);
        }

        public void EditJuryMember(Common.Models.JuryMember jM)
        {
            repo.JuryMemberRepository.Update(jM);
        }

        public void EditMusicPerformance(Common.Models.MusicPerformance mP)
        {
            repo.MusicPerformanceRepository.Update(mP.ID_PERF, mP.SONG_AUTHOR, mP.ORIG_PERFORMER, mP.SONG_NAME, mP.DATE_PERF);
        }

        public void EditPerformanceHall(Common.Models.PerformanceHall pH)
        {
            repo.PerformanceHallRepository.Update(pH);
        }

        public void EditPublishingHouse(Common.Models.PublishingHouse ph)
        {
            repo.PublishingHouseRepository.Update(ph);
        }

        

        public bool HireSingerForCompetition(long juryMemberJMBG, int competitionID)
        {
            return repo.HiredForRepository.Create(juryMemberJMBG, competitionID);
        }

        public Common.Models.Competition ReadCompetition(int iD)
        {
            return repo.CompetitionRepository.Read(iD);
        }

        public IEnumerable<Common.Models.Competition> ReadCompetitions()
        {
            return repo.CompetitionRepository.ReadAll();
        }

        public Common.Models.Competitor ReadCompetitor(long JMBG)
        {
            return repo.CompetitorRepository.Read(JMBG);
        }

        public IEnumerable<Common.Models.Competitor> ReadCompetitors()
        {
            return repo.CompetitorRepository.ReadAll();
        }

        public Common.Models.Genre ReadGenre(int iD)
        {
            return repo.GenreRepository.Read(iD);
        }

        public IEnumerable<Common.Models.Genre> ReadGenres()
        {
            return repo.GenreRepository.ReadAll();
        }

        public Common.Models.JuryMember ReadJuryMember(long JMBG)
        {
            return repo.JuryMemberRepository.Read(JMBG);
        }

        public IEnumerable<Common.Models.JuryMember> ReadJuryMembers()
        {
            return repo.JuryMemberRepository.ReadAll();
        }

        public Common.Models.MusicPerformance ReadMusicPerformance(int iD)
        {
            return repo.MusicPerformanceRepository.Read(iD);
        }

        public IEnumerable<Common.Models.MusicPerformance> ReadMusicPerformances()
        {
            return repo.MusicPerformanceRepository.ReadAll();
        }

        public Common.Models.PerformanceHall ReadPerformanceHall(int iD)
        {
            return repo.PerformanceHallRepository.Read(iD);
        }

        public IEnumerable<Common.Models.PerformanceHall> ReadPerformanceHalls()
        {
            return repo.PerformanceHallRepository.ReadAll();
        }

        public Common.Models.PublishingHouse ReadPublishingHouse(int iD)
        {
            return repo.PublishingHouseRepository.Read(iD);
        }

        public IEnumerable<Common.Models.PublishingHouse> ReadPublishingHouses()
        {
            return repo.PublishingHouseRepository.ReadAll();
        }

      

    }
}
