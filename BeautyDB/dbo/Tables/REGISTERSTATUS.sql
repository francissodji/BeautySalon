CREATE TABLE [dbo].[REGISTERSTATUS]
(
	[IdRegisterStatus] INT NOT NULL PRIMARY KEY IDENTITY,
	[DateStatus] [date] NULL,
	[TheoryBalance] [money] NULL,
	[PhysicalBalance] [money] NULL,
	[StateRegister] [nchar](1) NULL,
	[IdRegister] [int] NULL,
	CONSTRAINT [FK_REGISTERSTATUS_REGISTER] FOREIGN KEY([IdRegister]) REFERENCES [dbo].[REGISTER] ([IDRegister]),
)
