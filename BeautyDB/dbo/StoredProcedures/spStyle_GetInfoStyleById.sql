CREATE PROCEDURE [dbo].[spStyle_GetInfoStyleById]
	@idStyle int
AS
Begin
	set nocount on;

	select IDStyle,DesigStyle,DescriptStyle,HairProvStyle,CostStyle,CostTouchUp,PriceTakeOffHair,PictureStyle
	from STYLE where IDStyle = @idStyle
End

