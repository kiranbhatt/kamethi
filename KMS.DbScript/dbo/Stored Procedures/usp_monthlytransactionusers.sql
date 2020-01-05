-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_monthlytransactionusers]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        dbo.[User].UserName, dbo.[User].UserId, dbo.MonthlyTransaction.[Monthly Installment], dbo.MonthlyTransaction.[Taken Amount], dbo.MonthlyTransaction.[Given Amount], dbo.MonthlyTransaction.[Deposit Amount], 
                         dbo.MonthlyTransaction.[Balance Amount]
FROM            dbo.[User] LEFT OUTER JOIN
                         dbo.MonthlyTransaction ON dbo.[User].UserId = dbo.MonthlyTransaction.UserId
END
