CREATE PROCEDURE [dbo].[spTournament_UpdateByID]
	@ID int,
	@TournamentName nvarchar(50),
	@TournamentDate datetime2(7)
AS
begin
	
	update [dbo].[TournamentDetails]
	set TournamentName = @TournamentName, TournamentDate = @TournamentDate
	where Id = @ID;

end
