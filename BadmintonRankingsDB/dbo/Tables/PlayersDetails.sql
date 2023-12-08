CREATE TABLE [dbo].[PlayersDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Club] NVARCHAR(50) NULL, 
    [YearOfBrith] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [AgeGroupID] NVARCHAR(50) NULL 
)
