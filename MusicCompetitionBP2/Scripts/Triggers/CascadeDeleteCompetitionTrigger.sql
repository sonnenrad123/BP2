Create or alter trigger CascadeDeleteCompetition
on dbo.Competitions
instead of delete
as

	declare @CompID int;
	select @CompID = cmp.ID_COMP from deleted cmp;

	delete from MusicPerformances
	where CompetitingCompetitionID_COMP = @CompID;

	delete from Competitings
	where CompetitionID_COMP = @CompID

	Delete from PossessesASet
	where CompetitionID_COMP = @CompID;

	delete from Reservations
	where OrganizeCompetitionID_COMP = @CompID;

	Delete from Organizations
	where CompetitionID_COMP = @CompID;

	Delete from Competitions
	where ID_COMP = @CompID