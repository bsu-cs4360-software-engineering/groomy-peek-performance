CREATE TABLE [dbo].[Users] (
    [Id]       INT  IDENTITY (1, 1) NOT NULL,
    [Name]     TEXT NULL,
    [Password] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

