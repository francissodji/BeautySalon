CREATE TABLE [dbo].[JOBDONE]
(
	[IDJobDone] INT NOT NULL PRIMARY KEY IDENTITY,
	[IDAppoint] [int] NOT NULL,
	[DateJobDone] [date] NULL,
	[BegintimeJob] [time](6) NULL,
	[TimeEndJob] [time](6) NULL,
	[Directfeedback] [nvarchar](300) NULL,
	[IDStyleJob] [int] NULL,
	[TypeserviceJob] [nchar](1) NULL,
	[AddTakeoffJob] [bit] NULL,
	[IDDiscount] [int] NULL,
	[IdExtraJobDone] [int] NULL,
	[ClientBehaviourNote] [nvarchar](1000) NULL,
	[IdBraiderOwnerRelate] [int] NULL,
	[NumberTrackJobDone] [int] NULL,
	[IdClientRelative] [int] NULL,
	[IdSizeJob] [int] NULL,

    CONSTRAINT [FK_JOBDONE_APPOINTMENT] FOREIGN KEY([IDAppoint]) REFERENCES [dbo].[APPOINTMENT] ([IDAppoint]),
	CONSTRAINT [FK_JOBDONE_DISCOUNT] FOREIGN KEY([IDDiscount]) REFERENCES [dbo].[DISCOUNT] ([IDDiscount]),
)
