USE [master]
GO

/****** Object:  Database [SelecaoDB]    Script Date: 13/10/2020 11:55:37 ******/
CREATE DATABASE [SelecaoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SelecaoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SelecaoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SelecaoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SelecaoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SelecaoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SelecaoDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SelecaoDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SelecaoDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SelecaoDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SelecaoDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [SelecaoDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [SelecaoDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SelecaoDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SelecaoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SelecaoDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SelecaoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SelecaoDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SelecaoDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SelecaoDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SelecaoDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [SelecaoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SelecaoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SelecaoDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SelecaoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SelecaoDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SelecaoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SelecaoDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SelecaoDB] SET RECOVERY FULL 
GO

ALTER DATABASE [SelecaoDB] SET  MULTI_USER 
GO

ALTER DATABASE [SelecaoDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SelecaoDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SelecaoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SelecaoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [SelecaoDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SelecaoDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [SelecaoDB] SET  READ_WRITE 
GO

