
CREATE PROCEDURE [dbo].spDiscount_GetListDiscount

AS
BEGIN
	set nocount on;

	select IDDiscount,TitleDiscount, RateDiscount, CostDiscount 
	from dbo.DISCOUNT;
END