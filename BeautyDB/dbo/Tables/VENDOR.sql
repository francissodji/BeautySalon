CREATE TABLE [dbo].[VENDOR]
(
	[IDVendor] INT NOT NULL PRIMARY KEY IDENTITY,
	[TitleVendor] [nvarchar](100) NOT NULL,
	[PhoneOffice] [nvarchar](14) NULL,
	[PhoneCell] [nvarchar](14) NULL,
	[StreetVendor] [nvarchar](100) NULL,
	[CountyVendor] [varchar](50) NULL,
	[ZipCodeVendor] [varchar](10) NULL,
	[StateVendor] [char](2) NULL,
	[EmailVendor] [nvarchar](100) NULL,
	[WebSiteVendor] [nvarchar](100) NULL,
)