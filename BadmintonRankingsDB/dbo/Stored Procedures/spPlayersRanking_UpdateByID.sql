CREATE PROCEDURE [dbo].[spPlayersRanking_UpdateByID]
	@ID int
AS

begin

	Select * from [dbo].[PlayersRankingDetails]  where Id = @ID ;

end
