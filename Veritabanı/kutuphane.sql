USE [master]
GO
/****** Object:  Database [kutuphane]    Script Date: 2.02.2023 16:53:24 ******/
CREATE DATABASE [kutuphane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kutuphane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\kutuphane.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'kutuphane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\kutuphane_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [kutuphane] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kutuphane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kutuphane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kutuphane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kutuphane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kutuphane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kutuphane] SET ARITHABORT OFF 
GO
ALTER DATABASE [kutuphane] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [kutuphane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kutuphane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kutuphane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kutuphane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kutuphane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kutuphane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kutuphane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kutuphane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kutuphane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kutuphane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kutuphane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kutuphane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kutuphane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kutuphane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kutuphane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kutuphane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kutuphane] SET RECOVERY FULL 
GO
ALTER DATABASE [kutuphane] SET  MULTI_USER 
GO
ALTER DATABASE [kutuphane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kutuphane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kutuphane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kutuphane] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [kutuphane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kutuphane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [kutuphane] SET QUERY_STORE = OFF
GO
USE [kutuphane]
GO
/****** Object:  Table [dbo].[islem]    Script Date: 2.02.2023 16:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[islem](
	[islem_id] [int] IDENTITY(1,1) NOT NULL,
	[uye_no] [int] NULL,
	[kitap_no] [int] NULL,
	[alinan_tarih] [datetime] NULL,
	[verilen_tarih] [datetime] NULL,
	[teslim_tarihi] [datetime] NULL,
	[teslim_durum] [nvarchar](5) NULL,
 CONSTRAINT [PK_islem] PRIMARY KEY CLUSTERED 
(
	[islem_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kitap]    Script Date: 2.02.2023 16:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitap](
	[kitap_id] [int] IDENTITY(1,1) NOT NULL,
	[kitap_adi] [nchar](40) NULL,
	[yazar_no] [int] NULL,
	[tur_no] [int] NULL,
	[kitap_sayfasayisi] [int] NULL,
	[kitap_adet] [int] NULL,
	[kitap_yayinevi_no] [int] NULL,
	[kitap_basimyili] [date] NULL,
 CONSTRAINT [PK_kitap] PRIMARY KEY CLUSTERED 
(
	[kitap_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tur]    Script Date: 2.02.2023 16:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tur](
	[tur_id] [int] IDENTITY(1,1) NOT NULL,
	[tur_adi] [nvarchar](20) NULL,
 CONSTRAINT [PK_tur] PRIMARY KEY CLUSTERED 
(
	[tur_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uye]    Script Date: 2.02.2023 16:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uye](
	[uye_id] [int] IDENTITY(1,1) NOT NULL,
	[uye_tc] [char](11) NOT NULL,
	[uye_ad] [nvarchar](30) NULL,
	[uye_soyad] [nvarchar](25) NULL,
	[uye_cinsiyet] [char](1) NULL,
	[uye_dtarih] [date] NULL,
	[uye_tel] [char](10) NULL,
 CONSTRAINT [PK_uye] PRIMARY KEY CLUSTERED 
(
	[uye_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yayinevi]    Script Date: 2.02.2023 16:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yayinevi](
	[yayinevi_id] [int] IDENTITY(1,1) NOT NULL,
	[yayinevi_ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_yayinevi] PRIMARY KEY CLUSTERED 
(
	[yayinevi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yazar]    Script Date: 2.02.2023 16:53:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yazar](
	[yazar_id] [int] IDENTITY(1,1) NOT NULL,
	[yazar_ad_soyad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[yazar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[islem] ON 

INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (1, 1, 7, CAST(N'2021-08-25T00:00:00.000' AS DateTime), NULL, CAST(N'2021-09-08T00:00:00.000' AS DateTime), N'Hayır')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (13, 5, 5, CAST(N'2021-08-20T00:00:00.000' AS DateTime), NULL, CAST(N'2021-09-03T00:00:00.000' AS DateTime), N'Hayır')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (14, 7, 2, CAST(N'2021-08-10T00:00:00.000' AS DateTime), NULL, CAST(N'2021-08-24T00:00:00.000' AS DateTime), N'Hayır')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (15, 7, 8, CAST(N'2021-08-04T00:00:00.000' AS DateTime), CAST(N'2021-08-14T00:00:00.000' AS DateTime), CAST(N'2021-08-18T00:00:00.000' AS DateTime), N'Evet')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (16, 12, 6, CAST(N'2021-08-03T00:00:00.000' AS DateTime), CAST(N'2021-08-10T00:00:00.000' AS DateTime), CAST(N'2021-08-17T00:00:00.000' AS DateTime), N'Evet')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (20, 1, 5, CAST(N'2021-08-26T00:00:00.000' AS DateTime), CAST(N'2021-08-26T00:00:00.000' AS DateTime), CAST(N'2021-09-09T00:00:00.000' AS DateTime), N'Evet')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (21, 7, 5, CAST(N'2021-08-26T00:00:00.000' AS DateTime), NULL, CAST(N'2021-09-09T00:00:00.000' AS DateTime), N'Hayır')
INSERT [dbo].[islem] ([islem_id], [uye_no], [kitap_no], [alinan_tarih], [verilen_tarih], [teslim_tarihi], [teslim_durum]) VALUES (22, 12, 5, CAST(N'2021-08-26T00:00:00.000' AS DateTime), NULL, CAST(N'2021-09-09T00:00:00.000' AS DateTime), N'Hayır')
SET IDENTITY_INSERT [dbo].[islem] OFF
GO
SET IDENTITY_INSERT [dbo].[kitap] ON 

INSERT [dbo].[kitap] ([kitap_id], [kitap_adi], [yazar_no], [tur_no], [kitap_sayfasayisi], [kitap_adet], [kitap_yayinevi_no], [kitap_basimyili]) VALUES (1, N'Simyacı                                 ', 11, 21, 192, 2, 6, CAST(N'2016-02-01' AS Date))
INSERT [dbo].[kitap] ([kitap_id], [kitap_adi], [yazar_no], [tur_no], [kitap_sayfasayisi], [kitap_adet], [kitap_yayinevi_no], [kitap_basimyili]) VALUES (2, N'Hayvan Çiftliği                         ', 9, 21, 151, 3, 6, CAST(N'2020-04-01' AS Date))
INSERT [dbo].[kitap] ([kitap_id], [kitap_adi], [yazar_no], [tur_no], [kitap_sayfasayisi], [kitap_adet], [kitap_yayinevi_no], [kitap_basimyili]) VALUES (5, N'Tersi Ve Yüzü                           ', 7, 9, 70, 4, 6, CAST(N'2020-04-25' AS Date))
INSERT [dbo].[kitap] ([kitap_id], [kitap_adi], [yazar_no], [tur_no], [kitap_sayfasayisi], [kitap_adet], [kitap_yayinevi_no], [kitap_basimyili]) VALUES (6, N'Uzak                                    ', 6, 11, 134, 3, 4, CAST(N'2020-07-25' AS Date))
INSERT [dbo].[kitap] ([kitap_id], [kitap_adi], [yazar_no], [tur_no], [kitap_sayfasayisi], [kitap_adet], [kitap_yayinevi_no], [kitap_basimyili]) VALUES (7, N'Aspidistra                              ', 9, 21, 296, 3, 6, CAST(N'2021-01-25' AS Date))
INSERT [dbo].[kitap] ([kitap_id], [kitap_adi], [yazar_no], [tur_no], [kitap_sayfasayisi], [kitap_adet], [kitap_yayinevi_no], [kitap_basimyili]) VALUES (8, N'Oblomov                                 ', 22, 10, 622, 3, 1, CAST(N'2021-03-01' AS Date))
SET IDENTITY_INSERT [dbo].[kitap] OFF
GO
SET IDENTITY_INSERT [dbo].[tur] ON 

INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (1, N'Aşk')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (2, N'Anı-Mektup-Günlük')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (3, N'Polisiye')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (4, N'Araştırma-İnceleme')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (5, N'Bilim-Kurgu')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (6, N'Biyografi')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (7, N'Çizgi-Roman')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (8, N'Deneme')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (9, N'Edebiyat')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (10, N'Dünya Klasikleri')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (11, N'Felsefe')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (12, N'Fantastik')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (13, N'Hikaye')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (14, N'Korku-Gerilim')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (15, N'Macera')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (16, N'Masal')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (17, N'Şiir')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (18, N'Tarih')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (19, N'Türk Klasikleri')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (20, N'Kişisel Gelişim')
INSERT [dbo].[tur] ([tur_id], [tur_adi]) VALUES (21, N'Roman')
SET IDENTITY_INSERT [dbo].[tur] OFF
GO
SET IDENTITY_INSERT [dbo].[uye] ON 

INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (1, N'12345678910', N'Nuh', N'Aktürk', N'E', CAST(N'1999-03-11' AS Date), N'5543212345')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (3, N'23456789101', N'Ahmet', N'Yılmaz', N'E', CAST(N'1998-05-12' AS Date), N'5432123456')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (4, N'34567891012', N'Mehmet', N'Çınar', N'E', CAST(N'1997-06-13' AS Date), N'5321234567')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (5, N'45678910123', N'Çağla', N'Demir', N'K', CAST(N'1996-07-14' AS Date), N'5212345678')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (6, N'56789101234', N'Aybike', N'Doruk', N'K', CAST(N'2000-06-24' AS Date), N'5543212345')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (7, N'67891012345', N'Deniz', N'Bayraktar', N'E', CAST(N'2000-07-01' AS Date), N'5654321234')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (8, N'78910123456', N'Emre', N'Yıldız', N'E', CAST(N'1982-02-04' AS Date), N'5554322345')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (9, N'89101234567', N'Seçil', N'Namal', N'K', CAST(N'1997-06-15' AS Date), N'5565432123')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (11, N'91012345678', N'Cahit', N'Tarancı', N'E', CAST(N'1992-04-26' AS Date), N'5065432123')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (12, N'10123456789', N'Timur', N'Kazandibi', N'E', CAST(N'2010-06-10' AS Date), N'5082345613')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (14, N'22345678910', N'Deniz', N'Yiğit', N'K', CAST(N'1995-06-08' AS Date), N'5054321234')
INSERT [dbo].[uye] ([uye_id], [uye_tc], [uye_ad], [uye_soyad], [uye_cinsiyet], [uye_dtarih], [uye_tel]) VALUES (15, N'33456789101', N'Hatice', N'Can', N'K', CAST(N'1995-08-21' AS Date), N'3213243543')
SET IDENTITY_INSERT [dbo].[uye] OFF
GO
SET IDENTITY_INSERT [dbo].[yayinevi] ON 

INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (1, N'Türkiye İş Bankası Kültür Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (2, N'İthaki Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (3, N'Ayrıntı Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (4, N'Metis Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (5, N'Say Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (6, N'Can Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (7, N'Yapı Kredi Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (8, N'Doğan Kitap')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (9, N'İletişim Yayınları')
INSERT [dbo].[yayinevi] ([yayinevi_id], [yayinevi_ad]) VALUES (10, N'Remzi Kitabevi')
SET IDENTITY_INSERT [dbo].[yayinevi] OFF
GO
SET IDENTITY_INSERT [dbo].[yazar] ON 

INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (1, N'Paul Auster')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (2, N'Sait Faik Abasıyanık')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (3, N'Pierce Brown')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (4, N'Tezer Özlü')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (5, N'Didem Madak')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (6, N'Oruç Aruoba')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (7, N'Albert Camus')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (8, N'Mark Twain')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (9, N'George Orwell')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (10, N'Anton Çehov')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (11, N'Paulo Coelho')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (12, N'Richard Dawkins')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (13, N'Gavin Francis')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (14, N'Olga Tokarczuk')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (15, N'J. D. Salinger')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (16, N'Edgar Allan Poe')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (17, N'William Shakespeare')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (18, N'Jack London')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (19, N'Virginia Woolf')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (20, N'Anthony Burgess')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (21, N'Franz Kafka')
INSERT [dbo].[yazar] ([yazar_id], [yazar_ad_soyad]) VALUES (22, N'İvan Gonçarov')
SET IDENTITY_INSERT [dbo].[yazar] OFF
GO
ALTER TABLE [dbo].[islem]  WITH CHECK ADD  CONSTRAINT [FK_islem_kitap] FOREIGN KEY([kitap_no])
REFERENCES [dbo].[kitap] ([kitap_id])
GO
ALTER TABLE [dbo].[islem] CHECK CONSTRAINT [FK_islem_kitap]
GO
ALTER TABLE [dbo].[islem]  WITH CHECK ADD  CONSTRAINT [FK_islem_uye] FOREIGN KEY([uye_no])
REFERENCES [dbo].[uye] ([uye_id])
GO
ALTER TABLE [dbo].[islem] CHECK CONSTRAINT [FK_islem_uye]
GO
ALTER TABLE [dbo].[kitap]  WITH CHECK ADD  CONSTRAINT [FK_kitap_tur] FOREIGN KEY([tur_no])
REFERENCES [dbo].[tur] ([tur_id])
GO
ALTER TABLE [dbo].[kitap] CHECK CONSTRAINT [FK_kitap_tur]
GO
ALTER TABLE [dbo].[kitap]  WITH CHECK ADD  CONSTRAINT [FK_kitap_yayinevi] FOREIGN KEY([kitap_yayinevi_no])
REFERENCES [dbo].[yayinevi] ([yayinevi_id])
GO
ALTER TABLE [dbo].[kitap] CHECK CONSTRAINT [FK_kitap_yayinevi]
GO
ALTER TABLE [dbo].[kitap]  WITH CHECK ADD  CONSTRAINT [FK_kitap_yazar] FOREIGN KEY([yazar_no])
REFERENCES [dbo].[yazar] ([yazar_id])
GO
ALTER TABLE [dbo].[kitap] CHECK CONSTRAINT [FK_kitap_yazar]
GO
USE [master]
GO
ALTER DATABASE [kutuphane] SET  READ_WRITE 
GO
