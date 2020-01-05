CREATE TABLE [dbo].[MonthlyTransaction] (
    [UserId]              INT    NOT NULL,
    [Monthly Installment] INT    NULL,
    [Taken Amount]        BIGINT NULL,
    [Given Amount]        BIGINT NULL,
    [Deposit Amount]      BIGINT NULL,
    [Balance Amount]      BIGINT NULL,
    [CreatedBy]           INT    NULL,
    [CreatedDate]         DATE   CONSTRAINT [DF_MonthlyTransaction_CreatedDate] DEFAULT (getdate()) NULL,
    [ModifiedBy]          INT    NULL,
    [ModifiedDate]        DATE   NULL,
    CONSTRAINT [FK_MonthlyTransaction_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

