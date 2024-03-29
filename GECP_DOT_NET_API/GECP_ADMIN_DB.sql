USE [master]
GO

/****** Object:  Database [GECP_ADMIN]    Script Date: 10/1/2022 10:38:11 AM ******/
CREATE DATABASE [GECP_ADMIN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GECP_ADMIN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GECP_ADMIN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GECP_ADMIN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GECP_ADMIN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GECP_ADMIN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [GECP_ADMIN] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET ARITHABORT OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [GECP_ADMIN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [GECP_ADMIN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET  DISABLE_BROKER 
GO

ALTER DATABASE [GECP_ADMIN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [GECP_ADMIN] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [GECP_ADMIN] SET  MULTI_USER 
GO

ALTER DATABASE [GECP_ADMIN] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [GECP_ADMIN] SET DB_CHAINING OFF 
GO

ALTER DATABASE [GECP_ADMIN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [GECP_ADMIN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [GECP_ADMIN] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [GECP_ADMIN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [GECP_ADMIN] SET QUERY_STORE = OFF
GO

ALTER DATABASE [GECP_ADMIN] SET  READ_WRITE 
GO


