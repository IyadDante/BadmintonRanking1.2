CREATE TABLE [dbo].[PlayersRankingDetails] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [PlayerID]       INT           NULL,
    [SinglesPoints]  NVARCHAR (50) NULL,
    [SinglesRanking] NVARCHAR (50) NULL,
    [DoublesPoints]  NVARCHAR (50) NULL,
    [DoublesRanking] NVARCHAR (50) NULL,
    [MixedPoints]    NVARCHAR (50) NULL,
    [MixedRanking]   NVARCHAR (50) NULL,
    [OverallPoints]  NVARCHAR (50) NULL,
    [OverallRanking] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PlayersRankingDetails_ToPlayerID] FOREIGN KEY ([PlayerID]) REFERENCES [dbo].[PlayersDetails] ([Id])
);

