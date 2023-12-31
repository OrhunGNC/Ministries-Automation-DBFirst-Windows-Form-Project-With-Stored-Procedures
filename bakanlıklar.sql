USE [master]
GO
/****** Object:  Database [Bakanlıklar]    Script Date: 20.08.2023 14:39:06 ******/
CREATE DATABASE [Bakanlıklar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bakanlıklar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Bakanlıklar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bakanlıklar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Bakanlıklar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Bakanlıklar] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bakanlıklar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bakanlıklar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bakanlıklar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bakanlıklar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bakanlıklar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bakanlıklar] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bakanlıklar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bakanlıklar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bakanlıklar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bakanlıklar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bakanlıklar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bakanlıklar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bakanlıklar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bakanlıklar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bakanlıklar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bakanlıklar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bakanlıklar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bakanlıklar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bakanlıklar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bakanlıklar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bakanlıklar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bakanlıklar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bakanlıklar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bakanlıklar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bakanlıklar] SET  MULTI_USER 
GO
ALTER DATABASE [Bakanlıklar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bakanlıklar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bakanlıklar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bakanlıklar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bakanlıklar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bakanlıklar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bakanlıklar] SET QUERY_STORE = ON
GO
ALTER DATABASE [Bakanlıklar] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Bakanlıklar]
GO
/****** Object:  Table [dbo].[Bakanlık]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bakanlık](
	[bakanlıkID] [int] IDENTITY(1,1) NOT NULL,
	[bakanlıkAdi] [varchar](50) NULL,
	[daireBaskanlik] [varchar](50) NULL,
	[Ciro] [money] NULL,
	[Merkez] [varchar](50) NULL,
 CONSTRAINT [PK_Bakanlık] PRIMARY KEY CLUSTERED 
(
	[bakanlıkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vatandas]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vatandas](
	[vatandasID] [int] IDENTITY(1,1) NOT NULL,
	[TCNo] [varchar](11) NULL,
	[Meslek] [varchar](50) NULL,
	[Adres] [varchar](50) NULL,
	[telefon] [varchar](11) NULL,
	[mail] [varchar](50) NULL,
 CONSTRAINT [PK_Vatandas] PRIMARY KEY CLUSTERED 
(
	[vatandasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vergiler]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vergiler](
	[vergiID] [int] IDENTITY(1,1) NOT NULL,
	[vergiAdi] [varchar](50) NULL,
	[vergiTipi] [varchar](50) NULL,
	[Tutar] [money] NULL,
	[faiz] [varchar](50) NULL,
	[bakanlıkID] [int] NULL,
	[vatandasID] [int] NULL,
 CONSTRAINT [PK_Vergiler] PRIMARY KEY CLUSTERED 
(
	[vergiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bakanlık] ON 

INSERT [dbo].[Bakanlık] ([bakanlıkID], [bakanlıkAdi], [daireBaskanlik], [Ciro], [Merkez]) VALUES (1, N'asdfjk', N'fdsakg', 34939.0000, N'Istanbul')
SET IDENTITY_INSERT [dbo].[Bakanlık] OFF
GO
SET IDENTITY_INSERT [dbo].[Vatandas] ON 

INSERT [dbo].[Vatandas] ([vatandasID], [TCNo], [Meslek], [Adres], [telefon], [mail]) VALUES (1, N'314531513', N'yazilim mühendisi', N'istanbul', N'0534352', N'sadfass@gmail.com')
SET IDENTITY_INSERT [dbo].[Vatandas] OFF
GO
SET IDENTITY_INSERT [dbo].[Vergiler] ON 

INSERT [dbo].[Vergiler] ([vergiID], [vergiAdi], [vergiTipi], [Tutar], [faiz], [bakanlıkID], [vatandasID]) VALUES (1, N'kdv', N'katma deger', 3000.0000, N'15', 1, 1)
SET IDENTITY_INSERT [dbo].[Vergiler] OFF
GO
ALTER TABLE [dbo].[Vergiler]  WITH CHECK ADD  CONSTRAINT [FK_Vergiler_Bakanlık] FOREIGN KEY([bakanlıkID])
REFERENCES [dbo].[Bakanlık] ([bakanlıkID])
GO
ALTER TABLE [dbo].[Vergiler] CHECK CONSTRAINT [FK_Vergiler_Bakanlık]
GO
ALTER TABLE [dbo].[Vergiler]  WITH CHECK ADD  CONSTRAINT [FK_Vergiler_Vatandas1] FOREIGN KEY([vatandasID])
REFERENCES [dbo].[Vatandas] ([vatandasID])
GO
ALTER TABLE [dbo].[Vergiler] CHECK CONSTRAINT [FK_Vergiler_Vatandas1]
GO
/****** Object:  StoredProcedure [dbo].[BakanlikAdd]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BakanlikAdd]
@bakanlıkAdi varchar(50),
@daireBaskanlik varchar(50),
@Ciro money,
@Merkez varchar(50)
as begin
insert into Bakanlık([bakanlıkAdi],[daireBaskanlik],[Ciro],[Merkez])values(@bakanlıkAdi,@daireBaskanlik,@Ciro,@Merkez)
end
GO
/****** Object:  StoredProcedure [dbo].[BakanlikDel]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BakanlikDel]
@bakanlıkID int
as begin
delete from Bakanlık where bakanlıkID=@bakanlıkID
end
GO
/****** Object:  StoredProcedure [dbo].[BakanlikList]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BakanlikList]
as begin
select * from Bakanlık
end
GO
/****** Object:  StoredProcedure [dbo].[BakanlıkSearch]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BakanlıkSearch]
as begin
select * from Bakanlık order by Ciro asc
end
GO
/****** Object:  StoredProcedure [dbo].[BakanlikUpdate]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BakanlikUpdate]
@bakanlıkID int,
@bakanlıkAdi varchar(50),
@daireBaskanlik varchar(50),
@Ciro money,
@Merkez varchar(50)
as begin
update Bakanlık set bakanlıkAdi=@bakanlıkAdi,daireBaskanlik=@daireBaskanlik,Ciro=@Ciro,Merkez=@Merkez where bakanlıkID=@bakanlıkID
end
GO
/****** Object:  StoredProcedure [dbo].[VatandasAdd]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VatandasAdd]
@TCNo varchar(11),
@Meslek varchar(50),
@Adres varchar(50),
@telefon varchar(11),
@mail varchar(50)
as begin
insert into Vatandas([TCNo],[Meslek],[Adres],[telefon],[mail])values(@TCNo,@Meslek,@Adres,@telefon,@mail)
end
GO
/****** Object:  StoredProcedure [dbo].[VatandasDel]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VatandasDel]
@vatandasID int
as begin
delete from Vatandas where vatandasID=@vatandasID
end
GO
/****** Object:  StoredProcedure [dbo].[VatandasList]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VatandasList]
as begin
select * from Vatandas
end
GO
/****** Object:  StoredProcedure [dbo].[VatandasSearch]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VatandasSearch]
as begin
select * from Vatandas order by TCNo desc
end
GO
/****** Object:  StoredProcedure [dbo].[VatandasUpdate]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VatandasUpdate]
@vatandasID int,
@TCNo varchar(11),
@Meslek varchar(50),
@Adres varchar(50),
@telefon varchar(11),
@mail varchar(50)
as begin
update Vatandas set TCNo=@TCNo,Meslek=@Meslek,Adres=@Adres,telefon=@telefon,mail=@mail where vatandasID=@vatandasID
end
GO
/****** Object:  StoredProcedure [dbo].[VergiAdd]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VergiAdd]
@vergiAdi varchar(50),
@vergiTipi varchar(50),
@Tutar money,
@faiz varchar(50),
@bakanlıkID int,
@vatandasID int
as begin
insert into Vergiler([vergiAdi],[vergiTipi],[Tutar],[faiz],[bakanlıkID],[vatandasID])values(@vergiAdi,@vergiTipi,@Tutar,@faiz,@bakanlıkID,@vatandasID)
end
GO
/****** Object:  StoredProcedure [dbo].[VergiDel]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VergiDel]
@vergiID int
as begin
delete from Vergiler where vergiID=@vergiID
end
GO
/****** Object:  StoredProcedure [dbo].[VergiList]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VergiList]
as begin
select * from Vergiler
end
GO
/****** Object:  StoredProcedure [dbo].[VergiSearch]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VergiSearch]
as begin
select vergiTipi,Tutar from Vergiler group by vergiTipi,Tutar order by Tutar asc
end
GO
/****** Object:  StoredProcedure [dbo].[VergiUpdate]    Script Date: 20.08.2023 14:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[VergiUpdate]
@vergiID int,
@vergiAdi varchar(50),
@vergiTipi varchar(50),
@Tutar money,
@faiz varchar(50),
@bakanlıkID int,
@vatandasID int
as begin
update Vergiler set vergiAdi=@vergiAdi,vergiTipi=@vergiTipi,Tutar=@Tutar,faiz=@faiz,bakanlıkID=@bakanlıkID,vatandasID=@vatandasID where vergiID=@vergiID
end
GO
USE [master]
GO
ALTER DATABASE [Bakanlıklar] SET  READ_WRITE 
GO
