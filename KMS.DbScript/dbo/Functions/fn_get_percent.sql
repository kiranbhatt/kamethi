Create function [dbo].[fn_get_percent](@totalamount int, @percentage int )
returns float
begin
declare @Value float
select @Value= (@percentage * @totalamount)/100
return @Value
end

