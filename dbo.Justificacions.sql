CREATE TABLE [dbo].[Justificacions] (
    [Id]                   INT          IDENTITY (1, 1) NOT NULL,
    [IdSolucio]            INT          NOT NULL,
    [Percentatge]          INT          DEFAULT ((0)) NULL,
    [TeWord]               BIT          DEFAULT ((0)) NULL,
    [TeComprovantPagament] BIT          DEFAULT ((0)) NULL,
    [TeFacturaXML]         BIT          DEFAULT ((0)) NULL,
    [FabricantSolucio]     VARCHAR (50) DEFAULT ('') NULL,
    [Dada1]                BIT          DEFAULT ((0)) NULL,
    [Dada2]                BIT          DEFAULT ((0)) NULL,
    [TotalSolucio]         FLOAT (53)   DEFAULT ((0)) NULL,
    [ImplantacioInicial]   FLOAT (53)   DEFAULT ((0)) NULL,
    [Formacio]             FLOAT (53)   DEFAULT ((0)) NULL,
    [Manteniment]          FLOAT (53)   DEFAULT ((0)) NULL,
    [Suport]               FLOAT (53)   DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([IdSolucio] ASC),
    FOREIGN KEY ([IdSolucio]) REFERENCES [dbo].[Solucions] ([Id]) ON DELETE CASCADE
);

