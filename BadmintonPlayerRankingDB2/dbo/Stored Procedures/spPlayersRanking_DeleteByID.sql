CREATE PROCEDURE [dbo].[spPlayersRanking_DeleteByID]
	@ID int
AS

begin

	Delete from [dbo].[PlayersRankingDetails] where Id = @ID

end
