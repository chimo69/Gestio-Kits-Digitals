CREATE TABLE [dbo].[Empreses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nom] VARCHAR(50) NOT NULL,     
    [Nif] VARCHAR(9) NOT NULL, 
    [Direccio] VARCHAR(50) NOT NULL, 
    [CodiPostal] VARCHAR(6) NOT NULL, 
    [Ciutat] VARCHAR(50) NOT NULL, 
    [Provincia] VARCHAR(50) NOT NULL, 
    [Pais] VARCHAR(50) NOT NULL
)
