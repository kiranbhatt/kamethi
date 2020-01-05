CREATE TYPE [dbo].[MonthlyTransactionType] AS TABLE (
    [UserId]             INT NULL,
    [MonthlyInstallment] INT NULL,
    [TakenAmount]        INT NULL,
    [GivenAmount]        INT NULL,
    [DepositeAmount]     INT NULL,
    [BalanceAmount]      INT NULL);

