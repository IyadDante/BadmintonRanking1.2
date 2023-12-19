CREATE PROCEDURE [dbo].[spClub_DeleteByID]
	@ID int
AS

begin

	Delete from [dbo].[ClubsDetails]  where Id = @ID

end

