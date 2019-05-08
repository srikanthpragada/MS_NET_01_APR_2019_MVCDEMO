create table Students
( Id  int identity(1,1) primary key,
  Name varchar(50) not null,
  Email varchar(50) unique,
  FeePaid int,
  Course varchar(10)
)


insert into students values('Scott Guthrie','scott@microsoft.com',10000,'MS.NET');
insert into students values('Jhon Papa','papa@microsoft.com',5000,'Angular');
insert into students values('Mark Anderson','mark@microsoft.com',10000,'MS.NET');

