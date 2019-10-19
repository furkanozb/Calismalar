Create Database BankaDB
Go
use BankaDB
Go
Create Table Customers
(
CustomerId int identity primary key,
FirsName nvarchar(50),
LastName nvarchar(50),
email nvarchar(30) unique,
IdentityNumber int unique,
PhoneNumber int unique
)