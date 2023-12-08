CREATE PROCEDURE [dbo].[spTournament_Insert]
	@TournamentName nvarchar(50),
	@TournamentDate datetime2(7)
AS
	
begin

	insert into [dbo].[TournamentDetails] (TournamentName, TournamentDate)	Values (@TournamentName, @TournamentDate);

end
