CREATE PROCEDURE [dbo].[spClub_Insert]
	@ClubName nvarchar(50)	
AS
	
begin

	insert into [dbo].[ClubsDetails] (ClubName)
								Values (@ClubName);

end
