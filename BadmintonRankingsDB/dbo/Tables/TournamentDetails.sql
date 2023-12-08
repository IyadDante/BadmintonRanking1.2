CREATE TABLE [dbo].[TournamentDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentName] NVARCHAR(50) NULL, 
    [TournamentDate] DATETIME2 NULL
)
