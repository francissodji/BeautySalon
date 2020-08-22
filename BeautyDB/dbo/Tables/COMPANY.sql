CREATE TABLE [dbo].[COMPANY]
(
	[IDComp] INT NOT NULL PRIMARY KEY IDENTITY,
	[AcronymComp] [nvarchar](10) NULL,
	[TitleComp] [nvarchar](150) NULL,
	[PhoneOffice] [nvarchar](20) NULL,
	[PhoneOwner] [nvarchar](20) NULL,
	[StreetComp] [nvarchar](100) NULL,
	[CountyComp] [nvarchar](50) NULL,
	[ZipcodeComp] [nvarchar](10) NULL,
	[PartPayeBraid] [real] NULL,
	[IDOwnerBraider] [int] NULL,
	[CostHairDeduct] [money] NULL,
	[PriceTakeOff] [money] NULL,
	[IdMainRegister] [int] NULL,
	[StateTaxOnSale] [real] NULL,
	[StateTaxOnBraiding] [real] NULL,
	[StateCompany] [nchar](2) NULL,
	[EmailComp] [nvarchar](100) NULL,
	[WebsiteComp] [nvarchar](100) NULL,
	[CreationDate] DATE NULL, 
    CONSTRAINT [FK_COMPANY_REGISTER] FOREIGN KEY([IdMainRegister]) REFERENCES [dbo].[REGISTER] ([IDRegister])
)
