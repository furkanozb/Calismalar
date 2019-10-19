Create Database CRMDB
GO
use CRMDB
GO
Create Table Products
(
Id int identity Primary Key,
Name nvarchar(50),
Price smallmoney
)
GO
Create Proc SP_insert
@Name nvarchar(50),
@Price smallmoney
As
insert into Products values(@Name,@Price)
GO
Create Proc SP_delete
@Id int
As
Delete From Products where Id=@Id
GO
Create Proc SP_update
@Id int,
@Name nvarchar(50),
@Price smallmoney
As
Update Products set Name=@Name,Price=@Price where Id=@Id
GO
Create Proc SP_select
As
Select* From Products
GO
Create Table USERS
(
UsedId int identity Primary Key,
FirstName nvarchar(50),
LastName nvarchar(50),
UserName nvarchar(50) unique,
Password nvarchar(50)
)
Create Proc SP_find
@UserId int,
@UserName nvarchar(50)
As
Select * From USERS Where UsedId=@UserId
Select * From USERS