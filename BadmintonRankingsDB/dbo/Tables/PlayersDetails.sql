CREATE TABLE [dbo].[PlayersDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Club] NVARCHAR(50) NULL, 
    [YearOfBrith] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(3) NULL, 
    [AgeGroup] NVARCHAR(3) NULL, 
    CONSTRAINT [FK_PlayersDetails_ToClubsDetails] FOREIGN KEY ([Club]) REFERENCES [ClubsDetails]([ID]), 
    CONSTRAINT [FK_PlayersDetails_ToGenderDetails] FOREIGN KEY ([Gender]) REFERENCES [GenderDetails]([Id])
)
