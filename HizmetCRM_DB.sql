/****** Object:  View [dbo].[Hizmetcrm_FormView]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Hizmetcrm_FormView]
AS
SELECT        dbo.HizmetCRM_Kategori.KategoriID, dbo.HizmetCRM_Kategori.Ad, dbo.HizmetCRM_AnaKategori.AnaAd, dbo.HizmetCRM_Kategori.IsActive
FROM            dbo.HizmetCRM_Kategori INNER JOIN
                         dbo.HizmetCRM_AnaKategori ON dbo.HizmetCRM_Kategori.AnaKategoriID = dbo.HizmetCRM_AnaKategori.AnaKategoriID

GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_AnaKategori]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_AnaKategori](
	[AnaKategoriID] [int] IDENTITY(1,1) NOT NULL,
	[AnaAd] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_AnaKategori] PRIMARY KEY CLUSTERED 
(
	[AnaKategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_Kategori]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_Kategori](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[AnaKategoriID] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_Kategori] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_Kullanicilar]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_Kullanicilar](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](150) NULL,
	[KullaniciAdi] [nvarchar](150) NULL,
	[Sifre] [nvarchar](150) NULL,
	[AnaKullanici] [bit] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_Personel]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_Personel](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_ServisOlumlu]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_ServisOlumlu](
	[ServisOlumluID] [int] IDENTITY(1,1) NOT NULL,
	[AnketID] [int] NULL,
	[ServisID] [int] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_ServisOlumlu] PRIMARY KEY CLUSTERED 
(
	[ServisOlumluID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_ServisOlumsuz]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_ServisOlumsuz](
	[ServisOlumsuzID] [int] IDENTITY(1,1) NOT NULL,
	[AnketID] [int] NULL,
	[ServisID] [int] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_ServisOlumsuz] PRIMARY KEY CLUSTERED 
(
	[ServisOlumsuzID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_Subeler]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_Subeler](
	[SubeID] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriMemnuniyeti_YeniAnket]    Script Date: 24/09/2022 15:14:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriMemnuniyeti_YeniAnket](
	[AnketID] [int] IDENTITY(1,1) NOT NULL,
	[AnketTarih] [nvarchar](10) NULL,
	[AramaTarih] [nvarchar](10) NULL,
	[Numara] [nvarchar](50) NULL,
	[AdSoyad] [nvarchar](150) NULL,
	[Meslek] [nvarchar](150) NULL,
	[SubeID] [int] NULL,
	[PersonID] [int] NULL,
	[HizmetID] [int] NULL,
	[CepTlf] [nvarchar](150) NULL,
	[SabitTlf] [nvarchar](150) NULL,
	[Adres] [nvarchar](250) NULL,
	[Eposta] [nvarchar](150) NULL,
	[DogumTarihi] [nvarchar](10) NULL,
	[Dogum] [bit] NULL,
	[DogumAy] [tinyint] NULL,
	[DogumGun] [tinyint] NULL,
	[EvlilikTarihi] [nvarchar](10) NULL,
	[Evlilik] [bit] NULL,
	[EvlilikAy] [tinyint] NULL,
	[EvlilikGun] [tinyint] NULL,
	[AnketYorumu] [nvarchar](500) NULL,
	[AnketRaporu] [nvarchar](500) NULL,
	[GorusmeSonucu] [nvarchar](50) NULL,
	[UlasimSecenegi] [nvarchar](50) NULL,
	[KullaniciID] [int] NULL,
	[EklemeTarihi] [datetime] NULL,
	[DuzenleID] [int] NULL,
	[DuzenlemeTarih] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_MusteriMemnuniyeti_YeniAnket] PRIMARY KEY CLUSTERED 
(
	[AnketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_AnaKategori] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_AnaKategori_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_Kategori] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_Kategori_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_Kullanicilar] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_Kullanicilar_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_Personel] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_Personel_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_Subeler] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_Subeler_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_YeniAnket] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_YeniAnket_Dogum]  DEFAULT ((0)) FOR [Dogum]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_YeniAnket] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_YeniAnket_Evlilik]  DEFAULT ((0)) FOR [Evlilik]
GO
ALTER TABLE [dbo].[MusteriMemnuniyeti_YeniAnket] ADD  CONSTRAINT [DF_MusteriMemnuniyeti_YeniAnket_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[29] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "HizmetCRM_Kategori"
            Begin Extent = 
               Top = 6
               Left = 214
               Bottom = 136
               Right = 384
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "HizmetCRM_AnaKategori"
            Begin Extent = 
               Top = 1
               Left = 34
               Bottom = 132
               Right = 197
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Hizmetcrm_FormView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Hizmetcrm_FormView'
GO
