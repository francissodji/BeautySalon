CREATE TABLE [dbo].[STYLE]
(
	[IDStyle] INT NOT NULL PRIMARY KEY IDENTITY,
	[DesigStyle] nvarchar(100) NOT NULL,
	[DescriptStyle] nvarchar(1000) NOT NULL,
	[HairProvStyle] bit NULL,
	[CostStyle] money NULL,
	[PictureStyle] nvarchar(300) NULL,
	[PriceTakeOffHair] money NULL,
	[CostTouchUp] money NULL,
	[ImageStyle] VARBINARY(MAX),
)
