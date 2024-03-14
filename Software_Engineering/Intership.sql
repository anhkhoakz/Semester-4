use master
go

create database InternshipManagement
-- drop database InternshipManagement

go

use InternshipManagement

go

create table Students
(
    StudentID varchar(100),
    fullname nvarchar(100),
    hometown nvarchar(100),
    date_of_birth date,
    GPA float,
    constraint PK_SID primary key (StudentID)
)

create table Project
(
    ProjectID varchar(100),
    Projectname varchar (100),
    Supervisor nvarchar(100),
    Funding money
        constraint PK_PID primary key (ProjectID)
)

create table StudentProject
(
    StudentID varchar(100),
    ProjectID varchar(100),
    intershipPlace nvarchar(100),
    distance integer,
    result float,
    constraint PK_StudentPro primary key (StudentID, ProjectID),
    constraint FK_SID foreign key (StudentID) references Students (StudentID),
    constraint FK_PID foreign key (ProjectID) references Project (ProjectID)
)

set dateformat DMY

insert into Students
values
    ('SV01', N'Trần Thanh Trâm', N'Sài Gòn', '23/03/1998', 8.5),
    ('SV02', N'Nguyễn Hồng Linh', N'Thanh Hóa', '20/01/2000', 9.0),
    ('SV03', N'Trần Thanh Phước', N'Tiền Giang', '12/07/2001', 7.5),
    ('SV04', N'Nguyễn Minh Hải', N'Nghệ An', '28/02/1993', 7.0),
    ('SV05', N'Trần Thị Hồng Nhung', N'Kiên Giang', '15/07/1998', 9.0)
select *
from Students

insert into Project
values
    ('DT01', N'Quản lý quán ăn', N'Nguyễn Thễ Hữu', 100000000),
    ('DT02', N'Quản lý khách sạn', N'Trần Trung Hiếu', 200000000),
    ('DT03', N'Quản lý sân bóng đá mini', N'Nguyễn Công Tâm', 300000000),
    ('DT04', N'Quản lý shop hoa tươi', N'Đặng Đức Trung', 150000000),
    ('DT05', N'Quản lý cửa hàng điện thoại', N'Trịnh Thanh Duy', 2000000000)

insert into StudentProject
values
    ('SV01', 'DT01', N'Tiền Giang', 70, 8.0),
    ('SV02', 'DT01', N'Bình Dương', 50, 7.0),
    ('SV03', 'DT02', N'Vũng Tàu', 150, 9.5),
    ('SV03', 'DT03', N'Long An', 50, 8.5),
    ('SV04', 'DT03', N'Nha Trang', 500, 10)

