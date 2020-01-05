CREATE function [dbo].[fn_get_perheadinterest](@totalinterest int, @totalmembers int )
returns float
begin
declare @Value float
select @Value= (@totalinterest)/@totalmembers
return @Value
end
