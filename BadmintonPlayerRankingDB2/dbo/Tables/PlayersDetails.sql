CREATE TABLE [dbo].[PlayersDetails] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50) NULL,
    [LastName]    NVARCHAR (50) NULL,
    [Club]        NVARCHAR (50) NULL,
    [Gender]      NVARCHAR (50) NULL,
    [AgeGroup]    NVARCHAR (50) NULL,
    [YearOfBirth] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

