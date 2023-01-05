CREATE TABLE [dbo].[Solucions] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [idSolucio]     INT          NOT NULL,
    [Contracte]     VARCHAR (50) NOT NULL,
    [DataContracte] DATE         NOT NULL,
    [DataVenciment] DATE         NOT NULL,
    [idEmpresa]     INT          NOT NULL,
    [Justificat]    BIT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([idSolucio]) REFERENCES [dbo].[TipusSolucions] ([Id]),
    FOREIGN KEY ([idEmpresa]) REFERENCES [dbo].[Empreses] ([Id])
);

