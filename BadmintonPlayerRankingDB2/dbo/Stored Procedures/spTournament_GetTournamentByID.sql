CREATE PROCEDURE [dbo].[spTournament_GetTournamentByID]
		@ID int
AS

begin

	Select * from [dbo].[TournamentDetails]  where Id = @ID ;

end