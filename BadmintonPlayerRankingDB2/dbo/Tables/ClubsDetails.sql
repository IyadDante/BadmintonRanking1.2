CREATE TABLE [dbo].[ClubsDetails] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ClubName]    NVARCHAR (50)  NULL,
    [Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

