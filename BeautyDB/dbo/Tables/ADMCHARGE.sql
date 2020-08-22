
CREATE TABLE [dbo].[ADMCHARGE]
(
	[IdAdmcharge] INT NOT NULL PRIMARY KEY IDENTITY,
	[IdPartener] [int] NOT NULL,
	[CostCharge] [money] NULL,
	[DateCharge] [date] NULL,
	[DescriptCharge] [varchar](300) NULL,
	CONSTRAINT [FK_ADMCHARGE_PARTNERS] FOREIGN KEY([IdPartener]) REFERENCES [dbo].[PARTNERS] ([IdPartener])
)
