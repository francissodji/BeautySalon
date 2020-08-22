CREATE TABLE [dbo].[REGISTERTRANSF]
(
	[IDRegistTransf] INT NOT NULL PRIMARY KEY IDENTITY,
	[DateTransf] [date] NULL,
	[AmountTransf] [money] NULL,
	[IDRegisterSender] [int] NULL,
	[IDRegisterReceiver] [int] NULL,
	CONSTRAINT [FK_REGISTERTRANSF_REGISTER] FOREIGN KEY([IDRegisterSender]) REFERENCES [dbo].[REGISTER] ([IDRegister]),
	CONSTRAINT [FK_REGISTERTRANSF_REGISTERREC] FOREIGN KEY([IDRegisterReceiver]) REFERENCES [dbo].[REGISTER] ([IDRegister]),
)
