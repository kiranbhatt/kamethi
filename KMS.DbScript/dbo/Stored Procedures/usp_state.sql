create proc [dbo].[usp_state]
  @Name varchar(50)
  as
  begin 
  insert into StateMaster(Name)values(@Name)
  end
