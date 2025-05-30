USE [master]
GO
/****** Object:  Database [ecofarm]    Script Date: 28/05/2025 18:07:31 ******/
CREATE DATABASE [ecofarm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ecofarm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ecofarm.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ecofarm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ecofarm_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ecofarm] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ecofarm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ecofarm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ecofarm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ecofarm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ecofarm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ecofarm] SET ARITHABORT OFF 
GO
ALTER DATABASE [ecofarm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ecofarm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ecofarm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ecofarm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ecofarm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ecofarm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ecofarm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ecofarm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ecofarm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ecofarm] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ecofarm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ecofarm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ecofarm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ecofarm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ecofarm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ecofarm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ecofarm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ecofarm] SET RECOVERY FULL 
GO
ALTER DATABASE [ecofarm] SET  MULTI_USER 
GO
ALTER DATABASE [ecofarm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ecofarm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ecofarm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ecofarm] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ecofarm] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ecofarm] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ecofarm', N'ON'
GO
ALTER DATABASE [ecofarm] SET QUERY_STORE = ON
GO
ALTER DATABASE [ecofarm] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ecofarm]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 28/05/2025 18:07:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[NomeCliente] [varchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[CNPJ] [varchar](18) NULL,
	[IdClientes] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdClientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estoque]    Script Date: 28/05/2025 18:07:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estoque](
	[NomeProduto] [varchar](100) NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
	[PreçoFinal] [decimal](10, 2) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Unidade] [varchar](50) NOT NULL,
	[Observacoes] [varchar](max) NULL,
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Estoque] PRIMARY KEY CLUSTERED 
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 28/05/2025 18:07:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[IdFuncionario] [int] NOT NULL,
	[NomeFuncionario] [varchar](100) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 28/05/2025 18:07:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[IdVenda] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[DataVenda] [date] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ecofarm] SET  READ_WRITE 
GO
