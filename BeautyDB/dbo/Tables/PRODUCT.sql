CREATE TABLE [dbo].[PRODUCT]
(
	[IDProd] INT NOT NULL PRIMARY KEY IDENTITY,
	[TitleProd] [nvarchar](100) NULL,
	[IDTypeProd] [int] NOT NULL,
	[RefProd] [nvarchar](30) NULL,
	[QtityStockAlert] [real] NULL,
	[QtityStockSecure] [real] NULL,
	[IsPrdtReturnable] [bit] NULL, 
    CONSTRAINT [FK_PRODUCT_TYPEPRODUCT] FOREIGN KEY ([IDTypeProd]) REFERENCES [TYPEPRODUCT]([IDTypeProd]) 
)
