USE [master]
GO
/****** Object:  Database [ibrn]    Script Date: 15/12/2014 07:21:28 ******/
CREATE DATABASE [ibrn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ibrn', FILENAME = N'f:\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ibrn.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ibrn_log', FILENAME = N'f:\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ibrn_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ibrn] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ibrn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ibrn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ibrn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ibrn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ibrn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ibrn] SET ARITHABORT OFF 
GO
ALTER DATABASE [ibrn] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ibrn] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ibrn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ibrn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ibrn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ibrn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ibrn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ibrn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ibrn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ibrn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ibrn] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ibrn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ibrn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ibrn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ibrn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ibrn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ibrn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ibrn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ibrn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ibrn] SET  MULTI_USER 
GO
ALTER DATABASE [ibrn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ibrn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ibrn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ibrn] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ibrn]
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaExcluir]    Script Date: 15/12/2014 07:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPessoaExcluir]

	@IDPessoa int

AS
BEGIN

	UPDATE  tblPessoa SET Stat = 3	WHERE IDPessoa = @IDPessoa
	
	SELECT @IDPessoa AS Retorno
END

GO
/****** Object:  StoredProcedure [dbo].[uspPessoaInserir]    Script Date: 15/12/2014 07:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPessoaInserir]
(
	@Nome varchar(50),
	@Endereco varchar(100),
	@CEP varchar(9),
	@Bairro varchar(50),
	@Cidade varchar(50),
	@Estado varchar(2),
	@Telefone varchar(14),
	@Celular varchar(15),
	@Email varchar(50),
	@Nascimento date
)
AS
BEGIN
    BEGIN TRY
	  BEGIN TRAN
		 INSERT INTO tblPessoa
			(
 				nome,
				Endereco,
				CEP,
				Bairro,
				Cidade,
				Estado,
				Telefone,
				Celular,
				Email,
				Nascimento

			)
			  VALUES
			(
				@Nome,
				@Endereco,
				@CEP,
				@Bairro,
				@Cidade,
				@Estado,
				@Telefone,
				@Celular,
				@Email,
				@Nascimento
			)
		
			SELECT @@IDENTITY AS Retorno
		    
		    COMMIT TRAN
		END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno; 
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[uspPessoalConsultarPorNome]    Script Date: 15/12/2014 07:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPessoalConsultarPorNome]
	@Nome varchar(100)
	
AS
BEGIN
	SELECT
	  *
	FROM
		tblPessoa as pes
	
	WHERE
		pes.Nome LIKE '%' + @Nome + '%' AND pes.Stat = 1 OR pes.Stat = 2
    ORDER BY Nome
	
END
GO
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 15/12/2014 07:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoa](
	[IDPessoa] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[CEP] [varchar](9) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Estado] [varchar](2) NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
	[Celular] [varchar](15) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Nascimento] [date] NOT NULL,
	[Stat] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblStat]    Script Date: 15/12/2014 07:21:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStat](
	[IDStat] [int] NOT NULL,
	[Stat] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [ibrn] SET  READ_WRITE 
GO
