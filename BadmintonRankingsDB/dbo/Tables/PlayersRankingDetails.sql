CREATE TABLE [dbo].[PlayersRankingDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlayerID] INT NULL, 
    [TournamentID] INT NULL, 
    [SinglesPoints] NVARCHAR(50) NULL, 
    [SinglesRanking] NVARCHAR(50) NULL, 
    [DoublesPoints] NVARCHAR(50) NULL, 
    [DoublesRanking] NVARCHAR(50) NULL, 
    [MixedPoints] NVARCHAR(50) NULL, 
    [MixedRanking] NVARCHAR(50) NULL, 
    [OverallPoints] NVARCHAR(50) NULL, 
    [OverallRanking] NVARCHAR(50) NULL, 
    [FinishPosition] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_PlayersRankingDetails_ToPlayerID] FOREIGN KEY ([PlayerID]) REFERENCES [PlayersDetails]([Id]), 
    CONSTRAINT [FK_PlayersRankingDetails_ToTournamentID] FOREIGN KEY ([TournamentID]) REFERENCES [TournamentDetails]([Id])
)
