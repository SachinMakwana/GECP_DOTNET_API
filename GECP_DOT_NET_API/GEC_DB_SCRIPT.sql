USE [master]
GO
/****** Object:  Database [GECP_ADMIN]    Script Date: 8/25/2022 10:18:03 PM ******/
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
/****** Object:  Table [dbo].[Achievements]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Achievements](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Tag] [nvarchar](50) NOT NULL,
	[Date] [datetime] NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Achievements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Affiliation]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Affiliation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Attachements] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Affiliation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attachments]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attachments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Attachment] [nvarchar](50) NOT NULL,
	[PageId] [int] NOT NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Attachments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BackendMenu]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_BackendMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Circular]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Circular] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[College]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[College](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Principal] [nvarchar](max) NOT NULL,
	[PrincipalMessage] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_College] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Committee]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Committee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Slogan] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Committee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommitteeMembers]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommitteeMembers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[CommitteeID] [int] NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_CommitteeMembers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[RelevantDepartments] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
	[Logo] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[Slogan] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmentAmenties]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentAmenties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Intake] [int] NOT NULL,
	[Subjects] [int] NOT NULL,
	[Labs] [int] NOT NULL,
	[Workshop] [int] NOT NULL,
	[Classroom] [int] NOT NULL,
	[Seminar] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_DepartmentAmenties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Designations]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[Payband] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Designations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DynamicPage]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_DynamicPage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationalDetails]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationalDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BoardCollege] [nvarchar](50) NOT NULL,
	[Passout] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_EducationalDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExternalFacultyDetail]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExternalFacultyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_ExternalFacultyDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacultyDetail]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacultyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeptId] [int] NOT NULL,
	[DesignationId] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_FacultyDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FrontendMenu]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_FrontendMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gallery]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gallery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GalleryTagId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Extension] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Gallery] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GalleryTag]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GalleryTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_GalleryTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralLog]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Event] [nvarchar](50) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[IPAddress] [nvarchar](50) NOT NULL,
	[Device] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_GeneralLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grievance]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grievance](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[EmailID] [nvarchar](50) NOT NULL,
	[Mobile] [nvarchar](20) NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Attachments] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Grievance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrievanceStatus]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrievanceStatus](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[GrievanceID] [bigint] NOT NULL,
	[Status] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([UpdatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_GrievanceStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabWorkshopDetails]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabWorkshopDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_LabWorkshopDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediaLinks]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediaLinks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Link] [nvarchar](50) NOT NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_MediaLinks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NOT NULL,
	[ParentId] [int] NOT NULL,
	[Degree] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MicroLog]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MicroLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Event] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_MicroLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MiniLog]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MiniLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Event] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_MiniLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mission]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Mission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_News_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParentItems]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParentItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[IsVisible] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_ParentItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Placement]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Placement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[StudentPic] [nvarchar](max) NOT NULL,
	[DeptId] [int] NOT NULL,
	[AnnualPackage] [bigint] NOT NULL,
	[MonthlyPackage] [bigint] NOT NULL,
	[CompanyID] [int] NOT NULL,
	[PlacementDate] [datetime] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Placement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Portfolios]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Portfolios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Level] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Portfolios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publications]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Link] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Publications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 8/25/2022 10:18:03 PM ******/
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
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SsipProjects]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SsipProjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[DeptId] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_SsipProjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tenders]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tenders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Tenders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vision]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vision](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeptId] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_Vision] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkExperience]    Script Date: 8/25/2022 10:18:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkExperience](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacultyId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Organization] [nvarchar](50) NOT NULL,
	[FromDate] [datetime] NULL,
	[FromDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[ToDate] [datetime] NULL,
	[ToDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[Designation] [nvarchar](50) NOT NULL,
	[Expertise] [nvarchar](50) NOT NULL,
	[IsDeleted] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
	[UpdatedDate] [datetime] NULL,
	[UpdatedDateInt]  AS (format([CreatedDate],'yyyyMMddHHmmssffff')),
 CONSTRAINT [PK_WorkExperience] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [GECP_ADMIN] SET  READ_WRITE 
GO
