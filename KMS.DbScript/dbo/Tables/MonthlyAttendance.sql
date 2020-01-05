CREATE TABLE [dbo].[MonthlyAttendance] (
    [AttendanceId] BIGINT IDENTITY (1, 1) NOT NULL,
    [TransationId] BIGINT NULL,
    [MemberId]     INT    NULL,
    [IsPresent]    BIT    NULL,
    [CreatedBy]    INT    NULL,
    [CreatedDate]  DATE   CONSTRAINT [DF_MonthlyAttendance_CreatedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_MonthlyAttendance] PRIMARY KEY CLUSTERED ([AttendanceId] ASC),
    CONSTRAINT [FK_MonthlyAttendance_User] FOREIGN KEY ([MemberId]) REFERENCES [dbo].[User] ([UserId])
);

