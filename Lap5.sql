use Northwind
go

Create Proc uspInsertEmployee @Ho nvarchar(20), @Ten nvarchar(10), @DiaChia nvarchar(50), @DienThoai nvarchar(24)
AS
	Insert into Employees(LastName, FirstName, Address, HomePhone)
	values (@Ho, @Ten, @DiaChia, @DienThoai)
select * from Employees

exec uspInsertEmployee 'Nguyen', 'Quoc', '222', '123654' 

Create proc uspDeleteEmployee @Manv int
as
begin
	Set nocount on
	Delete Employees
	where EmployeeID = @Manv
end

Create proc uspUpdateEmployee @Ho nvarchar(20), @Ten nvarchar(10), @DiaChia nvarchar(50), @DienThoai nvarchar(24), @Manv int
As
Begin
	Update Employees
	Set LastName = @Ho,
		FirstName = @Ten,
		Address = @DiaChia,
		HomePhone = @DienThoai
	Where EmployeeID = @Manv
end
exec uspUpdateEmployee 'Nguyen Quynh', 'Giao', '123', '23456', 17