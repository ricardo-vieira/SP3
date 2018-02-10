CREATE TABLE [Cadastro].[Pessoa] (
    [ID]          BIGINT       IDENTITY (1, 1) ,
    [NOME]        VARCHAR (255),
    [OBSERVACAO]  TEXT         ,
    [DATACRIACAO] DATETIME     ,
    [STATUS]      TINYINT      DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
GO

CREATE TABLE [Cadastro].[Projeto] (
    [ID]                      BIGINT          IDENTITY (1, 1) ,
    [NOME]                    NVARCHAR (255),
    [DESCRICAO]               TEXT,
    [OBSERVACAO]              TEXT,
    [IDGERENTE]               BIGINT,
    [DATACRIACAO]             DATETIME,
    [INVESTIMENTOPREVISTO]    DECIMAL(18, 6),
    [RECEITACONSTANTE]        DECIMAL(18, 6),
    [RAZAORECEITAVALOR]       DECIMAL(18, 6),
    [RAZAORECEITAPERCENTUAL]  DECIMAL(18, 6),
    [TEMPOPREVISTOCONCLUSAODIAS]  BIGINT,
    [STATUS]                  TINYINT         DEFAULT ((1)) NULL,
    [CAPACIDADEENTREGAEQUIPE] INT             NULL,
    [APOIOALTAGESTAO]         INT             NULL,
    [APOIOSTEAKHOLDERS]       INT             NULL,
    [ESFORCOADICIONAL]        INT             NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([IDGERENTE]) REFERENCES [Cadastro].[PESSOA] ([ID])
);

GO



CREATE TABLE [Cadastro].[ProjetoPessoa] (
    [ID]           BIGINT       IDENTITY (1, 1) ,
    [IDPROJETO]    BIGINT       ,
    [IDPESSOA]     BIGINT       ,
    [DATAINGRESSO] DATE         ,
    [OCUPACAO]     VARCHAR (50) ,
    [OBSERVACOES]  TEXT         ,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([IDPESSOA]) REFERENCES [Cadastro].[PESSOA] ([ID]) ON DELETE SET NULL,
    FOREIGN KEY ([IDPROJETO]) REFERENCES [Cadastro].[PROJETO] ([ID]) ON DELETE SET NULL
);

