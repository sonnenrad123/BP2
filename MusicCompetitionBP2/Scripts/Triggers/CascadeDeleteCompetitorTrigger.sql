Create or alter trigger CascadeDeleteCompetitorTrigger
ON dbo.Singers_Competitor
INSTEAD OF DELETE 
AS
	
	DECLARE @CompetitorJMBG bigint;
	SELECT @CompetitorJMBG = cmp.JMBG_SIN from deleted cmp;
	

	DELETE FROM MusicPerformances
	where CompetitingCompetitorJMBG_SIN = @CompetitorJMBG;

	DELETE FROM Competitings 
	where CompetitorJMBG_SIN = @CompetitorJMBG

	DELETE FROM Singers_Competitor
	where JMBG_SIN = @CompetitorJMBG


	