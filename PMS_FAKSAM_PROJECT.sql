USE master
GO
if exists (select * from sysdatabases where name='PMS')
		drop database PMS
go
create database PMS
go
use PMS
go
create table Manager
(
ManagerID int identity (10,1) primary key,
Name varchar(30) not null,
Gender varchar(10),
DOB date,
[Address] varchar (50),
PhoneNumber int not null,
EmailAddress varchar (50),
Username varchar(20) not null,
[Password] varchar(15) not null check ([password] >= 8)

)
create table LandLord
(
LandLordID int identity (10,1) primary key,
Name varchar(30) not null,
Gender varchar(10),
DOB date,
Nationality varchar(20),
[State] varchar(30),
[Address] varchar (50),
PhoneNumber int not null,
EmailAddress varchar (50),
Username varchar(20) not null,
[Password] varchar(15) not null check ([password] >= 8),
ManagerID int foreign key  references Manager(ManagerID)
)

create table Property 
(
PropertyID int identity (1,1) primary key,
Location varchar(30),
[Address] varchar(50) not null,
Price money,
ProperityType varchar(20) not null,
Size int,
Discription ntext,
[Status] ntext,
Building varchar(20),
LivingArea int,
NumberOfRooms int,
NumberOfBathroom int,
Imagefolder varchar(100),
ManagerID int foreign key  references Manager(ManagerID),
LandLordID int foreign key  references LandLord(LandLordID)
)

create table Tenant 
(
TenantID int identity (1,1) primary key,
FirstName varchar(30),
LastName varchar(30),
DOB date,
Gender varchar(10),
[Status] varchar(15),
PhoneNumber int not null,
EmailAddress varchar (50),
Nationality varchar(30),
[Addres] varchar(50),
MovingDate date,
LeaseEndDate date,
PropertyID int  foreign key  references Property (PropertyID)
)



Select * from Manager
ManagerID,Name,Gender,DOB,Address,PhoneNo,Email,Username,Password
insert into Manager values ('ManagerName','Male','09-05-1992','ManagerAddress',123456789,'ManagerEmail','ManagerUsername',1234567)


select * from LandLord
LandLordID,Name,Gender,DOB,Nationality,State,Address,PhoneNo,Email,Username,Password,ManagerID

select * from Property
propertyID,Location,Address,Price,PropertyType,Size,Discription,Status,Building,LinvingArea,NoRooms,NoBaths,Imagefolde,ManagerID,LandLordID


select * from Tenant
TenantID,FirstName,LastName,Gender,DOB,Status,PhoneNo,Email,Nationality,Address,MovingDate,LeaseEndDate,propertyID
