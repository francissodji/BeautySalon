CREATE PROCEDURE [dbo].[spStyle_AddStyle]
	@desigStyle nvarchar(100),
	@descriptStyle nvarchar(1000),
	@hairProvStyle bit,
	@costStyle money,
	@priceTakeOffHair money,
	@costTouchUp money,
	@ChargeType nchar(2),
	@TimeDoneStyle float,
	@ModifyCostManu bit,
	@CostHairDeducted money,
	@PictureStyle nvarchar(300)
AS
Begin
	set nocount on;

	insert into STYLE(DesigStyle, DescriptStyle, HairProvStyle,
	CostStyle, PriceTakeOffHair, CostTouchUp, ChargeType, TimeDoneStyle,
	ModifyCostManu, CostHairDeducted, PictureStyle)
    values(@desigStyle,@descriptStyle,@hairProvStyle,@costStyle,
	@priceTakeOffHair,@costTouchUp, @ChargeType, @TimeDoneStyle,
	@ModifyCostManu, @CostHairDeducted, @PictureStyle);
end
