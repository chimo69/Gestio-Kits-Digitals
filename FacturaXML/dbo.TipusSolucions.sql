CREATE TABLE [dbo].[TipusSolucions] (
    [Id]  INT          IDENTITY (1, 1) NOT NULL,
    [Nom] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Nom] ASC)
);

