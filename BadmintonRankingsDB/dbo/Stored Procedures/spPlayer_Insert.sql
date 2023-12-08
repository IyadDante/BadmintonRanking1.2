CREATE PROCEDURE [dbo].[spPlayer_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
	
begin

	insert into [dbo].[PlayersDetails] (FirstName, LastName)	Values (@FirstName, @LastName);

end