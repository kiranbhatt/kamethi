CREATE TABLE [dbo].[MonthlyTransactionSummary] (
    [TransationId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [Kamethi Number]       NVARCHAR (150) NULL,
    [HostId]               INT            NOT NULL,
    [Total Taken Amount]   BIGINT         NULL,
    [Total Deposit Amount] BIGINT         NULL,
    [Remaining Balance]    BIGINT         NULL,
    [Total Interest]       BIGINT         NULL,
    [PerHead Interest]     BIGINT         NULL,
    [CreatedBy]            INT            NULL,
    [CreatedDate]          DATE           CONSTRAINT [DF_MonthlyTransactionSummary_CreatedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Monthly Transaction summary] PRIMARY KEY CLUSTERED ([TransationId] ASC)
);

