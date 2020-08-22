CREATE TABLE [dbo].[PARTNERS]
(
	[IdPartener] INT NOT NULL PRIMARY KEY IDENTITY,
	[TitlePartener] [nvarchar](100) NULL,
	[CelPartener] [nvarchar](20) NULL,
	[PhonePartener] [nvarchar](20) NULL,
	[StreetPartener] [nvarchar](100) NULL,
	[CountyPartener] [nvarchar](500) NULL,
	[StatePartener] [nchar](2) NULL,
	[EmailPartener] [nvarchar](100) NULL,
	[ZipCodePartener] [nvarchar](10) NULL,
)
