CREATE TABLE [dbo].[User] (
    [UserId]           INT            IDENTITY (1, 1) NOT NULL,
    [UserName]         NVARCHAR (50)  NOT NULL,
    [Email]            NVARCHAR (50)  NOT NULL,
    [Password]         NVARCHAR (50)  NOT NULL,
    [Role]             NCHAR (10)     NULL,
    [CreatedDate]      DATETIME       CONSTRAINT [DF_User_CreatedDate] DEFAULT (getdate()) NOT NULL,
    [ModifiedDate]     DATETIME       NULL,
    [IsActive]         BIT            NULL,
    [DateOfBirth]      DATE           NULL,
    [PrimaryPhone]     NVARCHAR (50)  NULL,
    [SecondaryPhone]   NVARCHAR (50)  NULL,
    [CurrentState]     INT            NULL,
    [CurrentCity]      INT            NULL,
    [CurrentAddress]   NVARCHAR (50)  NULL,
    [IsAddressSame]    BIT            NULL,
    [PermanentState]   INT            NULL,
    [PermanentCity]    INT            NULL,
    [PermanentAddress] NVARCHAR (50)  NULL,
    [AadhaarNumber]    BIGINT         NULL,
    [PanCardNumber]    NVARCHAR (50)  NULL,
    [UploadAadhaar]    NVARCHAR (MAX) NULL,
    [UploadPanCard]    NVARCHAR (MAX) NULL
);



