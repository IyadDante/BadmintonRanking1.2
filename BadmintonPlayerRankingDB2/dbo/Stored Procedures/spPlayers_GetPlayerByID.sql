CREATE PROCEDURE [dbo].[spPlayers_GetPlayerByID]
@ID int
AS

begin

	Select * from [dbo].[PlayersDetails]  where Id = @ID ;

end
