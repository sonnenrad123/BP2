using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCompetitionBP2.Repositories
{
    public class HiredForRepository
    {
        private readonly MusicCompetitionDbContext dbContext;
        public HiredForRepository(MusicCompetitionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Create(long JuryJMBG,int competitionID)
        {
            try
            {
                dbContext.HiredForSet.Add(new HiredFor({ CompetitionID_COMP = competitionID,JuryMemberJMBG_SIN = JuryJMBG}));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(long JuryJMBG, int competitionID)
        {
            try
            {
                var hiredFor = dbContext.HiredForSet.FirstOrDefault((x) => x.CompetitionID_COMP == competitionID && x.JuryMemberJMBG_SIN == JuryJMBG);
                dbContext.HiredForSet.Remove(hiredFor);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
