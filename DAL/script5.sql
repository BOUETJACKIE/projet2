USE [master]
GO
/****** Object:  Database [BoVoyage]    Script Date: 15/06/2018 17:03:28 ******/
CREATE DATABASE [BoVoyage]

GO
ALTER DATABASE [BoVoyage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BoVoyage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BoVoyage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BoVoyage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BoVoyage] SET ARITHABORT OFF 
GO
ALTER DATABASE [BoVoyage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BoVoyage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BoVoyage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BoVoyage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BoVoyage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BoVoyage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BoVoyage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BoVoyage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BoVoyage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BoVoyage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BoVoyage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BoVoyage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BoVoyage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BoVoyage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BoVoyage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BoVoyage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BoVoyage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BoVoyage] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BoVoyage] SET  MULTI_USER 
GO
ALTER DATABASE [BoVoyage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BoVoyage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BoVoyage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BoVoyage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BoVoyage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BoVoyage] SET QUERY_STORE = OFF
GO
USE [BoVoyage]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BoVoyage]
GO
/****** Object:  Table [dbo].[Agences]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agences](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Adresse] [varchar](100) NOT NULL,
	[Telephone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Agences] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assurances]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assurances](
	[Id] [int] NOT NULL,
	[designation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Assurances] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Civilite] [char](4) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Prenom] [varchar](50) NOT NULL,
	[Adresse] [varchar](100) NOT NULL,
	[Telephone] [varchar](20) NOT NULL,
	[DateNaissance] [datetime] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinations]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Continent] [varchar](50) NOT NULL,
	[Pays] [varchar](50) NOT NULL,
	[Region] [varchar](50) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Destinations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DossierReservations]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DossierReservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdParticipant] [int] NOT NULL,
	[IdVoyage] [int] NOT NULL,
	[IdAssurance] [int] NOT NULL,
	[IdClient] [int] NOT NULL,
	[NumeroCB] [varchar](50) NOT NULL,
	[Etat] [tinyint] NOT NULL,
 CONSTRAINT [PK_DossierReservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participants]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participants](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Civilite] [char](4) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Prenom] [varchar](50) NOT NULL,
	[Adresse] [varchar](100) NOT NULL,
	[Telephone] [varchar](20) NOT NULL,
	[DateNaissance] [datetime] NOT NULL,
	[Reduction] [float] NOT NULL,
 CONSTRAINT [PK_Participants] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voyages]    Script Date: 15/06/2018 17:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voyages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAgence] [int] NOT NULL,
	[IdDestination] [int] NOT NULL,
	[DateAller] [datetime] NOT NULL,
	[DateRetour] [datetime] NOT NULL,
	[PlacesDispo] [int] NOT NULL,
	[TarifToutCompris] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Voyages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Agences] ON 

INSERT [dbo].[Agences] ([Id], [Nom], [Adresse], [Telephone]) VALUES (1, N'ClubMed', N'50 rue jeanne d''arc 76000 Rouen', N'0235565958')
INSERT [dbo].[Agences] ([Id], [Nom], [Adresse], [Telephone]) VALUES (2, N'FramVoyage', N'21 rue sainte anne 75008 paris', N'0145478589')
INSERT [dbo].[Agences] ([Id], [Nom], [Adresse], [Telephone]) VALUES (3, N'TerreInconnue', N'12 bd de l''iser 76000 Rouen', N'0232968574')
INSERT [dbo].[Agences] ([Id], [Nom], [Adresse], [Telephone]) VALUES (4, N'MscCroisière', N'159 av des chaùmps elysée 75008 paris', N'0175321598')
SET IDENTITY_INSERT [dbo].[Agences] OFF
INSERT [dbo].[Assurances] ([Id], [designation]) VALUES (1, N'ToutRisque')
INSERT [dbo].[Assurances] ([Id], [designation]) VALUES (2, N'Annulation')
INSERT [dbo].[Assurances] ([Id], [designation]) VALUES (3, N'Annulation')
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (1, N'jackiebouet@hotmail.fr', N'Mme ', N'bouet', N'jackie', N'168 rue sainte anne 76116 saint aignan sur ry', N'0611874499', CAST(N'1976-10-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (2, N'francejour@sfr.com', N'Mme ', N'jour', N'france', N'5 rue rollon 76000 rouen', N'0235897810', CAST(N'1983-08-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (3, N'chauvela@gmail.com', N'M   ', N'chauvel', N'antoine', N'8 chemin des bruyères 14310 croissanville', N'0231807430', CAST(N'1975-10-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (5, N'rrr@ppp.com', N'M   ', N'TUTU', N'Dédé', N'eee', N'0612345678', CAST(N'2018-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (7, N'rrr@ppp.com', N'M   ', N'GGGG', N'Dédé', N'eee', N'0612345678', CAST(N'2018-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (10, N'rrr@ppp.com', N'M   ', N'TOTOTO', N'Dédé', N'eee', N'0612345678', CAST(N'2018-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (11, N'rrr@ppp.com', N'Mme ', N'POPOPO', N'Dédé', N'eee', N'0612345678', CAST(N'2018-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (12, N'rrr@ppp.com', N'Mme ', N'POPOPO', N'Dédé', N'eee', N'0612345678', CAST(N'2018-06-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (13, N'rrr@ppp.com', N'M   ', N'123 rua abcd', N'Dédé', N'123 rua abcd', N'0612345678', CAST(N'2002-02-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (14, N'13246578', N'Mme ', N'POPO', N'Momu', N'132 rue abc', N'13246578', CAST(N'2003-02-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (15, N'123', N'Mme ', N'rr', N'e', N'132', N'123', CAST(N'2000-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Email], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance]) VALUES (16, N'ttttttttttttttttttttttttttttttt', N'Mme ', N'POPO', N'Lulu', N'12345 iuyrz ciubfy', N'12345', CAST(N'2004-02-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Destinations] ON 

INSERT [dbo].[Destinations] ([Id], [Continent], [Pays], [Region], [Description]) VALUES (1, N'Asie', N'Cambodge', N'Doda', N'Découvrez Angkor Vat et ses environs')
INSERT [dbo].[Destinations] ([Id], [Continent], [Pays], [Region], [Description]) VALUES (3, N'Afrique', N'Mali', N'Forest', N'Une virée dans le désert Malien')
INSERT [dbo].[Destinations] ([Id], [Continent], [Pays], [Region], [Description]) VALUES (4, N'Europe', N'France', N'Corse', N'Une randonée à travers le célèbre GR20')
INSERT [dbo].[Destinations] ([Id], [Continent], [Pays], [Region], [Description]) VALUES (5, N'Amérique', N'Paraguay', N'Terranova', N'Découvrez Asuncion ses environs')
SET IDENTITY_INSERT [dbo].[Destinations] OFF
SET IDENTITY_INSERT [dbo].[DossierReservations] ON 

INSERT [dbo].[DossierReservations] ([Id], [IdParticipant], [IdVoyage], [IdAssurance], [IdClient], [NumeroCB], [Etat]) VALUES (3, 2, 1, 1, 1, N'1254896532565', 0)
INSERT [dbo].[DossierReservations] ([Id], [IdParticipant], [IdVoyage], [IdAssurance], [IdClient], [NumeroCB], [Etat]) VALUES (7, 4, 2, 1, 2, N'1568744354351354', 0)
SET IDENTITY_INSERT [dbo].[DossierReservations] OFF
SET IDENTITY_INSERT [dbo].[Participants] ON 

INSERT [dbo].[Participants] ([Id], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance], [Reduction]) VALUES (2, N'Mlle', N'Mathis', N'Eva', N'9 rue du champs des oiseaux 76000 rouen', N'0612457865', CAST(N'2006-10-19T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Participants] ([Id], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance], [Reduction]) VALUES (4, N'M   ', N'Mathis', N'Patrick', N'9 rue du champs des oiseaux 76000 rouen ', N'0656893179', CAST(N'1966-12-26T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Participants] ([Id], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance], [Reduction]) VALUES (6, N'M   ', N'Cayeux', N'Paul', N'8 route du soleil 83650 sainte croix', N'0620634690', CAST(N'2004-03-10T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Participants] ([Id], [Civilite], [Nom], [Prenom], [Adresse], [Telephone], [DateNaissance], [Reduction]) VALUES (8, N'M   ', N'Cayeux', N'Damien', N'8 route du soleil 83650 sainte croix', N'0745783056', CAST(N'1980-04-29T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Participants] OFF
SET IDENTITY_INSERT [dbo].[Voyages] ON 

INSERT [dbo].[Voyages] ([Id], [IdAgence], [IdDestination], [DateAller], [DateRetour], [PlacesDispo], [TarifToutCompris]) VALUES (1, 1, 1, CAST(N'2018-12-21T00:00:00.000' AS DateTime), CAST(N'2018-12-28T00:00:00.000' AS DateTime), 5, CAST(650 AS Decimal(18, 0)))
INSERT [dbo].[Voyages] ([Id], [IdAgence], [IdDestination], [DateAller], [DateRetour], [PlacesDispo], [TarifToutCompris]) VALUES (2, 2, 1, CAST(N'2018-09-15T00:00:00.000' AS DateTime), CAST(N'2018-05-24T00:00:00.000' AS DateTime), 9, CAST(500 AS Decimal(18, 0)))
INSERT [dbo].[Voyages] ([Id], [IdAgence], [IdDestination], [DateAller], [DateRetour], [PlacesDispo], [TarifToutCompris]) VALUES (3, 2, 4, CAST(N'2018-07-25T00:00:00.000' AS DateTime), CAST(N'2018-07-30T00:00:00.000' AS DateTime), 12, CAST(300 AS Decimal(18, 0)))
INSERT [dbo].[Voyages] ([Id], [IdAgence], [IdDestination], [DateAller], [DateRetour], [PlacesDispo], [TarifToutCompris]) VALUES (11, 3, 3, CAST(N'2018-08-22T00:00:00.000' AS DateTime), CAST(N'2018-08-31T00:00:00.000' AS DateTime), 2, CAST(700 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Voyages] OFF
ALTER TABLE [dbo].[DossierReservations]  WITH CHECK ADD  CONSTRAINT [FK_DossierReservations_Assurance] FOREIGN KEY([IdAssurance])
REFERENCES [dbo].[Assurances] ([Id])
GO
ALTER TABLE [dbo].[DossierReservations] CHECK CONSTRAINT [FK_DossierReservations_Assurance]
GO
ALTER TABLE [dbo].[DossierReservations]  WITH CHECK ADD  CONSTRAINT [FK_DossierReservations_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[DossierReservations] CHECK CONSTRAINT [FK_DossierReservations_Client]
GO
ALTER TABLE [dbo].[DossierReservations]  WITH CHECK ADD  CONSTRAINT [FK_DossierReservations_Participant] FOREIGN KEY([IdParticipant])
REFERENCES [dbo].[Participants] ([Id])
GO
ALTER TABLE [dbo].[DossierReservations] CHECK CONSTRAINT [FK_DossierReservations_Participant]
GO
ALTER TABLE [dbo].[DossierReservations]  WITH CHECK ADD  CONSTRAINT [FK_DossierReservations_Voyage] FOREIGN KEY([IdVoyage])
REFERENCES [dbo].[Voyages] ([Id])
GO
ALTER TABLE [dbo].[DossierReservations] CHECK CONSTRAINT [FK_DossierReservations_Voyage]
GO
ALTER TABLE [dbo].[Voyages]  WITH CHECK ADD  CONSTRAINT [FK_Voyages_Agence] FOREIGN KEY([IdAgence])
REFERENCES [dbo].[Agences] ([Id])
GO
ALTER TABLE [dbo].[Voyages] CHECK CONSTRAINT [FK_Voyages_Agence]
GO
ALTER TABLE [dbo].[Voyages]  WITH CHECK ADD  CONSTRAINT [FK_Voyages_Destinations] FOREIGN KEY([IdDestination])
REFERENCES [dbo].[Destinations] ([Id])
GO
ALTER TABLE [dbo].[Voyages] CHECK CONSTRAINT [FK_Voyages_Destinations]
GO
USE [master]
GO
ALTER DATABASE [BoVoyage] SET  READ_WRITE 
GO
