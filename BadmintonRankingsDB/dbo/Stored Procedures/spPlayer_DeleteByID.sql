CREATE PROCEDURE [dbo].[spPlayer_DeleteByID]
	@ID int
AS

begin

	Delete from [dbo].[PlayersDetails] where Id = @ID

end
