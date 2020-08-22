CREATE PROCEDURE [dbo].[spStyle_GetListStyle]

AS
Begin
	set nocount on;

	select IDStyle,DesigStyle,DescriptStyle,HairProvStyle,CostStyle,CostTouchUp,PriceTakeOffHair,PictureStyle
	from STYLE
End

