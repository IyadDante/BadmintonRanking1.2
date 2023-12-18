CREATE TABLE [dbo].[TournamentDetails] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [TournamentName] NVARCHAR (50)  NULL,
    [TournamentDate] DATETIME2 (7)  NULL,
    [Description]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

