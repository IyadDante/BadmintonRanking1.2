CREATE PROCEDURE [dbo].[spPlayersRanking_GetPlayersRankingByID]
	@ID int
AS

begin

	Select * from [dbo].[PlayersRankingDetails]  where Id = @ID ;

end