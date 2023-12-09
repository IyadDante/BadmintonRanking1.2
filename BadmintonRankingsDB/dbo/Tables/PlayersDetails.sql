CREATE TABLE [dbo].[PlayersDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [DateOfBirth] DATETIME2 NULL, 
    [GenderID] INT NULL, 
    [ClubID] INT NULL, 
    [AgeGroupID] INT NULL, 
    CONSTRAINT [FK_PlayersDetails_ToClubsDetails] FOREIGN KEY ([ClubID]) REFERENCES [ClubsDetails]([Id]), 
    CONSTRAINT [FK_PlayersDetails_ToGenderDetails] FOREIGN KEY ([GenderID]) REFERENCES [GenderDetails]([Id])
)
