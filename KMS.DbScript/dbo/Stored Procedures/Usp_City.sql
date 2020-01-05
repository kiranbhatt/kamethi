create proc [dbo].[Usp_City]
@Name nvarchar(50),
@StateId int
as
Begin
insert into CityMaster(Name,StateID)values(@Name,@StateId)
End
