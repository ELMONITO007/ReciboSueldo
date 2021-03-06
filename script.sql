USE [master]
GO
/****** Object:  Database [evalucionesTecnicas]    Script Date: 19/10/2020 16:24:04 ******/
CREATE DATABASE [evalucionesTecnicas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'evalucionesTecnicas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\evalucionesTecnicas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'evalucionesTecnicas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\evalucionesTecnicas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [evalucionesTecnicas] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [evalucionesTecnicas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [evalucionesTecnicas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET ARITHABORT OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [evalucionesTecnicas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [evalucionesTecnicas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [evalucionesTecnicas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [evalucionesTecnicas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [evalucionesTecnicas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [evalucionesTecnicas] SET  MULTI_USER 
GO
ALTER DATABASE [evalucionesTecnicas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [evalucionesTecnicas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [evalucionesTecnicas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [evalucionesTecnicas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [evalucionesTecnicas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [evalucionesTecnicas] SET QUERY_STORE = OFF
GO
USE [evalucionesTecnicas]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [evalucionesTecnicas]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[Activo] [bit] NULL,
	[DVH] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[ID_EventoBitacora] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[Fecha] [nvarchar](50) NOT NULL,
	[Hora] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [nvarchar](150) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[ID_Direccion] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[ID_Direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVV]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[ID_DVV] [int] IDENTITY(1,1) NOT NULL,
	[Tabla] [nvarchar](50) NOT NULL,
	[DVV] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[ID_DVV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[ID_Empresa] [int] IDENTITY(1,1) NOT NULL,
	[Empresa] [nvarchar](50) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[ID_Empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoBitacora](
	[ID_EventoBitacora] [int] IDENTITY(1,1) NOT NULL,
	[EventoBitacora] [nvarchar](150) NULL,
 CONSTRAINT [PK_EventoBitacora] PRIMARY KEY CLUSTERED 
(
	[ID_EventoBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[ID_Examen] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Estado] [nvarchar](50) NULL,
	[Resultado] [int] NULL,
	[Aprobado] [bit] NULL,
	[ID] [int] NULL,
	[Activo] [bit] NULL,
	[ID_Categoria] [int] NULL,
	[RespuestasCorrectas] [int] NULL,
	[RespuestasIncorrectas] [int] NULL,
 CONSTRAINT [PK_Examen] PRIMARY KEY CLUSTERED 
(
	[ID_Examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenPregunta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenPregunta](
	[ID_Pregunta] [int] NOT NULL,
	[ID_Examen] [int] NOT NULL,
	[Correcta] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenRespuestas]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenRespuestas](
	[Id_Examen] [int] NOT NULL,
	[Id_Pregunta] [int] NOT NULL,
	[Id_Respuesta] [int] NOT NULL,
	[Respondio] [bit] NOT NULL,
	[Correcta] [bit] NOT NULL,
	[Id_SubPregunta] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gerencia]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gerencia](
	[Id_Gerencia] [int] IDENTITY(1,1) NOT NULL,
	[Gerencia] [nvarchar](100) NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Gerencia] PRIMARY KEY CLUSTERED 
(
	[Id_Gerencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jefatura]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jefatura](
	[Id_Jefatura] [int] IDENTITY(1,1) NOT NULL,
	[Jefatura] [nvarchar](100) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Jefatura] PRIMARY KEY CLUSTERED 
(
	[Id_Jefatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelPregunta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelPregunta](
	[ID_Nivel] [int] IDENTITY(1,1) NOT NULL,
	[Nivel] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_NivelPregunta] PRIMARY KEY CLUSTERED 
(
	[ID_Nivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PDF]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDF](
	[Id] [int] NOT NULL,
	[path] [nvarchar](150) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pregunta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregunta](
	[ID_Pregunta] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [nvarchar](max) NOT NULL,
	[Imagen] [nvarchar](100) NULL,
	[ID_Nivel] [int] NOT NULL,
	[Activo] [bit] NULL,
	[ID_TipoPregunta] [int] NULL,
	[SubPregunta] [bit] NULL,
 CONSTRAINT [PK_Pregunta] PRIMARY KEY CLUSTERED 
(
	[ID_Pregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntaCategoria]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntaCategoria](
	[ID_Pregunta] [int] NOT NULL,
	[ID_Categoria] [int] NOT NULL,
 CONSTRAINT [PK_PreguntaCategoria] PRIMARY KEY CLUSTERED 
(
	[ID_Pregunta] ASC,
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntaSubPregunta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntaSubPregunta](
	[ID_Pregunta] [int] NOT NULL,
	[ID_SubPregunta] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuesta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuesta](
	[ID_Respuesta] [int] IDENTITY(1,1) NOT NULL,
	[Respuesta] [nvarchar](max) NULL,
	[Orden] [int] NULL,
	[Correcta] [bit] NULL,
	[ID_Pregunta] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Respuesta] PRIMARY KEY CLUSTERED 
(
	[ID_Respuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[Id_Sector] [int] IDENTITY(1,1) NOT NULL,
	[Sector] [nvarchar](100) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[Id_Sector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[Id_Sede] [int] IDENTITY(1,1) NOT NULL,
	[Sede] [nvarchar](50) NOT NULL,
	[Codigo] [nvarchar](50) NULL,
	[Empresa] [int] NOT NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Sede] PRIMARY KEY CLUSTERED 
(
	[Id_Sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubPregunta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubPregunta](
	[ID_Pregunta] [int] NULL,
	[ID_SubPregunta] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPregunta]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPregunta](
	[ID_TipoPregunta] [int] IDENTITY(1,1) NOT NULL,
	[TipoPregunta] [nvarchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_TipoPregunta] PRIMARY KEY CLUSTERED 
(
	[ID_TipoPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](max) NULL,
	[DVH] [nvarchar](max) NULL,
	[Activo] [bit] NULL,
	[Bloqueado] [bit] NULL,
	[CantidadIntentos] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioParaExamen]    Script Date: 19/10/2020 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioParaExamen](
	[Id] [int] NOT NULL,
	[Id_Sede] [int] NOT NULL,
	[Id_Direccion] [int] NOT NULL,
	[Id_Gerencia] [int] NOT NULL,
	[Id_Jefatura] [int] NOT NULL,
	[Id_Sector] [int] NOT NULL,
	[Activo] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 19/10/2020 16:24:04 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 19/10/2020 16:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 19/10/2020 16:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 19/10/2020 16:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserId]    Script Date: 19/10/2020 16:24:04 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 19/10/2020 16:24:04 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_Usuario1] FOREIGN KEY([UserId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_Usuario1]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_EventoBitacora] FOREIGN KEY([ID_EventoBitacora])
REFERENCES [dbo].[EventoBitacora] ([ID_EventoBitacora])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_EventoBitacora]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Categoria]
GO
ALTER TABLE [dbo].[ExamenPregunta]  WITH CHECK ADD  CONSTRAINT [FK_ExamenPregunta_Examen] FOREIGN KEY([ID_Examen])
REFERENCES [dbo].[Examen] ([ID_Examen])
GO
ALTER TABLE [dbo].[ExamenPregunta] CHECK CONSTRAINT [FK_ExamenPregunta_Examen]
GO
ALTER TABLE [dbo].[ExamenPregunta]  WITH CHECK ADD  CONSTRAINT [FK_ExamenPregunta_Pregunta] FOREIGN KEY([ID_Pregunta])
REFERENCES [dbo].[Pregunta] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[ExamenPregunta] CHECK CONSTRAINT [FK_ExamenPregunta_Pregunta]
GO
ALTER TABLE [dbo].[ExamenRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_ExamenRespuestas_Examen] FOREIGN KEY([Id_Examen])
REFERENCES [dbo].[Examen] ([ID_Examen])
GO
ALTER TABLE [dbo].[ExamenRespuestas] CHECK CONSTRAINT [FK_ExamenRespuestas_Examen]
GO
ALTER TABLE [dbo].[ExamenRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_ExamenRespuestas_Pregunta] FOREIGN KEY([Id_Pregunta])
REFERENCES [dbo].[Pregunta] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[ExamenRespuestas] CHECK CONSTRAINT [FK_ExamenRespuestas_Pregunta]
GO
ALTER TABLE [dbo].[PDF]  WITH CHECK ADD  CONSTRAINT [FK_PDF_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[PDF] CHECK CONSTRAINT [FK_PDF_Usuario]
GO
ALTER TABLE [dbo].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_NivelPregunta] FOREIGN KEY([ID_Nivel])
REFERENCES [dbo].[NivelPregunta] ([ID_Nivel])
GO
ALTER TABLE [dbo].[Pregunta] CHECK CONSTRAINT [FK_Pregunta_NivelPregunta]
GO
ALTER TABLE [dbo].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_TipoPregunta] FOREIGN KEY([ID_TipoPregunta])
REFERENCES [dbo].[TipoPregunta] ([ID_TipoPregunta])
GO
ALTER TABLE [dbo].[Pregunta] CHECK CONSTRAINT [FK_Pregunta_TipoPregunta]
GO
ALTER TABLE [dbo].[PreguntaCategoria]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaCategoria_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[PreguntaCategoria] CHECK CONSTRAINT [FK_PreguntaCategoria_Categoria]
GO
ALTER TABLE [dbo].[PreguntaCategoria]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaCategoria_Pregunta] FOREIGN KEY([ID_Pregunta])
REFERENCES [dbo].[Pregunta] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[PreguntaCategoria] CHECK CONSTRAINT [FK_PreguntaCategoria_Pregunta]
GO
ALTER TABLE [dbo].[Respuesta]  WITH CHECK ADD  CONSTRAINT [FK_Respuesta_Pregunta] FOREIGN KEY([ID_Pregunta])
REFERENCES [dbo].[Pregunta] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[Respuesta] CHECK CONSTRAINT [FK_Respuesta_Pregunta]
GO
ALTER TABLE [dbo].[Sede]  WITH CHECK ADD  CONSTRAINT [FK_Sede_Empresa] FOREIGN KEY([Empresa])
REFERENCES [dbo].[Empresa] ([ID_Empresa])
GO
ALTER TABLE [dbo].[Sede] CHECK CONSTRAINT [FK_Sede_Empresa]
GO
ALTER TABLE [dbo].[SubPregunta]  WITH CHECK ADD  CONSTRAINT [FK_SubPregunta_Pregunta] FOREIGN KEY([ID_Pregunta])
REFERENCES [dbo].[Pregunta] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[SubPregunta] CHECK CONSTRAINT [FK_SubPregunta_Pregunta]
GO
ALTER TABLE [dbo].[SubPregunta]  WITH CHECK ADD  CONSTRAINT [FK_SubPregunta_Pregunta1] FOREIGN KEY([ID_SubPregunta])
REFERENCES [dbo].[Pregunta] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[SubPregunta] CHECK CONSTRAINT [FK_SubPregunta_Pregunta1]
GO
ALTER TABLE [dbo].[UsuarioParaExamen]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioParaExamen_Direccion] FOREIGN KEY([Id_Direccion])
REFERENCES [dbo].[Direccion] ([ID_Direccion])
GO
ALTER TABLE [dbo].[UsuarioParaExamen] CHECK CONSTRAINT [FK_UsuarioParaExamen_Direccion]
GO
ALTER TABLE [dbo].[UsuarioParaExamen]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioParaExamen_Gerencia] FOREIGN KEY([Id_Gerencia])
REFERENCES [dbo].[Gerencia] ([Id_Gerencia])
GO
ALTER TABLE [dbo].[UsuarioParaExamen] CHECK CONSTRAINT [FK_UsuarioParaExamen_Gerencia]
GO
ALTER TABLE [dbo].[UsuarioParaExamen]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioParaExamen_Jefatura] FOREIGN KEY([Id_Jefatura])
REFERENCES [dbo].[Jefatura] ([Id_Jefatura])
GO
ALTER TABLE [dbo].[UsuarioParaExamen] CHECK CONSTRAINT [FK_UsuarioParaExamen_Jefatura]
GO
ALTER TABLE [dbo].[UsuarioParaExamen]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioParaExamen_Sector] FOREIGN KEY([Id_Sector])
REFERENCES [dbo].[Sector] ([Id_Sector])
GO
ALTER TABLE [dbo].[UsuarioParaExamen] CHECK CONSTRAINT [FK_UsuarioParaExamen_Sector]
GO
ALTER TABLE [dbo].[UsuarioParaExamen]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioParaExamen_Sede] FOREIGN KEY([Id_Sede])
REFERENCES [dbo].[Sede] ([Id_Sede])
GO
ALTER TABLE [dbo].[UsuarioParaExamen] CHECK CONSTRAINT [FK_UsuarioParaExamen_Sede]
GO
ALTER TABLE [dbo].[UsuarioParaExamen]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioParaExamen_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioParaExamen] CHECK CONSTRAINT [FK_UsuarioParaExamen_Usuario]
GO
USE [master]
GO
ALTER DATABASE [evalucionesTecnicas] SET  READ_WRITE 
GO
