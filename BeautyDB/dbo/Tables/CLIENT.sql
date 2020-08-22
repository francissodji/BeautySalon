CREATE TABLE [dbo].[CLIENT]
(
	[IDClient] INT NOT NULL PRIMARY KEY IDENTITY,
	[FnameClient] [nvarchar](100) NOT NULL,
	[MnameClient] [nvarchar](50) NOT NULL,
	[LnameClient] [nvarchar](100) NOT NULL,
	[PhoneClient] [nvarchar](14) NULL,
	[DOBClient] [date] NULL,
	[CelClient] [nvarchar](14) NULL,
	[StreetClient] [nvarchar](100) NULL,
	[CountyClient] [nvarchar](50) NULL,
	[ZipCodeClient] [nvarchar](10) NULL,
	[EmailClient] [nvarchar](100) NULL,
	[IDUserClient] [int] NULL,
	[StateClient] [nchar](2) NULL,

	CONSTRAINT [FK_CLIENT_USERS] FOREIGN KEY([IDUserClient]) REFERENCES [dbo].[USERS] ([IDUser]),
)
