using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    [ServiceContract]
    public interface IAllOperations:ICreateOperations,IReadOperations,IUpdateOperations,IDeleteOperations
    {
        [OperationContract]
        bool AddCompetitorToCompetition(long competitorJMBG, int competitionID);
        [OperationContract]
        bool AddEvaluationForMusicPerformance(long juryMemberJMBG, int genreID, int performanceID, short mark, string comment);
        [OperationContract]
        bool AddGenreExpertise(int genreID, long juryMemberJMBG);
        [OperationContract]
        bool HireSingerForCompetition(long juryMemberJMBG, int competitionID);
        [OperationContract]
        bool AddPublishingHouseOrganization(int competitionID, int phID);
        [OperationContract]
        bool AddHallReservation(int competitionID, int phID, int hallID, DateTime dATE_RES, TimeSpan sTART_TIME, TimeSpan eND_TIME);
    }
}
