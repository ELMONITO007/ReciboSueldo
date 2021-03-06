USE [master]
GO
/****** Object:  Database [ReciboSueldo]    Script Date: 22/9/2020 17:30:51 ******/
CREATE DATABASE [ReciboSueldo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReciboSueldo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ReciboSueldo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReciboSueldo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ReciboSueldo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ReciboSueldo] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReciboSueldo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReciboSueldo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ReciboSueldo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ReciboSueldo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ReciboSueldo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ReciboSueldo] SET ARITHABORT OFF 
GO
ALTER DATABASE [ReciboSueldo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ReciboSueldo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReciboSueldo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReciboSueldo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReciboSueldo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ReciboSueldo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ReciboSueldo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReciboSueldo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ReciboSueldo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReciboSueldo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ReciboSueldo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReciboSueldo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReciboSueldo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReciboSueldo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReciboSueldo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReciboSueldo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReciboSueldo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReciboSueldo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ReciboSueldo] SET  MULTI_USER 
GO
ALTER DATABASE [ReciboSueldo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReciboSueldo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReciboSueldo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReciboSueldo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReciboSueldo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReciboSueldo] SET QUERY_STORE = OFF
GO
USE [ReciboSueldo]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ReciboSueldo]
GO
/****** Object:  Table [dbo].[AporteJubilatorio]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AporteJubilatorio](
	[ID_AporteJubilatorio] [int] NOT NULL,
	[Periodo] [nvarchar](50) NULL,
	[Fecha] [date] NULL,
	[Banco] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_AporteJubilatorio] PRIMARY KEY CLUSTERED 
(
	[ID_AporteJubilatorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[ID_Departamento] [int] IDENTITY(1,1) NOT NULL,
	[Departamento] [nvarchar](50) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[ID_Departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Division]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Division](
	[ID_Division] [int] IDENTITY(1,1) NOT NULL,
	[Division] [nvarchar](50) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Division] PRIMARY KEY CLUSTERED 
(
	[ID_Division] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[CUIL] [nvarchar](50) NOT NULL,
	[Banco] [nvarchar](50) NULL,
	[Cuenta] [nvarchar](50) NULL,
	[ID_Empresa] [int] NULL,
	[ID_Categoria] [int] NULL,
	[ID_Departamento] [int] NULL,
	[ID_Division] [int] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[ID_Emprea] [int] IDENTITY(1,1) NOT NULL,
	[Empresa] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NULL,
	[CUIT] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[ID_Emprea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID_Item] [int] IDENTITY(1,1) NOT NULL,
	[Item] [nvarchar](50) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Porcentaje] [int] NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ID_Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LegajoAporteJubilatorio]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegajoAporteJubilatorio](
	[ID_AporteJubilatorio] [int] NOT NULL,
	[Legajo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LegajoItem]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegajoItem](
	[ID_ReciboSueldo] [int] NULL,
	[ID_Item] [int] NULL,
	[Valor] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReciboSueldo]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReciboSueldo](
	[ID_ReciboSueldo] [int] IDENTITY(1,1) NOT NULL,
	[Liquidacion] [nvarchar](50) NOT NULL,
	[Mes] [int] NOT NULL,
	[Año] [int] NOT NULL,
	[Sueldo] [int] NOT NULL,
	[Lugar] [nvarchar](50) NOT NULL,
	[FechaPago] [date] NOT NULL,
	[TotalRetencion] [int] NULL,
	[TotalExentas] [int] NULL,
	[TotalDeducciones] [int] NULL,
	[TotalNeto] [int] NULL,
	[Legajo] [int] NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_ReciboSueldo] PRIMARY KEY CLUSTERED 
(
	[ID_ReciboSueldo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoItem]    Script Date: 22/9/2020 17:30:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoItem](
	[ID_TipoItem] [int] IDENTITY(1,1) NOT NULL,
	[TipoItem] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_TipoItem] PRIMARY KEY CLUSTERED 
(
	[ID_TipoItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria], [Activo]) VALUES (1, N'A', 1)
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria], [Activo]) VALUES (2, N'B', 1)
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Departamento] ON 

INSERT [dbo].[Departamento] ([ID_Departamento], [Departamento], [Activo]) VALUES (1, N'Sistemas', 1)
INSERT [dbo].[Departamento] ([ID_Departamento], [Departamento], [Activo]) VALUES (2, N'Compras', 1)
SET IDENTITY_INSERT [dbo].[Departamento] OFF
GO
SET IDENTITY_INSERT [dbo].[Division] ON 

INSERT [dbo].[Division] ([ID_Division], [Division], [Activo]) VALUES (1, N'Miami', 1)
INSERT [dbo].[Division] ([ID_Division], [Division], [Activo]) VALUES (2, N'BS AS', 1)
SET IDENTITY_INSERT [dbo].[Division] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Legajo], [Nombre], [Apellido], [FechaIngreso], [CUIL], [Banco], [Cuenta], [ID_Empresa], [ID_Categoria], [ID_Departamento], [ID_Division], [Activo]) VALUES (1, N'Juan', N'Perez', CAST(N'2010-12-10T00:00:00.000' AS DateTime), N'12307778889', N'ICBC', N'12345678910', 1, 1, 1, 1, 1)
INSERT [dbo].[Empleado] ([Legajo], [Nombre], [Apellido], [FechaIngreso], [CUIL], [Banco], [Cuenta], [ID_Empresa], [ID_Categoria], [ID_Departamento], [ID_Division], [Activo]) VALUES (2, N'Andres', N'Benitez', CAST(N'2020-09-01T00:00:00.000' AS DateTime), N'23309637089', N'ICBC', N'12345678911', 1, 1, 1, 1, 1)
INSERT [dbo].[Empleado] ([Legajo], [Nombre], [Apellido], [FechaIngreso], [CUIL], [Banco], [Cuenta], [ID_Empresa], [ID_Categoria], [ID_Departamento], [ID_Division], [Activo]) VALUES (3, N'Andres', N'aaa', CAST(N'2020-09-02T00:00:00.000' AS DateTime), N'23309637088', N'Santander', N'12345678912', 1, 1, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([ID_Emprea], [Empresa], [Direccion], [CUIT], [Activo]) VALUES (1, N'Perez SA', N'Josed 123', N'12345678944', 1)
SET IDENTITY_INSERT [dbo].[Empresa] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (1, N'Sueldo', 2, 0, 1)
INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (2, N'Test', 2, 41, 0)
INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (1002, N'Jubilacion', 4, 11, 1)
INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (1003, N'Ley 19032', 4, 3, 1)
INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (1004, N'Sindicato', 4, 3, 1)
INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (1005, N'Sac', 3, 50, 1)
INSERT [dbo].[Item] ([ID_Item], [Item], [Tipo], [Porcentaje], [Activo]) VALUES (1006, N'Antiguedad', 3, 5, 1)
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
INSERT [dbo].[LegajoItem] ([ID_ReciboSueldo], [ID_Item], [Valor]) VALUES (1, 1, 18000)
INSERT [dbo].[LegajoItem] ([ID_ReciboSueldo], [ID_Item], [Valor]) VALUES (1, 1002, 1980)
INSERT [dbo].[LegajoItem] ([ID_ReciboSueldo], [ID_Item], [Valor]) VALUES (1, 1003, 540)
INSERT [dbo].[LegajoItem] ([ID_ReciboSueldo], [ID_Item], [Valor]) VALUES (1, 1006, 900)
GO
SET IDENTITY_INSERT [dbo].[ReciboSueldo] ON 

INSERT [dbo].[ReciboSueldo] ([ID_ReciboSueldo], [Liquidacion], [Mes], [Año], [Sueldo], [Lugar], [FechaPago], [TotalRetencion], [TotalExentas], [TotalDeducciones], [TotalNeto], [Legajo], [activo]) VALUES (1, N'Mensual', 10, 20, 18000, N'Buenos Aires', CAST(N'2020-09-01' AS Date), NULL, NULL, NULL, NULL, 1, 1)
INSERT [dbo].[ReciboSueldo] ([ID_ReciboSueldo], [Liquidacion], [Mes], [Año], [Sueldo], [Lugar], [FechaPago], [TotalRetencion], [TotalExentas], [TotalDeducciones], [TotalNeto], [Legajo], [activo]) VALUES (2, N'Mensual', 9, 2020, 18000, N'Buenos Aires', CAST(N'2020-08-01' AS Date), NULL, NULL, NULL, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[ReciboSueldo] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoItem] ON 

INSERT [dbo].[TipoItem] ([ID_TipoItem], [TipoItem], [Activo]) VALUES (2, N'Retencion', 1)
INSERT [dbo].[TipoItem] ([ID_TipoItem], [TipoItem], [Activo]) VALUES (3, N'Exentas', 1)
INSERT [dbo].[TipoItem] ([ID_TipoItem], [TipoItem], [Activo]) VALUES (4, N'Deducciones', 1)
SET IDENTITY_INSERT [dbo].[TipoItem] OFF
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Categoria]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Departamento] FOREIGN KEY([ID_Departamento])
REFERENCES [dbo].[Departamento] ([ID_Departamento])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Departamento]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Division] FOREIGN KEY([ID_Division])
REFERENCES [dbo].[Division] ([ID_Division])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Division]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Empresa] FOREIGN KEY([ID_Empresa])
REFERENCES [dbo].[Empresa] ([ID_Emprea])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Empresa]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_TipoItem] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoItem] ([ID_TipoItem])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_TipoItem]
GO
ALTER TABLE [dbo].[LegajoAporteJubilatorio]  WITH CHECK ADD  CONSTRAINT [FK_LegajoAporteJubilatorio_AporteJubilatorio] FOREIGN KEY([Legajo])
REFERENCES [dbo].[AporteJubilatorio] ([ID_AporteJubilatorio])
GO
ALTER TABLE [dbo].[LegajoAporteJubilatorio] CHECK CONSTRAINT [FK_LegajoAporteJubilatorio_AporteJubilatorio]
GO
ALTER TABLE [dbo].[LegajoAporteJubilatorio]  WITH CHECK ADD  CONSTRAINT [FK_LegajoAporteJubilatorio_Empleado] FOREIGN KEY([ID_AporteJubilatorio])
REFERENCES [dbo].[Empleado] ([Legajo])
GO
ALTER TABLE [dbo].[LegajoAporteJubilatorio] CHECK CONSTRAINT [FK_LegajoAporteJubilatorio_Empleado]
GO
ALTER TABLE [dbo].[LegajoItem]  WITH CHECK ADD  CONSTRAINT [FK_LegajoItem_Item] FOREIGN KEY([ID_Item])
REFERENCES [dbo].[Item] ([ID_Item])
GO
ALTER TABLE [dbo].[LegajoItem] CHECK CONSTRAINT [FK_LegajoItem_Item]
GO
ALTER TABLE [dbo].[LegajoItem]  WITH CHECK ADD  CONSTRAINT [FK_LegajoItem_ReciboSueldo] FOREIGN KEY([ID_ReciboSueldo])
REFERENCES [dbo].[ReciboSueldo] ([ID_ReciboSueldo])
GO
ALTER TABLE [dbo].[LegajoItem] CHECK CONSTRAINT [FK_LegajoItem_ReciboSueldo]
GO
ALTER TABLE [dbo].[ReciboSueldo]  WITH CHECK ADD  CONSTRAINT [FK_ReciboSueldo_Empleado] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Empleado] ([Legajo])
GO
ALTER TABLE [dbo].[ReciboSueldo] CHECK CONSTRAINT [FK_ReciboSueldo_Empleado]
GO
USE [master]
GO
ALTER DATABASE [ReciboSueldo] SET  READ_WRITE 
GO
