CREATE TABLE [dbo].[OPERATION]
(
	[IDOperat] INT NOT NULL PRIMARY KEY IDENTITY,
	[IDTransact] [int] NULL,
	[DateOperat] [date] NULL,
	[CostOperat] [money] NULL,
	[IdTypeOperat] [int] NOT NULL,
	[IdRegistOperat] [tinyint] NULL,
	[CodModPaie] [nchar](3) NULL,
	[CancelOperat] [bit] NULL,
	[OrderDayOperat] [int] NULL,
	[DescripOperat] [nvarchar](300) NULL,
	CONSTRAINT [FK_OPERATION_TYPEOPERATION] FOREIGN KEY([IdTypeOperat]) REFERENCES [dbo].[TYPEOPERATION] ([IDTypeOperat]),
)