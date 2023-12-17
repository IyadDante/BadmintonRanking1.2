CREATE PROCEDURE [dbo].[spClub_Insert]
	@ClubName nvarchar(50),
	@Description nvarchar(50)
AS
	
begin

	insert into [dbo].[ClubsDetails] (ClubName, Description)
								Values (@ClubName , @Description);

end
