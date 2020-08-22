CREATE TABLE [dbo].[USERS]
(
	[IDUser] INT NOT NULL PRIMARY KEY IDENTITY,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](100) NULL,
	[Idprofil] [tinyint] NULL,
	[Dateuserexpire] [date] NULL,
	[Connectstate] [bit] NULL,
)