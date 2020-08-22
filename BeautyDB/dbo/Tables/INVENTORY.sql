CREATE TABLE [dbo].[INVENTORY]
(
	[IDInvent] INT NOT NULL PRIMARY KEY IDENTITY,
	[RefInvent] [nvarchar](15) NULL,
	[DateInvent] [date] NULL,
	[DescriptInvent] [varchar](300) NULL,
	[StateInvent] [nchar](1) NULL,
)
