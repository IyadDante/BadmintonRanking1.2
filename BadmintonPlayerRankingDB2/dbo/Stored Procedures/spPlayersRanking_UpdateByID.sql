CREATE PROCEDURE [dbo].[spPlayersRanking_UpdateByID]
	@ID int,
	@PlayerID int ,
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
	
	update [dbo].[PlayersRankingDetails] 
	set PlayerID = @PlayerID,
	SinglesPoints = @SinglesPoints,
	SinglesRanking = @SinglesRanking,
	DoublesPoints = @DoublesPoints,
	DoublesRanking = @DoublesRanking,
	MixedPoints = @MixedPoints,
	MixedRanking = @MixedRanking,
	OverallPoints = @OverallPoints,
	OverallRanking = @OverallRanking
	where   @ID = Id

end