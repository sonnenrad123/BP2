Create or alter trigger CascadeDeletePublishingHouse
on dbo.PublishingHouses
instead of delete
as

	declare @PhID int;
	select @PhID = cmp.ID_PH from deleted cmp;

	delete from Reservations
	where OrganizePublishingHouseID_PH = @PhID;

	delete from Organizations
	where PublishingHouseID_PH = @PhID;

	delete from PublishingHouses
	where ID_PH = @PhID;