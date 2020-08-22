CREATE PROCEDURE [dbo].[spStyle_ModifyStyle]
	@iDStyle int,
	@desigStyle nvarchar(100),
	@descriptStyle nvarchar(1000),
	@hairProvStyle bit,
	@costStyle money,
	@priceTakeOffHair money,
	@costTouchUp money,
	@pictureStyle nvarchar(300)
AS
Begin
	set nocount on;

	update STYLE set DesigStyle = @desigStyle, DescriptStyle = @descriptStyle,
	HairProvStyle = @hairProvStyle, CostStyle = @costStyle, PriceTakeOffHair = @priceTakeOffHair,
	CostTouchUp = @costTouchUp, PictureStyle = @pictureStyle where IDStyle = @iDStyle;
end
