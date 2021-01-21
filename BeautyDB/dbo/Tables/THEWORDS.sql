CREATE TABLE [dbo].[THEWORDS]
(
	[IDPassword] INT NOT NULL IDENTITY PRIMARY KEY,
	[IDUser] [int] NOT NULL,
	[UserPassword] [nvarchar](1000) NULL,
	[NumConnection] [int] NULL,
	[DateBeginPw] [date] NULL,
	[DateEndPw] [date] NULL,

	CONSTRAINT [FK_THEWORDS_USERS] FOREIGN KEY (IDUser) REFERENCES USERS(IDUser), 
)
