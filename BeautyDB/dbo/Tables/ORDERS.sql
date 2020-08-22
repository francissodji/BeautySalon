CREATE TABLE [dbo].[ORDERS]
(
	[IDOrder] INT NOT NULL PRIMARY KEY IDENTITY,
	[IDVendor] [int] NOT NULL,
	[DateOrder] [datetime] NULL,
	[CategOrder] [nchar](2) NULL,
	CONSTRAINT [FK_ORDER_VENDOR] FOREIGN KEY([IDVendor]) REFERENCES [dbo].[VENDOR] ([IDVendor]),
)
