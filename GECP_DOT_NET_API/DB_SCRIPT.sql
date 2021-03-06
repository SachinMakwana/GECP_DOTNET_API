USE [master]
GO
/****** Object:  Database [GECP_ADMIN]    Script Date: 7/16/2022 4:21:52 PM ******/
CREATE DATABASE [GECP_ADMIN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GECP_ADMIN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GECP_ADMIN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GECP_ADMIN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GECP_ADMIN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GECP_ADMIN] SET COMPATIBILITY_LEVEL = 150
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
USE [GECP_ADMIN]
GO
/****** Object:  Table [dbo].[Achievement]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Achievement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
	[Tag] [nvarchar](50) NOT NULL,
	[Date] [datetime] NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDataInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Affiliation]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Affiliation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Attachements] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BackendMenu]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackendMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ViewName] [nvarchar](50) NOT NULL,
	[ControllerName] [nvarchar](50) NOT NULL,
	[VerticalLevel] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Circular]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Circular](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[College]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[College](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Principal] [nvarchar](max) NOT NULL,
	[PrincipalMessage] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Committee]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Committee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Slogan] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommitteeMember]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommitteeMember](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[RelevantDepartments] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Logo] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Head] [int] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Slogan] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmentAmenty]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentAmenty](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Intake] [int] NOT NULL,
	[Subjects] [int] NOT NULL,
	[Labs] [int] NOT NULL,
	[Workshop] [int] NOT NULL,
	[Classroom] [int] NOT NULL,
	[Seminar] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Designation]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Class] [nvarchar](max) NOT NULL,
	[Payband] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DynamicPage]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DynamicPage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationDetail]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BoardCollege] [nvarchar](max) NOT NULL,
	[Passout] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExternalFacultyDetail]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExternalFacultyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacultyDetail]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacultyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DeptId] [int] NOT NULL,
	[DesignationId] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrontendMenu]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FrontendMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ViewName] [nvarchar](50) NOT NULL,
	[ControllerName] [nvarchar](50) NOT NULL,
	[VerticalLevel] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gallery]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gallery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GalleryTabId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Extension] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GalleryTag]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GalleryTag](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralLog]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Event] [nvarchar](max) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[Ipaddress] [nvarchar](50) NOT NULL,
	[Device] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabWorkshopDetail]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabWorkshopDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediaLink]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediaLink](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Link] [nvarchar](max) NOT NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuItem]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NOT NULL,
	[ParentId] [int] NOT NULL,
	[Degree] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MicroLog]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MicroLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Event] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MiniLog]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MiniLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Event] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mission]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParentItem]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParentItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Placement]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Placement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](max) NOT NULL,
	[StudentPic] [nvarchar](max) NOT NULL,
	[DeptId] [int] NOT NULL,
	[AnnualPackage] [float] NOT NULL,
	[MonthlyPackage] [float] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[PlacementDate] [datetime] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Portfolio]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Portfolio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Level] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publication]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publication](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Link] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SsipProject]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SsipProject](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[DeptId] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tender]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vision]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vision](
	[Id] [int] NOT NULL,
	[DeptId] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkExperience]    Script Date: 7/16/2022 4:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkExperience](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Organization] [nvarchar](max) NOT NULL,
	[FromDate] [datetime] NULL,
	[FromDateInt]  AS (format([FromDate],'yyyyMMddHHmmssffff')),
	[ToDate] [datetime] NULL,
	[ToDateInt]  AS (format([ToDate],'yyyyMMddHHmmssffff')),
	[Designation] [nvarchar](50) NOT NULL,
	[Expertise] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff'))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [GECP_ADMIN] SET  READ_WRITE 
GO
