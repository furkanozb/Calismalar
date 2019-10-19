Create database CRMDB
go
use CRMDB
go
create table Products
(
	Id int Identity Primary KEy,
	PName varchar(100),
	Price Decimal,
	Stock int
)
go
Create proc SP_Insert
	@PName varchar(100),
	@Price Decimal,
	@Stock int
As 
Begin
	Insert into Products values (@PName,@Price,@Stock)
End
go
Create proc SP_Delete 
	@Id int
as 
	Delete from Products Where Id = @Id
go
Create proc SP_Update
	@Id int,
	@PName varchar(100),
	@Price Decimal,
	@Stock int
as 
	Update Products set PName = @PName , Price = @Price , stock = @Stock
	where Id = @Id 
go
Create proc Sp_Select
as
	Select * from Products
go


