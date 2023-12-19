CREATE PROCEDURE [dbo].[spTournament_Insert]
	@TournamentName nvarchar(50),
	@TournamentDate datetime2(7),
	@Description nvarchar(MAX)
AS
	
begin

	insert into [dbo].[TournamentDetails] (TournamentName, TournamentDate, Description)	Values (@TournamentName, @TournamentDate, @Description);

end
