CREATE TABLE [dbo].[EXTRATSTYLE]
(
	[IDExtratStyle] INT NOT NULL PRIMARY KEY IDENTITY,
	[IDStyle] [int] NOT NULL,
	[IDExtrat] [int] NOT NULL,
	[CostExtra] [money] NULL,
	[IdSize] [int] NULL,
	[CostTouchUpExtra] [money] NULL,
	[CostExtraSize] [money] NULL,
	[CostBusyExtra] [money] NULL,

    CONSTRAINT [FK_EXTRATSTYLE_STYLE] FOREIGN KEY (IDStyle) REFERENCES STYLE(IDStyle), 
    CONSTRAINT [FK_EXTRATSTYLE_EXTRAT] FOREIGN KEY (IDExtrat) REFERENCES EXTRAT(IDExtrat),
)
