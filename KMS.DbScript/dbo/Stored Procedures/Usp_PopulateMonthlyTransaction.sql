-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Usp_PopulateMonthlyTransaction
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT A.UserId, A.UserName,A.Email,A.PrimaryPhone,A.UploadAadhaar,A.IsActive , B.[Balance Amount] from	(select *  from [User]) A

					LEFT OUTER JOIN


						 (select UserId, [Balance Amount] from MonthlyTransaction
						 WHERE  (DATEPART(M, DATEADD(M, 0, dbo.MonthlyTransaction.CreatedDate)) =
                             (SELECT        DATEPART(M, DATEADD(M, - 1, GETDATE())) ))) B

							 ON A.UserId= B.UserId
END