CREATE TABLE [dbo].[APPOINTMENT]
(
	[IDAppoint] INT NOT NULL PRIMARY KEY IDENTITY,
	[IDClientAppoint] [int] NOT NULL,
	[IDStyleAppoint] [int] NOT NULL,
	[IDLenghtstyle] [int] NULL,
	[DateAppoint] [date] NOT NULL,
	[BeginTimeAppoint] [time](6) NULL,
	[AddTakeOffAppoint] [bit] NULL,
	[StateAppoint] [nchar](1) NULL,
	[Typeservice] [nchar](1) NULL,
	[NumberTrack] [int] NULL,
	[IDBraiderAppoint] [int] NULL,
	[IdSizeAppoint] [int] NULL,
	IdBraiderOwner [int] NULL,
	
	CONSTRAINT [FK_APPOINTMENT_CLIENT] FOREIGN KEY([IDClientAppoint]) REFERENCES [dbo].[CLIENT] ([IDClient]),
	CONSTRAINT [FK_APPOINTMENT_STYLE] FOREIGN KEY([IDStyleAppoint]) REFERENCES [dbo].[STYLE] ([IDStyle]),
)
