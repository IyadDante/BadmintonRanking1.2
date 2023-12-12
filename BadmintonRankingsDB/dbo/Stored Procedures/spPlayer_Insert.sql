CREATE PROCEDURE [dbo].[spPlayer_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Club nvarchar(50),
	@Gender nvarchar(50),
	@AgeGroup nvarchar(50),
	@YearOfBirth nvarchar(50)
AS
	
begin

	insert into [dbo].[PlayersDetails] (FirstName, LastName, Club, Gender, AgeGroup, YearOfBirth )	Values (@FirstName, @LastName, @Club, @Gender, @AgeGroup, @YearOfBirth);

end