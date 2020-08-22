CREATE TABLE [dbo].[SALES]
(
	[IDSale] INT NOT NULL PRIMARY KEY IDENTITY,
	[RefSale] [nvarchar](15) NOT NULL,
	[DateSale] [date] NULL,
	[IdJobDone] [int] NULL,
)
