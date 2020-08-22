CREATE TABLE [dbo].[ADMCHARGEPAY]
(
	[IdAdmchargePay] INT NOT NULL PRIMARY KEY IDENTITY,
	[IdAdmcharge] [int] NOT NULL,
	[CostChargePay] [money] NULL,
	[DatePayment] [date] NULL,
	[IdTypeOperat] [int] NULL,
	CONSTRAINT [FK_ADMCHARGEPAY_ADMCHARGE] FOREIGN KEY([IdAdmcharge]) REFERENCES [dbo].[ADMCHARGE] ([IdAdmcharge]),
)
