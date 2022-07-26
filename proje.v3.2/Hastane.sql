USE [Hastane]
GO
/****** Object:  Table [dbo].[Doktor]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktor](
	[D_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_ID] [int] NULL,
	[D_ad_soyad] [char](40) NULL,
	[D_klinik_ID] [int] NULL,
	[D_k_adi] [nchar](20) NULL,
	[D_sifte] [nchar](20) NULL,
 CONSTRAINT [PK_Doktor] PRIMARY KEY CLUSTERED 
(
	[D_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eczane]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eczane](
	[İlac_ID] [int] IDENTITY(1,1) NOT NULL,
	[İlac_adi] [nchar](40) NOT NULL,
	[İlac_ticari_ad] [nchar](25) NOT NULL,
	[İlac_stok] [int] NOT NULL,
	[İlac_klinik_ID] [int] NOT NULL,
 CONSTRAINT [PK_Eczane] PRIMARY KEY CLUSTERED 
(
	[İlac_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hasta]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hasta](
	[H_ID] [int] IDENTITY(1,1) NOT NULL,
	[H_tc] [char](11) NULL,
	[H_adi] [nchar](25) NULL,
	[H_s_adi] [nchar](25) NULL,
	[H_cinsiyet] [char](1) NULL,
	[H_d_yeri] [nchar](20) NULL,
	[H_d_tarihi] [nchar](20) NULL,
	[H_baba_adi] [nchar](20) NULL,
	[H_anne_adi] [nchar](20) NULL,
	[H_tel] [nchar](10) NULL,
	[H_eposta] [nchar](40) NULL,
	[H_sifre] [nchar](30) NULL,
	[H_yatis_ID] [int] NULL,
	[H_recete_ID] [text] NULL,
	[H_randevu_ID] [int] NULL,
	[D_ID] [int] NULL,
	[H_nabiz] [int] NULL,
	[H_randevu_tarih] [char](30) NULL,
	[H_tedavi_durum] [int] NULL,
	[H_tansiyon] [nchar](8) NULL,
	[H_tahlil_ID] [int] NULL,
	[H_ilac_ID] [int] NULL,
	[H_tahlil_sonuc] [text] NULL,
	[H_randevu_saat] [nchar](6) NULL,
	[H_taburcu_tarih] [char](30) NULL,
	[H_gecmis_randevu_tarih] [char](30) NULL,
 CONSTRAINT [PK_Hasta] PRIMARY KEY CLUSTERED 
(
	[H_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laboratuvar]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratuvar](
	[Tahlil_ID] [int] IDENTITY(1,1) NOT NULL,
	[Tahlil_sonuc] [text] NULL,
 CONSTRAINT [PK_Laboratuvar] PRIMARY KEY CLUSTERED 
(
	[Tahlil_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_tc] [nchar](11) NULL,
	[P_adi] [nchar](25) NULL,
	[P_s_adi] [nchar](25) NULL,
	[P_anne_adi] [nchar](25) NULL,
	[P_baba_adi] [nchar](25) NULL,
	[P_d_yeri] [nchar](20) NULL,
	[P_d_tarihi] [date] NULL,
	[P_sifre] [nchar](30) NULL,
	[P_yetki] [nchar](10) NULL,
	[P_birim_ID] [int] NULL,
	[P_klinik_ID] [int] NULL,
	[P_eposta] [nchar](30) NULL,
	[P_tel] [nchar](11) NULL,
	[p_cinsiyet] [char](1) NULL,
	[P_izingun] [int] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polikinlik]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polikinlik](
	[Polik_ID] [int] IDENTITY(1,1) NOT NULL,
	[Polik_d_ID] [int] NULL,
	[Polik_adi] [nchar](30) NULL,
 CONSTRAINT [PK_Polikinlik] PRIMARY KEY CLUSTERED 
(
	[Polik_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yatis]    Script Date: 30.06.2022 23:09:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yatis](
	[Yatis_ID] [int] IDENTITY(1,1) NOT NULL,
	[Yatis_tarih] [nchar](20) NULL,
	[H_tc] [nchar](11) NULL,
	[Taburuc_durum] [int] NULL,
 CONSTRAINT [PK_Yatis] PRIMARY KEY CLUSTERED 
(
	[Yatis_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doktor] ON 

INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (1, 1, N'Ahmet Enes Söylemez                     ', NULL, N'ahmet42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (2, 1, N'Abdullah Nurettin Büyükkalaycı          ', NULL, N'abdullah42          ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (3, 2, N'Mustafa Dağdelen                        ', NULL, N'mustafa42           ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (4, 3, N'Didem Çam                               ', NULL, N'didem42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (5, 3, N'Ali Filiz                               ', NULL, N'ali42               ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (6, 5, N'Atahan Gökdoğan                         ', NULL, N'atahan42            ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (7, 5, N'Sergen Deveci                           ', NULL, N'Sergen42            ', N'sergen42            ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (8, 6, N'Abdurrahman Öztürk                      ', NULL, N'abdurrahman42       ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (9, 6, N'Adem Tanı                               ', NULL, N'adem42              ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (10, 7, N'Akif Çelik                              ', NULL, N'akif42              ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (11, 7, N'Fatma Umutlu                            ', NULL, N'fatma42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (12, 8, N'Gamze Türkan                            ', NULL, N'gamze42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (13, 8, N'Gökhan Toka                             ', NULL, N'gökhan42            ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (14, 9, N'Habip Işık                              ', NULL, N'habip42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (15, 9, N'Halime Şahin                            ', NULL, N'halime42            ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (16, 10, N'İdris Biçer                             ', NULL, N'idris42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (17, 11, N'İrfan Öztürk                            ', NULL, N'irfan42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (18, 11, N'Kadriye Battal                          ', NULL, N'kadriye42           ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (19, 13, N'Leyla Poyraz                            ', NULL, N'leyla42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (20, 13, N'Mazlum Arı                              ', NULL, N'mazlum42            ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (21, 14, N'Melek Kavak                             ', NULL, N'melek42             ', N'123                 ')
INSERT [dbo].[Doktor] ([D_ID], [P_ID], [D_ad_soyad], [D_klinik_ID], [D_k_adi], [D_sifte]) VALUES (22, 12, N'Kerim Durmaz                            ', NULL, N'Kerim42             ', N'123                 ')
SET IDENTITY_INSERT [dbo].[Doktor] OFF
GO
SET IDENTITY_INSERT [dbo].[Eczane] ON 

INSERT [dbo].[Eczane] ([İlac_ID], [İlac_adi], [İlac_ticari_ad], [İlac_stok], [İlac_klinik_ID]) VALUES (2, N'Parol                                   ', N'Ağrı Kesici              ', 3123, 4)
INSERT [dbo].[Eczane] ([İlac_ID], [İlac_adi], [İlac_ticari_ad], [İlac_stok], [İlac_klinik_ID]) VALUES (4, N'Arvales                                 ', N'Ağrı Kesici              ', 200, 1)
INSERT [dbo].[Eczane] ([İlac_ID], [İlac_adi], [İlac_ticari_ad], [İlac_stok], [İlac_klinik_ID]) VALUES (5, N'Medolvin                                ', N'Soğuk Algınlığı          ', 1, 1)
SET IDENTITY_INSERT [dbo].[Eczane] OFF
GO
SET IDENTITY_INSERT [dbo].[Hasta] ON 

INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (2, N'50515404992', N'Ahmet Enes               ', N'Söylemez                 ', N'E', N'Konya               ', N'2001                ', N'Burhan              ', N'Naciye              ', N'5534595405', N'sylmz7507@gmail.com                     ', N'1234                          ', 1, N'CERTICAN® 0.75 mg tablet
CO-DİOVAN® 320 mg/ 25 mg film kaplı tablet
EXFORGE® 5 mg/160 mg Film Kaplı Tablet', 1, 10, 90, N'1.07.2022                     ', 1, N'120/80  ', NULL, 1, N'Kalsiyum:1111
Potasyum:1111
Bilurubin:1111
Fosfor:111
Hemotokrit111
Hemoglobin:111', N'10:30 ', N'23.06.2022                    ', N'29.06.2022                    ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (3, N'12345678912', N'Muhammed                 ', N'Demir                    ', N'E', N'İstanbul            ', N'1986                ', N'Mehmet              ', N'Hacer               ', N'5554652248', N'muhammed34@gmail.com                    ', N'456                           ', 0, N'AFINITOR® 10 mg tablet
AZARGA®
CERTICAN® 0.75 mg tablet', 1, 5, 30, N'30.06.2022                    ', 1, N'12/8    ', 1, 2, N'Kalsiyum:1111
Potasyum:1111
Bilurubin:1111
Fosfor:111
Hemotokrit111
Hemoglobin:111', N'13:00 ', N'30.06.2022                    ', N'29.06.2022                    ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (5, N'12345678712', N'Abdullah                 ', N'Büyükkalaycı             ', N'E', N'Konya               ', N'2001                ', N'deneme              ', N'deneme              ', N'5538794518', N'abdullah@gmail.com                      ', N'123                           ', 0, N'dolorex ', 1, 1, 100, N'0                             ', 1, N'10/7    ', 1, 5, N'Kalsiyum:1111
Potasyum:1111
Bilurubin:1111
Fosfor:111
Hemotokrit111
Hemoglobin:111', NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (11, N'33487465421', N'Tuba                     ', N'Gönder                   ', N'K', N'Karaman             ', N'2002                ', N'Ahmet               ', N'Hacer               ', N'5549875135', N'tuba@gmail.com                          ', N'123                           ', 1, N'apranax', 1, 13, 70, N'30.06.2022                    ', NULL, N'11/9    ', 1, 4, NULL, N'9:30  ', NULL, N'23.06.2022                    ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (12, N'33478952420', N'Adil                     ', N'Kaynar                   ', N'E', N'Kırşehir            ', N'1989                ', N'Mehmet              ', N'Neriman             ', N'5555555555', N'adil@gmail.com                          ', N'123                           ', 0, N'aspirin', 1, 6, 55, N'1.07.2022                     ', NULL, N'10/9    ', 1, 2, NULL, N'10:00 ', NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (13, N'22222222220', N'Mustafa                  ', N'Korkmaz                  ', N'E', N'Gaziantep           ', N'1999                ', N'yahya               ', N'ayşe                ', N'5225365656', N'mustafa@eposta.com                      ', N'123                           ', 0, N'majezik', NULL, 23, NULL, NULL, NULL, NULL, 1, 1, N'Kalsiyum:1111
Potasyum:1111
Bilurubin:1111
Fosfor:111
Hemotokrit111
Hemoglobin:111', NULL, N'28.06.2022                    ', NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (15, N'22222222221', N'Akçakağan                ', N'Kalın                    ', N'E', N'yalova              ', N'2000                ', N'Serkan              ', N'Mevlidiye           ', N'5555555555', N'akca@gmail.com                          ', N'123                           ', 1, N'deneme
deneme', NULL, 7, NULL, N'0                             ', NULL, NULL, NULL, 4, N'Kalsiyum:111
Potasyum:
Bilurubin:
Fosfor:
Hemotokrit
Hemoglobin:', N'10:00 ', NULL, N'29.06.2022                    ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (16, N'44516549811', N'Delal Abdullatif         ', N'Abzak                    ', N'E', N'Suriye              ', N'2010                ', N'Muttalip            ', N'Nahnu               ', N'5534598713', N'delal@gmail.com                         ', N'123                           ', 0, NULL, NULL, 17, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (17, N'33498745611', N'Fatma Özlem              ', N'Acar                     ', N'K', N'Kütahya             ', N'2003                ', N'Mustafa             ', N'Özlem               ', N'5019874214', N'fatma@gmail.com                         ', N'123                           ', 0, NULL, NULL, 20, NULL, N'30.06.2022                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (18, N'33496548712', N'Özde                     ', N'Acarkan                  ', N'K', N'İstanbul            ', N'1998                ', N'Muhammed            ', N'Mügenur             ', N'5597862015', N'özde@gmail.com                          ', N'123                           ', 1, NULL, NULL, 21, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (19, N'50515404882', N'Atahan                   ', N'Çınaroğlu                ', N'E', N'Adana               ', N'1978                ', N'Umut                ', N'Zehranaz            ', N'5528964502', N'atahan@gmail.com                        ', N'123                           ', 0, NULL, NULL, 21, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (20, N'50515498723', N'Hacı Mehmet              ', N'Ceran                    ', N'E', N'Adana               ', N'1961                ', N'Mert                ', N'Ahuela              ', N'5534962158', N'hacımehmet@gmail.com                    ', N'123                           ', 1, NULL, NULL, 21, NULL, N'30.06.2022                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (21, N'44528746521', N'Aykanat                  ', N'Ceylan                   ', N'K', N'Bursa               ', N'2001                ', N'Engin               ', N'Gülümse             ', N'5053547896', N'ayknat@gmail.com                        ', N'123                           ', 0, NULL, NULL, 20, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (22, N'44215647854', N'Şennur                   ', N'Demirsatan               ', N'K', N'Konya               ', N'2013                ', N'Uğur                ', N'Gizemnur            ', N'5520368712', N'şennur@gmail.com                        ', N'123                           ', 1, NULL, NULL, 8, NULL, N'30.06.2022                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (24, N'33468923147', N'Tutkum                   ', N'İrsoy                    ', N'K', N'Bursa               ', N'2008                ', N'Akif                ', N'Ahuela              ', N'5549871255', N'tutkum@gmail.com                        ', N'123                           ', 0, NULL, NULL, 7, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (25, N'55214598745', N'Mügenur                  ', N'İpekoğlu                 ', N'K', N'Erzincan            ', N'1970                ', N'Adil                ', N'Hatice              ', N'5541235874', N'mügenur@gmail.com                       ', N'123                           ', 0, NULL, NULL, 9, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (26, N'33468745821', N'Sevinç                   ', N'İçten                    ', N'K', N'İstanbul            ', N'1965                ', N'Mehmet              ', N'Berna               ', N'5534597831', N'sevinç@gmail.com                        ', N'123                           ', 1, NULL, NULL, 6, NULL, N'30.06.2022                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (27, N'50546843582', N'Nedim                    ', N'Kontacı                  ', N'E', N'Erzincan            ', N'1980                ', N'Umut                ', N'Gülbiz              ', N'5534568925', N'deim@gmail.com                          ', N'123                           ', 0, NULL, NULL, 6, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (28, N'65874225425', N'Cihan                    ', N'Kocademir                ', N'E', N'Burdur              ', N'2006                ', N'Mert                ', N'Ayşim               ', N'5052658725', N'cihan@gmail.com                         ', N'123                           ', 1, NULL, NULL, 22, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, N'13:30 ', NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (29, N'33468135415', N'Mehmetcan                ', N'Nayman                   ', N'E', N'Adana               ', N'2003                ', N'Engin               ', N'Zehranaz            ', N'5057895452', N'mehmet@gmail.com                        ', N'123                           ', 0, NULL, NULL, 16, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (30, N'45982542232', N'Servet                   ', N'Nalbant                  ', N'E', N'Konya               ', N'2002                ', N'Uğur                ', N'Seray               ', N'5057895425', N'servet@gmail.com                        ', N'123                           ', 1, NULL, NULL, 2, NULL, N'30.06.2022                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (31, N'33484796568', N'Çilem                    ', N'Nişancı                  ', N'K', N'Burdur              ', N'1983                ', N'Adil                ', N'Sıddıka             ', N'5546582155', N'çilem@gmail.com                         ', N'123                           ', 0, N'CERTICAN® 0.75 mg tablet
CO-DİOVAN® 320 mg/ 25 mg film kaplı tablet
EXFORGE® 5 mg/160 mg Film Kaplı Tablet
SUTESGO 37,5 MG SERT KAPSUL (28 KAPSUL)
ARIA-DES 2,5 MG/5 ML 150 ML SURUP
ADVANTAN M LOSYON 50 GR
ADVANTAN S COZELTI %0,1 20 ML
AIRLAST 10 MG 28 FILM TABLET
EPORON 2000 IU/0,5 ML 
EPORON 4000 IU/0,4 ML 
EQIZOLIN- IM 500 MG 1 FLAKON
ERCEFURYL 200 MG/5 ML 60 ML SUSPANSIYON
FEIBA 500 U IV 
FELDEN % 0,5 50 GR JEL', NULL, 1, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'30.06.2022                    ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (32, N'66426453255', N'Emre                     ', N'Oçar                     ', N'E', N'İstanbul            ', N'2005                ', N'Abdurrahim          ', N'Ebrar               ', N'5517855865', N'emre@gmail.com                          ', N'123                           ', 1, NULL, NULL, 17, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (33, N'64472256251', N'Kerime                   ', N'Oduncu                   ', N'K', N'Burdur              ', N'2014                ', N'Mert                ', N'Şerif               ', N'5528557575', N'kerime@gmail.com                        ', N'123                           ', 0, NULL, NULL, 18, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1.07.2022                     ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (34, N'33498745215', N'Hacer                    ', N'Öter                     ', N'K', N'Konya               ', N'1999                ', N'Akif                ', N'Buket               ', N'5536987528', N'hacer@gmail.com                         ', N'123                           ', 1, NULL, NULL, 3, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (35, N'55345225412', N'Ercüment                 ', N'Öz                       ', N'E', N'İstanbul            ', N'1999                ', N'Mehmet              ', N'Alagül              ', N'5546855578', N'ercument@gmail.com                      ', N'123                           ', 0, NULL, NULL, 4, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (36, N'50519621255', N'Berker                   ', N'Yolcu                    ', N'E', N'KahramanMaraş       ', N'1987                ', N'Tayyip              ', N'Nihan               ', N'5568788558', N'berker@gmail.com                        ', N'123                           ', 1, NULL, NULL, 19, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (37, N'50519875302', N'Ahmet Polat              ', N'Zağlı                    ', N'E', N'Adana               ', N'1968                ', N'Umut                ', N'Zehranaz            ', N'5588585251', N'ahmetpolat@gmail.com                    ', N'123                           ', 0, NULL, NULL, 6, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (38, N'33462571254', N'Ata Kerem                ', N'Varlı                    ', N'E', N'Erzincan            ', N'1961                ', N'Tayyip              ', N'Ahuela              ', N'5597542585', N'atakerem@gmail.com                      ', N'123                           ', 1, NULL, NULL, 8, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (39, N'36811451254', N'Ecem                     ', N'Yıldız                   ', N'K', N'İstanbul            ', N'1981                ', N'Abdurrahim          ', N'Gizemnur            ', N'5524585658', N'ecem@gmail.com                          ', N'123                           ', 0, NULL, NULL, 11, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (40, N'32655221545', N'Senem                    ', N'Üşenmez                  ', N'K', N'KahramanMaraş       ', N'2001                ', N'Adil                ', N'Buket               ', N'5564585555', N'senem@gmail.com                         ', N'123                           ', 1, NULL, NULL, 12, NULL, N'1.07.2022                     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (41, N'36521214412', N'Ayşen                    ', N'Yaşa                     ', N'K', N'Bursa               ', N'2002                ', N'Uğur                ', N'Zehranaz            ', N'5545522455', N'ayşen@gmail.com                         ', N'123                           ', 0, NULL, NULL, 13, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (42, N'50519554326', N'Pekcan                   ', N'Uçma                     ', N'K', N'İstanbul            ', N'1969                ', N'Engin               ', N'Mümüne              ', N'5567542755', N'pekcean@gmail.com                       ', N'123                           ', 1, N'CERTICAN® 0.75 mg tablet
CO-DİOVAN® 320 mg/ 25 mg film kaplı tablet
EXFORGE® 5 mg/160 mg Film Kaplı Tablet
SUTESGO 37,5 MG SERT KAPSUL (28 KAPSUL)
ARIA-DES 2,5 MG/5 ML 150 ML SURUP
ADVANTAN M LOSYON 50 GR
ADVANTAN S COZELTI %0,1 20 ML
AIRLAST 10 MG 28 FILM TABLET
EPORON 2000 IU/0,5 ML 
EPORON 4000 IU/0,4 ML 
EQIZOLIN- IM 500 MG 1 FLAKON
ERCEFURYL 200 MG/5 ML 60 ML SUSPANSIYON
FEIBA 500 U IV 
FELDEN % 0,5 50 GR JEL', NULL, 14, NULL, N'0                             ', NULL, NULL, 1, NULL, NULL, NULL, NULL, N'30.06.2022                    ')
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (43, N'33498452114', N'Bedirhan                 ', N'Tüfekçioğlu              ', N'E', N'Bursa               ', N'1970                ', N'Mert                ', N'Buket               ', N'5536575428', N'bedirhan@gmail.com                      ', N'123                           ', 0, NULL, NULL, 15, NULL, N'30.06.2022                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([H_ID], [H_tc], [H_adi], [H_s_adi], [H_cinsiyet], [H_d_yeri], [H_d_tarihi], [H_baba_adi], [H_anne_adi], [H_tel], [H_eposta], [H_sifre], [H_yatis_ID], [H_recete_ID], [H_randevu_ID], [D_ID], [H_nabiz], [H_randevu_tarih], [H_tedavi_durum], [H_tansiyon], [H_tahlil_ID], [H_ilac_ID], [H_tahlil_sonuc], [H_randevu_saat], [H_taburcu_tarih], [H_gecmis_randevu_tarih]) VALUES (44, N'14578986655', N'aaaaa                    ', N'bbb                      ', N'E', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'CERTICAN® 0.75 mg tablet
CO-DİOVAN® 320 mg/ 25 mg film kaplı tablet
EXFORGE® 5 mg/160 mg Film Kaplı Tablet
SUTESGO 37,5 MG SERT KAPSUL (28 KAPSUL)
ARIA-DES 2,5 MG/5 ML 150 ML SURUP
ADVANTAN M LOSYON 50 GR
ADVANTAN S COZELTI %0,1 20 ML
AIRLAST 10 MG 28 FILM TABLET
EPORON 2000 IU/0,5 ML 
EPORON 4000 IU/0,4 ML 
EQIZOLIN- IM 500 MG 1 FLAKON
ERCEFURYL 200 MG/5 ML 60 ML SUSPANSIYON
FEIBA 500 U IV 
FELDEN % 0,5 50 GR JEL               ', NULL, 1, NULL, N'0                             ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'30.06.2022                    ')
SET IDENTITY_INSERT [dbo].[Hasta] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (11, N'15914718595', N'abdullah deneme          ', N'kalayci                  ', N'annnename                ', N'babaname                 ', N'konya               ', NULL, N'123456                        ', NULL, 2, -1, N'abdullah@ktun                 ', N'05255252525', N'e', 12)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (13, N'78945612323', N'Ahmet                    ', N'Söylemez                 ', N'ayşe                     ', N'mustafa                  ', N'istanbul            ', NULL, N'123                           ', NULL, 2, 5, N'ahmet@gmail.com               ', N'05475474747', N'e', 40)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (15, N'84631478974', N'hemşire                  ', NULL, NULL, NULL, NULL, NULL, N'123                           ', NULL, 2, NULL, NULL, NULL, N'k', 36)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (16, N'45278963214', N'admin                    ', NULL, NULL, NULL, NULL, NULL, N'123                           ', NULL, 0, NULL, NULL, NULL, N'e', 14)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (17, N'47521369541', N'doktor                   ', NULL, NULL, NULL, NULL, NULL, N'123                           ', NULL, 2, NULL, NULL, NULL, N'e', 2)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (18, N'33462173541', N'sekreter                 ', NULL, NULL, NULL, NULL, NULL, N'123                           ', NULL, 3, NULL, NULL, NULL, N'e', 78)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (19, N'44444444444', N'laborant                 ', NULL, NULL, NULL, NULL, NULL, N'123                           ', NULL, 4, NULL, NULL, NULL, N'e', 33)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (20, N'45403575328', N'ali                      ', N'filiz                    ', N'furkan                   ', N'amed                     ', N'şanlıurfa           ', NULL, N'123                           ', NULL, 2, -1, N'                              ', N'5412429013 ', N'e', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (24, N'151123165  ', N'ahmet                    ', N'asdasd                   ', N'asdas                    ', N'asdasd                   ', N'Konya               ', NULL, N'123                           ', NULL, 0, -1, N'sylmz7507                     ', N'1123123    ', N'e', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (38, N'78589658965', N'doktor2                  ', N'dr2                      ', N'anneadi                  ', N'babaadi                  ', N'konya               ', NULL, N'123                           ', NULL, 2, 3, N'eposta@deneme.com             ', N'5552255489 ', N'e', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (39, N'2222222221 ', N'sekreter1                ', N'sekrerte                 ', N'anneadi                  ', N'babaadi                  ', N'meram               ', NULL, N'123                           ', NULL, 3, 0, NULL, NULL, N'e', 12)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (40, N'12345678912', N'DENEME                   ', N'DENEME                   ', N'DENEME                   ', N'DENEME                   ', N'DENEME              ', NULL, N'DENEME                        ', NULL, 1, 4, N'DENEME@GMAİL.COM              ', N'5534595405 ', N'k', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (41, N'50515404992', N'deneme                   ', N'denme                    ', N'deneme                   ', N'deneme                   ', N'deneme              ', NULL, N'deneme                        ', NULL, 1, 4, N'deneme@gmail.com              ', N'5553459540 ', N'k', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (42, N'11111111111', N'deneme                   ', N'söylemez                 ', N'de                       ', N'de                       ', N'de                  ', NULL, N'denme                         ', NULL, 1, 4, N'e                             ', N'5553454565 ', N'k', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (43, N'22222222222', N'Sergen                   ', N'Deveci                   ', N'Aliye                    ', N'Mustafa                  ', N'Ankara              ', NULL, N'sergen42                      ', NULL, 1, 4, N'sergen@gmail.com              ', N'5555555555 ', N'e', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (44, N'33333333333', N'Aysel                    ', N'Süratli                  ', N'Merve                    ', N'Hasan                    ', N'İzmir               ', NULL, N'123                           ', NULL, 2, 0, N'aysel@gmail.com               ', N'5555555555 ', N'k', NULL)
INSERT [dbo].[Personel] ([P_ID], [P_tc], [P_adi], [P_s_adi], [P_anne_adi], [P_baba_adi], [P_d_yeri], [P_d_tarihi], [P_sifre], [P_yetki], [P_birim_ID], [P_klinik_ID], [P_eposta], [P_tel], [p_cinsiyet], [P_izingun]) VALUES (45, N'50519871341', N'Kerim                    ', N'Durmaz                   ', N'Fatma                    ', N'Halil                    ', N'Muş                 ', NULL, N'123                           ', NULL, 1, 12, N'kerim@gmail.com               ', N'5555555555 ', N'e', NULL)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Polikinlik] ON 

INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (1, NULL, N'KARDİYOLOJİ                   ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (2, NULL, N'Ağız Ve Diş Sağlığı           ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (3, NULL, N'Kulak Burun Boğaz             ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (4, NULL, N'Göğüs Hastalıkları            ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (5, NULL, N'Kalp Ve Damar Cerrahisi       ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (6, NULL, N'BEYİN VE SİNİR CERRAHİSİ      ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (7, NULL, N'ÇOCUK KARDİYOLOJİSİ           ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (8, NULL, N'DERMATOLOJİ (CİLDİYE)         ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (9, NULL, N'GENEL CERRAHİ                 ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (10, NULL, N'KADIN HASTALIKLARI VE DOĞUM   ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (11, NULL, N'NÖROLOJİ                      ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (12, NULL, N'PSİKİYATRİ                    ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (13, NULL, N'ÜROLOJİ                       ')
INSERT [dbo].[Polikinlik] ([Polik_ID], [Polik_d_ID], [Polik_adi]) VALUES (14, NULL, N'İÇ HASTALIKLARI               ')
SET IDENTITY_INSERT [dbo].[Polikinlik] OFF
GO
