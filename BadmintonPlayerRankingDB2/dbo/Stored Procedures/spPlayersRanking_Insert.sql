CREATE PROCEDURE [dbo].[spPlayersRanking_Insert]
	@PlayerID int,
	@SinglesPoints nvarchar(50),
	@SinglesRanking nvarchar(50),
	@DoublesPoints nvarchar(50),
	@DoublesRanking nvarchar(50),
	@MixedPoints nvarchar(50),
	@MixedRanking nvarchar(50),
	@OverallPoints nvarchar(50),
	@OverallRanking nvarchar(50)
AS
	
begin

	insert into [dbo].[PlayersRankingDetails] (PlayerID, SinglesPoints, SinglesRanking, DoublesPoints, DoublesRanking, MixedPoints, MixedRanking, OverallPoints, OverallRanking)
									Values (@PlayerID, @SinglesPoints, @SinglesRanking, @DoublesPoints, @DoublesRanking, @MixedPoints, @MixedRanking, @OverallPoints, @OverallRanking)
end