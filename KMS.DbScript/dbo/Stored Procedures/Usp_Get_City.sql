CREATE proc [dbo].[Usp_Get_City]
as
Begin
 select CityMaster.ID,CityMaster.Name as 'City',StateMaster.Name as 'State' from CityMaster inner join StateMaster on CityMaster.StateID=StateMaster.Id
End
