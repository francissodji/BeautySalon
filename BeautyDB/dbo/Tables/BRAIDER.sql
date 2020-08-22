CREATE TABLE [dbo].[BRAIDER]
(
	[IDBraider] INT NOT NULL PRIMARY KEY IDENTITY,
	[FnameBraider] [nvarchar](100) NOT NULL,
	[MnameBraider] [nvarchar](50) NULL,
	[LnameBraider] [nvarchar](100) NULL,
	[PhoneBraider] [nvarchar](14) NULL,
	[CelBraider] [nvarchar](14) NULL,
	[StreetBraider] [nvarchar](100) NULL,
	[CountyBraider] [nvarchar](50) NULL,
	[ZipCodeBraider] [nvarchar](10) NULL,
	[EmailBraider] [nvarchar](100) NULL,
	[IDUserBraider] [int] NULL,
	[OwnerStatus] [bit] NULL,
	[IsBraiderUseRegister] [bit] NULL,
	[IdRegisterBraider] [int] NULL,
	[StateBraider] [nchar](2) NULL,
	[DisplayRegister] [bit] NULL,

	CONSTRAINT [FK_BRAIDER_USERS] FOREIGN KEY([IDUserBraider]) REFERENCES [dbo].[USERS] ([IDUser])
)
