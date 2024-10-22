CREATE TABLE [dbo].[Users] (
    [Id]       INT  IDENTITY (1, 1) NOT NULL,
    [Name]     TEXT NULL,
    [First]    TEXT NULL,
    [Last]     TEXT NULL,
    [Password] TEXT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

