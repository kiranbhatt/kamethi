

create function [dbo].[fn_get_attendance](@monthlyinstallment int )
returns float
begin
declare @Value bit
if(@monthlyinstallment !=null)

BEGIN

SET @Value = 1

END
ELSE

BEGIN

SET @Value = 0

END

return @Value
end
