USE [master]
GO
/****** Object:  Database [DbCv]    Script Date: 21.09.2026 19:40:01 ******/
CREATE DATABASE [DbCv]
 CONTAINMENT = NONE
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DbCv] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbCv].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbCv] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbCv] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbCv] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbCv] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbCv] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbCv] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbCv] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbCv] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbCv] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbCv] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbCv] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbCv] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbCv] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbCv] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbCv] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbCv] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbCv] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbCv] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbCv] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbCv] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbCv] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbCv] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbCv] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbCv] SET  MULTI_USER 
GO
ALTER DATABASE [DbCv] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbCv] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbCv] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbCv] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbCv] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbCv] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [DbCv] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DbCv] SET QUERY_STORE = ON
GO
ALTER DATABASE [DbCv] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DbCv]
GO
/****** Object:  Table [dbo].[TblAdmin]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAdmin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL,
 CONSTRAINT [PK_TblAdmin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDeneyimlerim]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDeneyimlerim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Baslik] [varchar](100) NULL,
	[AltBaslik] [varchar](100) NULL,
	[Aciklama] [varchar](max) NULL,
	[Tarih] [varchar](100) NULL,
 CONSTRAINT [PK_TblDeneyimlerim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEgitimlerim]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEgitimlerim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Baslik] [varchar](100) NULL,
	[Altaslik1] [varchar](100) NULL,
	[AltBaslik2] [varchar](100) NULL,
	[GNO] [varchar](10) NULL,
	[Tarih] [varchar](100) NULL,
 CONSTRAINT [PK_TblEgitimlerim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHakkimda]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHakkimda](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Adres] [varchar](100) NULL,
	[Telefon] [varchar](20) NULL,
	[Mail] [varchar](50) NULL,
	[Açıklama] [varchar](max) NULL,
	[Resim] [varchar](100) NULL,
 CONSTRAINT [PK_TblHakkimda] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHobilerim]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHobilerim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama1] [varchar](500) NULL,
	[Aciklama2] [varchar](500) NULL,
 CONSTRAINT [PK_TblHobilerim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbliletisim]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbliletisim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](100) NULL,
	[Mail] [varchar](50) NULL,
	[Konu] [varchar](100) NULL,
	[Mesaj] [varchar](100) NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK_Tbliletisim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSertifikalarim]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSertifikalarim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [varchar](250) NULL,
	[Tarih] [varchar](50) NULL,
 CONSTRAINT [PK_TblSertifikalarım] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSosyalMedya]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSosyalMedya](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](30) NULL,
	[Link] [varchar](50) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblYeteneklerim]    Script Date: 21.09.2026 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblYeteneklerim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Yetenek] [varchar](100) NULL,
	[Oran] [tinyint] NULL,
 CONSTRAINT [PK_TblYeteneklerim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblAdmin] ON 

INSERT [dbo].[TblAdmin] ([ID], [KullaniciAdi], [Sifre]) VALUES (1, N'Admin', N'1234')
SET IDENTITY_INSERT [dbo].[TblAdmin] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDeneyimlerim] ON 

INSERT [dbo].[TblDeneyimlerim] ([ID], [Baslik], [AltBaslik], [Aciklama], [Tarih]) VALUES (1, N'Analist', N'Is Gelistirme', N'Proje ve Is Gelistirme Stajyer,', N'05.05.2025 - 09.01.2025')
INSERT [dbo].[TblDeneyimlerim] ([ID], [Baslik], [AltBaslik], [Aciklama], [Tarih]) VALUES (2, N'Fullstack Gelistirici', N'ERÜ Bilgi Islem Daire Baskanligi', N'Üniversite içinde kullanilan sistemlerin gelistirilmesi', N'01.10.2025 - 01.06.2026')
INSERT [dbo].[TblDeneyimlerim] ([ID], [Baslik], [AltBaslik], [Aciklama], [Tarih]) VALUES (3, N'Fullstack Gelistirici', N'Yazilim Bilisim Sistemleri', N'Süreç yönetim sistemlerinin gelistirilmesi, bakimi ve destegi', N'01.06.2026 - Devam ediyor')
SET IDENTITY_INSERT [dbo].[TblDeneyimlerim] OFF
GO
SET IDENTITY_INSERT [dbo].[TblEgitimlerim] ON 

INSERT [dbo].[TblEgitimlerim] ([ID], [Baslik], [Altaslik1], [AltBaslik2], [GNO], [Tarih]) VALUES (1, N'Erciyes Üniversitesi', N'Mühendislik Fakültesi', N'Bilgisayar Mühendisligi', N'3.06', N'Eylül 2021 - Temmuz 2026')
INSERT [dbo].[TblEgitimlerim] ([ID], [Baslik], [Altaslik1], [AltBaslik2], [GNO], [Tarih]) VALUES (5, N'Test', N'Test ', N'Test', N'92', N'Mayis 2024 - Haziran 2026')
SET IDENTITY_INSERT [dbo].[TblEgitimlerim] OFF
GO
SET IDENTITY_INSERT [dbo].[TblHakkimda] ON 

INSERT [dbo].[TblHakkimda] ([ID], [Ad], [Soyad], [Adres], [Telefon], [Mail], [Açıklama], [Resim]) VALUES (1, N'Umut', N'Yalçin', N'Talas/Kayseri', N'555 506 4466', N'umuty@gmail.com', N'Merhaba, Ben Umut Yalçin. Erciyes Üniversitesi Bilgisayar Mühendisligi mezunuyum. Fullstack gelistirici olarak çalismaktayim.', N'https://i.hizliresim.com/ce0cp8vy.jpg')
SET IDENTITY_INSERT [dbo].[TblHakkimda] OFF
GO
SET IDENTITY_INSERT [dbo].[TblHobilerim] ON 

INSERT [dbo].[TblHobilerim] ([ID], [Aciklama1], [Aciklama2]) VALUES (1, N'Kitap okumak, müzik dinlemek, yeni yerler kesfetmek ve teknolojiyle ilgilenmek.
', N'Spor yapmak, fotograf çekmek, film izlemek ve kisisel gelisim üzerine yeni seyler ögrenmek.
')
SET IDENTITY_INSERT [dbo].[TblHobilerim] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbliletisim] ON 

INSERT [dbo].[Tbliletisim] ([ID], [AdSoyad], [Mail], [Konu], [Mesaj], [Tarih]) VALUES (1, N'Ahmet Yılmaz', N'ahmet.yilmaz@example.com', N'Test', N'Test islemdir', CAST(N'2026-08-30' AS Date))
INSERT [dbo].[Tbliletisim] ([ID], [AdSoyad], [Mail], [Konu], [Mesaj], [Tarih]) VALUES (2, N'Umut Yalçin', N'umut.yalcin@example.com', N'Test', N'Test islemidir', CAST(N'2026-08-30' AS Date))
SET IDENTITY_INSERT [dbo].[Tbliletisim] OFF
GO
SET IDENTITY_INSERT [dbo].[TblSertifikalarim] ON 

INSERT [dbo].[TblSertifikalarim] ([ID], [Aciklama], [Tarih]) VALUES (1, N'AWS Certified Solutions Architect – Associate', N'Eylül 2024')
INSERT [dbo].[TblSertifikalarim] ([ID], [Aciklama], [Tarih]) VALUES (2, N'Microsoft Certified: Azure Administrator Associate', N'Kasim 2024')
INSERT [dbo].[TblSertifikalarim] ([ID], [Aciklama], [Tarih]) VALUES (3, N'Certified Kubernetes Administrator (CKA)', N'Mart 2023')
INSERT [dbo].[TblSertifikalarim] ([ID], [Aciklama], [Tarih]) VALUES (4, N'CompTIA Security+', N'Haziran 2026')
INSERT [dbo].[TblSertifikalarim] ([ID], [Aciklama], [Tarih]) VALUES (5, N'Oracle Certified Professional: Java SE Developer', N'Nisan 2025')
SET IDENTITY_INSERT [dbo].[TblSertifikalarim] OFF
GO
SET IDENTITY_INSERT [dbo].[TblSosyalMedya] ON 

INSERT [dbo].[TblSosyalMedya] ([ID], [Ad], [Link], [Durum]) VALUES (1, N'linkedin-in', N'https://www.linkedin.com/in/umut-yalcin-/', 1)
INSERT [dbo].[TblSosyalMedya] ([ID], [Ad], [Link], [Durum]) VALUES (2, N'github', N'https://github.com/umuty4lcin', 1)
INSERT [dbo].[TblSosyalMedya] ([ID], [Ad], [Link], [Durum]) VALUES (3, N'twitter', N'https://x.com/', 1)
INSERT [dbo].[TblSosyalMedya] ([ID], [Ad], [Link], [Durum]) VALUES (4, N'facebook-f', N'https://www.facebook.com/?locale=tr_TR', 1)
INSERT [dbo].[TblSosyalMedya] ([ID], [Ad], [Link], [Durum]) VALUES (5, N'instagram', N'https://www.instagram.com/?hl=tr', 1)
SET IDENTITY_INSERT [dbo].[TblSosyalMedya] OFF
GO
SET IDENTITY_INSERT [dbo].[TblYeteneklerim] ON 

INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (1, N'C# Programlama Dili', 89)
INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (2, N'Asp.Net Mvc5', 70)
INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (3, N'Asp.NetCore Mvc', 65)
INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (4, N'Mssql Veri Tabani', 80)
INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (5, N'PostgreSQL', 95)
INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (6, N'Python Programlama Dili', 50)
INSERT [dbo].[TblYeteneklerim] ([ID], [Yetenek], [Oran]) VALUES (7, N'Agile Scrum1', 69)
SET IDENTITY_INSERT [dbo].[TblYeteneklerim] OFF
GO
USE [master]
GO
ALTER DATABASE [DbCv] SET  READ_WRITE 
GO
