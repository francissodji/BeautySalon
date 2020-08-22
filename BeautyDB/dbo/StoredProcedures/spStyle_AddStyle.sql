CREATE PROCEDURE [dbo].[spStyle_AddStyle]
	@desigStyle nvarchar(100),
	@descriptStyle nvarchar(1000),
	@hairProvStyle bit,
	@costStyle money,
	@priceTakeOffHair money,
	@costTouchUp money,
	@pictureStyle nvarchar(300),
	@imageStyle varbinary(max)
AS
Begin
	set nocount on;

	insert into STYLE(DesigStyle, DescriptStyle, HairProvStyle,
	CostStyle, PriceTakeOffHair, CostTouchUp, PictureStyle,ImageStyle)
    values(@desigStyle,@descriptStyle,@hairProvStyle,@costStyle,
	@priceTakeOffHair,@costTouchUp,@pictureStyle,@imageStyle);
end
