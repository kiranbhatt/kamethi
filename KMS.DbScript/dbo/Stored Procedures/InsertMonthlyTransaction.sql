CREATE PROCEDURE [dbo].[InsertMonthlyTransaction] 
   
@MonthlyTransaction MonthlyTransactionType READONLY,
@KamethiNumber nvarchar(150),
@HostId int,
@TotalTakenAmount bigint,
@TotalDepositAmount bigint,
@RemainingBalance bigint
            
AS
   SET NOCOUNT ON;
  

   BEGIN TRY

    BEGIN TRANSACTION;

   INSERT INTO [dbo].[MonthlyTransaction]
           (
            [UserId]
           ,[Monthly Installment]
           ,[Taken Amount]
           ,[Given Amount]
           ,[Deposit Amount]
           ,[Balance Amount])

   SELECT * FROM @MonthlyTransaction 





Declare @TotalInterest float   
SET  @TotalInterest =  [dbo].[fn_get_percent] (@TotalTakenAmount,1)

Declare @TotalMembers int
SELECT @TotalMembers = count(UserId) FROM @MonthlyTransaction

Declare @PerHeadInterest float   
SET  @PerHeadInterest =  [dbo].[fn_get_perheadinterest] (@TotalInterest,@TotalMembers)
   

INSERT INTO [dbo].[MonthlyTransactionSummary]
           
           ([Kamethi Number]
           ,[HostId]
           ,[Total Taken Amount]
           ,[Total Deposit Amount]
           ,[Remaining Balance]
           ,[Total Interest]
           ,[PerHead Interest])
     VALUES
           (@KamethiNumber,
            @HostId,
            @TotalTakenAmount,
            @TotalDepositAmount,
            @RemainingBalance, 
            @TotalInterest,
            @PerHeadInterest)



DECLARE @TransationId BIGINT
SELECT @TransationId=  @@IDENTITY 



 INSERT INTO [dbo].[MonthlyAttendance]

           ([TransationId]
           ,[MemberId]
           ,[IsPresent])

select @TransationId, UserId, dbo.fn_get_attendance(MonthlyInstallment) from @MonthlyTransaction


   COMMIT TRANSACTION;  

   END TRY
   BEGIN CATCH

    SELECT  
            ERROR_NUMBER() AS ErrorNumber  
            ,ERROR_SEVERITY() AS ErrorSeverity  
            ,ERROR_STATE() AS ErrorState  
            ,ERROR_PROCEDURE() AS ErrorProcedure  
            ,ERROR_LINE() AS ErrorLine  
            ,ERROR_MESSAGE() AS ErrorMessage;

   ROLLBACK TRANSACTION
   END CATCH

