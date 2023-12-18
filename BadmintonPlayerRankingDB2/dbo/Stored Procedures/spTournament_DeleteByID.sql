CREATE PROCEDURE [dbo].[spTournament_DeleteByID]
	@ID int
AS

begin

	Delete from [dbo].[TournamentDetails] where Id = @ID

end