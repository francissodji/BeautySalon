CREATE TABLE [dbo].[DISCOUNT]
(
	[IDDiscount] INT NOT NULL IDENTITY PRIMARY KEY,
	[TitleDiscount] [nvarchar](75) NULL,
	[RateDiscount] [real] NULL,
	[CostDiscount] [money] NULL,
)
