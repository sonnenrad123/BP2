Create or alter trigger CascadeDeleteJuryMemberTrigger
ON dbo.Singers_JuryMember
INSTEAD OF DELETE
AS

	DECLARE @JuryMemberJMBG bigint;
	SELECT @JuryMemberJMBG = cmp.JMBG_SIN from deleted cmp;


	DELETE FROM HiredForSet
	where JuryMemberJMBG_SIN = @JuryMemberJMBG;

	DELETE FROM Evaluations
	where IsExpertJuryMemberJMBG_SIN = @JuryMemberJMBG;

	DELETE FROM IsExpertSet
	where JuryMemberJMBG_SIN = @JuryMemberJMBG;

	DELETE FROM Singers_JuryMember
	where JMBG_SIN = @JuryMemberJMBG