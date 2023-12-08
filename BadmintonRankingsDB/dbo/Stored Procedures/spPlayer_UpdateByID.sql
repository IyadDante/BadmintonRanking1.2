CREATE PROCEDURE [dbo].[spPlayer_UpdateByID]
	@ID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	
	update [dbo].[PlayersDetails] 
	set FirstName = @FirstName, LastName = @LastName
	where @ID = Id;

end
	