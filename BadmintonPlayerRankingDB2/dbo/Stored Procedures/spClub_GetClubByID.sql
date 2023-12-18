CREATE PROCEDURE [dbo].[spClub_GetClubByID]
	@ID int
AS

begin

	Select * from [dbo].[ClubsDetails]  where Id = @ID ;

end