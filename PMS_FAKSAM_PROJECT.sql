Create database PMS
go 
using PMS
go 
create table Manager
(
ID int identity (10,1) primary key,
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
ID int foreign key  references Manager(ID)
)

create table Properity 
(
ProperityId int identity (1,1) primary key,
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
ID int foreign key  references Manager(ID),
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
ProperityId int  foreign key  references Properity (ProperityId)
)
