CREATE PROCEDURE [dbo].[spClub_UpdateByID]
	@ID int,
	@ClubName nvarchar(50)
AS
begin
	
	update [dbo].[ClubsDetails]
	set ClubName = @ClubName
	where @ID = Id;

end
