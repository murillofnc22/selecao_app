if not exists (select name from sys.databases where name = 'SelecaoDB')
begin
	create database SelecaoDB
end
go

use SelecaoDB
go

if not exists (select name from sys.tables where name = 'Login')
begin	
	SET ANSI_NULLS ON
	SET QUOTED_IDENTIFIER ON
	CREATE TABLE [dbo].[Login](
		[id] [int] IDENTITY(1,1) NOT NULL,
		[usuario] [varchar](50) NOT NULL,
		[usrpass] [varchar](255) NOT NULL,
	 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
end

if not exists (select name from sys.tables where name = 'Fornecedores')
begin
	SET ANSI_NULLS ON
	SET QUOTED_IDENTIFIER ON

	CREATE TABLE [dbo].[Fornecedores](
		[id] [int] IDENTITY(1,1) NOT NULL,
		[nome] [varchar](255) NOT NULL,
		[cnpj] [varchar](18) NOT NULL,
		[endereco] [varchar](255) NULL,
		[ativo] [bit] NOT NULL,
	 CONSTRAINT [PK_Fornecedores_1] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[Fornecedores] ADD  CONSTRAINT [DF_Fornecedores_ativo]  DEFAULT ((0)) FOR [ativo]
end

if not exists (select name from sys.tables where name = 'Produtos')
begin
	SET ANSI_NULLS ON
	SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Produtos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NOT NULL,
	[idFornecedor] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[Produtos] ADD  CONSTRAINT [DF_Produtos_quantidade]  DEFAULT ((0)) FOR [quantidade]
end
