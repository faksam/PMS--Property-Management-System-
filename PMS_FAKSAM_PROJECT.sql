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
Fullname varchar(80) not null,
Gender varchar(10),
DOB date,
PhoneNumber int not null,
EmailAddress varchar (50),
[Address] varchar(150),
Username varchar(20) not null,
[Password] varchar(15) not null check ([password] >= 8)

)
create table LandLord
(
LandLordID int identity (10,1) primary key,
Fullname varchar(80) not null,
Gender varchar(10),
DOB date,
PhoneNumber int not null,
EmailAddress varchar (50),
[Address] varchar(150),
Username varchar(20) not null,
[Password] varchar(15) not null check ([password] >= 8),
ManagerID int foreign key  references Manager(ManagerID)
)
create table Property 
(
PropertyID int identity (1,1) primary key,
[Address] varchar(150) not null,
Price money,
PropertyType varchar(20) not null,
Size int,
Description varchar(50),
[Status] varchar(20),
Imagefolder varchar(150),
ManagerID int foreign key  references Manager(ManagerID),
LandLordID int foreign key  references LandLord(LandLordID)
)

create table Tenant 
(
TenantID int identity (1,1) primary key,
Fullname varchar(80) not null,
Gender varchar(10),
DOB date,
PhoneNumber int not null,
EmailAddress varchar (50),
MoveInDate date,
LeaseEndDate date,
[Status] varchar(15),
PropertyID int  foreign key  references Property (PropertyID)
)



Select * from Manager


select * from LandLord


select * from Tenant


select * from Property



/*
select Landlord.fullname as [Landlord], property.PropertyType,property.Address,property.Status from property 
, landlord where property.LandLordID=landlord.LandLordID

select Fullname,Gender,PhoneNumber,EmailAddress,MoveInDate,LeaseEndDate,Status from Tenant


insert into Manager values ('ManagerName','Male','09-05-1992',123456789,'ManagerEmail','ManagerAddress','ManagerUsername',1234567)
*/

