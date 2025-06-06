CREATE TABLE [dbo].[Profissionals] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Nome] NVARCHAR (100) NOT NULL,
    [Telefone] NVARCHAR (20) NULL,
    [RG] NVARCHAR (20) NULL,
    [Endereco] NVARCHAR (200) NULL,
    [Salario] DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);