create proc Usp_getname
  @UserName nvarchar(50)
  as
  begin
  select UserName from [User] where UserName like @UserName + '%'
  end