CREATE PROCEDURE [dbo].[spPlayer_UpdateByID]
	@ID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Club nvarchar(50),
	@Gender nvarchar(50),
	@AgeGroup nvarchar(50),
	@YearOfBirth nvarchar(50)
AS
begin
	
	update [dbo].[PlayersDetails] 
	set FirstName = @FirstName, LastName = @LastName, Club = @Club, Gender = @Gender , AgeGroup = @AgeGroup, YearOfBirth = @YearOfBirth
	where @ID = Id;

end