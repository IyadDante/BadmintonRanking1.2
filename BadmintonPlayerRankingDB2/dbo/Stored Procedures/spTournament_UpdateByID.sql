CREATE PROCEDURE [dbo].[spTournament_UpdateByID]
	@ID int,
	@TournamentName nvarchar(50),
	@TournamentDate datetime2(7),
	@Description nvarchar(MAX)
AS
begin
	
	update [dbo].[TournamentDetails]
	set TournamentName = @TournamentName, TournamentDate = @TournamentDate , Description = @Description
	where Id = @ID;

end