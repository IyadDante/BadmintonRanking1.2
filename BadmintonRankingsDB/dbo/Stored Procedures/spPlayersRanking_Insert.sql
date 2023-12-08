CREATE PROCEDURE [dbo].[spPlayersRanking_Insert]
	@PlayerID int,
	@TournamentID int,
	@SinglesPoints nvarchar(50),
	@SinglesRanking nvarchar(50),
	@DoublesPoints nvarchar(50),
	@DoublesRanking nvarchar(50),
	@MixedPoints nvarchar(50),
	@MixedRanking nvarchar(50),
	@OverallPoints nvarchar(50),
	@OverallRanking nvarchar(50),
	@FinishPosition nvarchar(50)
AS
	
begin

	insert into [dbo].[PlayersRankingDetails] (PlayerID, TournamentID, SinglesPoints, SinglesRanking, DoublesPoints, DoublesRanking, MixedPoints, MixedRanking, OverallPoints, OverallRanking, FinishPosition)
									Values (@PlayerID, @TournamentID, @SinglesPoints, @SinglesRanking, @DoublesPoints, @DoublesRanking, @MixedPoints, @MixedRanking, @OverallPoints, @OverallRanking,@FinishPosition)
end
