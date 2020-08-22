CREATE PROCEDURE [dbo].[spStyle_GetInfoStyleByTile]
	@DesigStyle varchar(100)
AS
Begin
	set nocount on;

	select IDStyle,DesigStyle,DescriptStyle,HairProvStyle,CostStyle,CostTouchUp,PriceTakeOffHair,ImageStyle
	from STYLE where DesigStyle = @DesigStyle
End
