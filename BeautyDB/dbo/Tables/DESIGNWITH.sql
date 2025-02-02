﻿CREATE TABLE [dbo].[DESIGNWITH]
(
	[IDDesignWith] INT NOT NULL PRIMARY KEY IDENTITY,
	[IDStyle] [int] NOT NULL,
	[IDHair] [int] NOT NULL,

	CONSTRAINT [FK_DESIGNWITH_HAIR] FOREIGN KEY([IDHair]) REFERENCES [dbo].[HAIR] ([IDHair]),
	CONSTRAINT [FK_DESIGNWITH_STYLE] FOREIGN KEY([IDStyle]) REFERENCES [dbo].[STYLE] ([IDStyle]),
)
