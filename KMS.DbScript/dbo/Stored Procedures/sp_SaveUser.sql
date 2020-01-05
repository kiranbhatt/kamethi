CREATE PROCEDURE [dbo].[sp_SaveUser] -- Add the parameters for the stored procedure here
  @UserName nvarchar(50), 
  @Email nvarchar(50), 
  @Password nvarchar(50), 
  @Role nchar(10), 
  @CreatedDate datetime = NULL, 
  @ModifiedDate datetime = NULL, 
  @IsActive bit = NULL, 
  @DateOfBirth date = null, 
  @PrimaryPhone nvarchar(50), 
  @SecondaryPhone nvarchar(50), 
  @CurrentState nvarchar(50), 
  @CurrentCity nvarchar(50), 
  @CurrentAddress nvarchar(50), 
  @IsAddressSame bit = null, 
  @PermanentState nvarchar(50), 
  @PermanentCity nvarchar(50), 
  @PermanentAddress nvarchar(50), 
  @AadhaarNumber bigint, 
  @PanCardNumber nvarchar(50), 
  @UploadAadhaar nvarchar(max), 
  @UploadPanCard nvarchar(max) = NULL 
  
  AS BEGIN -- SET NOCOUNT ON added to prevent extra result sets from
  -- interfering with SELECT statements.
SET 
  NOCOUNT ON;
-- Insert statements for procedure here
INSERT INTO [dbo].[User] (
  [UserName], [Email], [Password], [Role], 
  [CreatedDate], [ModifiedDate], [IsActive], 
  [DateOfBirth], [PrimaryPhone], [SecondaryPhone], 
  [CurrentState], [CurrentCity], [CurrentAddress], 
  [IsAddressSame], [PermanentState], 
  [PermanentCity], [PermanentAddress], 
  [AadhaarNumber], [PanCardNumber], 
  [UploadAadhaar], [UploadPanCard]
) 
VALUES 
  (
    @UserName, 
    @Email, 
    @Password, 
    @Role, 
    GETDATE(), 
    @ModifiedDate, 
    @IsActive, 
    @DateOfBirth, 
    @PrimaryPhone, 
    @SecondaryPhone, 
    @CurrentState, 
    @CurrentCity, 
    @CurrentAddress, 
    @IsAddressSame, 
    @PermanentState, 
    @PermanentCity, 
    @PermanentAddress, 
    @AadhaarNumber, 
    @PanCardNumber, 
    @UploadAadhaar, 
    @UploadPanCard
  ) END

