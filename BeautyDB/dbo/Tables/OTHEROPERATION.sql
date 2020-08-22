CREATE TABLE [dbo].[OTHEROPERATION]
(
	[IdOtherOperat] INT NOT NULL PRIMARY KEY IDENTITY,
	[CostOtherOperat] [money] NULL,
	[DateOtherOperat] [date] NULL,
	[IdRegOtherOperat] [int] NULL,
	[IdTypeOperat] INT NULL, 
    [IdJobDone] INT NULL, 
    CONSTRAINT [FK_OTHEROPERATION_REGISTER] FOREIGN KEY([IdRegOtherOperat]) REFERENCES [dbo].[REGISTER] ([IDRegister])
)
