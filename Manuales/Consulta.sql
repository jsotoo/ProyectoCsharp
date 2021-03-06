USE [ElectivV]
GO
/****** Object:  Table [dbo].[TbModuloParticipante]    Script Date: 04/09/2016 0:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TbModuloParticipante](
	[CodigoParticipante] [varchar](7) NOT NULL,
	[DocumentoCoordinado] [int] NULL,
	[DocumentoGestor] [int] NULL,
	[NumModulo] [int] NOT NULL,
	[FechaVisita] [date] NULL,
	[HoraInicial] [time](7) NULL,
	[HoraFinal] [time](7) NULL,
 CONSTRAINT [PK_TbModuloParticipante] PRIMARY KEY CLUSTERED 
(
	[CodigoParticipante] ASC,
	[NumModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TbModulos]    Script Date: 04/09/2016 0:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbModulos](
	[NumModulo] [int] IDENTITY(1,1) NOT NULL,
	[NomModulo] [text] NULL,
 CONSTRAINT [PK_TbModulos] PRIMARY KEY CLUSTERED 
(
	[NumModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TbParticipantes]    Script Date: 04/09/2016 0:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TbParticipantes](
	[CodigoParticipante] [varchar](7) NOT NULL,
	[Estado] [varchar](8) NULL,
	[PrimerApellido] [varchar](20) NULL,
	[SegundoApellido] [varchar](20) NULL,
	[PrimerNombre] [varchar](20) NULL,
	[SegundNombre] [varchar](20) NULL,
 CONSTRAINT [PK_TbParticipantes] PRIMARY KEY CLUSTERED 
(
	[CodigoParticipante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TbProductos]    Script Date: 04/09/2016 0:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbProductos](
	[CodProducto] [int] NOT NULL,
	[DesProducto] [nvarchar](50) NULL,
	[CatProducto] [int] NULL,
	[CantProducto] [int] NULL,
	[PreUnidad] [money] NULL,
 CONSTRAINT [PK_TbProductos] PRIMARY KEY CLUSTERED 
(
	[CodProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TbUsuario]    Script Date: 04/09/2016 0:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TbUsuario](
	[UsuDocumento] [int] NOT NULL,
	[UsuNombres] [varchar](50) NULL,
	[UsuApellidos] [varchar](50) NULL,
	[UsoCorreo] [varchar](120) NULL,
	[UsuPerfil] [varchar](20) NULL,
	[UsuLogin] [varchar](30) NULL,
	[UsuPassword] [varchar](20) NULL,
	[UsuEstado] [varchar](15) NULL,
 CONSTRAINT [PK_TbUsuarios] PRIMARY KEY CLUSTERED 
(
	[UsuDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TbUsuarios]    Script Date: 04/09/2016 0:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TbUsuarios](
	[NumeroDocumento] [int] NOT NULL,
	[Nombres] [varchar](150) NULL,
 CONSTRAINT [PK_TbUsuarios_1] PRIMARY KEY CLUSTERED 
(
	[NumeroDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
