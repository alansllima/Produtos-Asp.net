CREATE TABLE [dbo].[Clientes] (
    [ClienteId]     INT            IDENTITY (1, 1) NOT NULL,
    [Nome]         NVARCHAR (MAX) NULL,
    [Sobrenome]    NVARCHAR (MAX) NULL,
    [Email]        NVARCHAR (MAX) NULL,
    [DataCadastro] DATETIME       NOT NULL,
    [Ativo]        BIT            NOT NULL,
    CONSTRAINT [PK_dbo.Clientes] PRIMARY KEY CLUSTERED ([ClienteId] ASC)
);

