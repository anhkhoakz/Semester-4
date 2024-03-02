use master
GO
drop database Internship_Management
go
create database Internship_Management
GO
use internship_management

create table Students
(
    StudentID varchar(10),
    FullName nvarchar(50),
    HomeTown nvarchar(50),
    DateOfBirth DATE,
    GPA float
);

create table Project
(
    ProjectID VARCHAR(10),
    ProjectName NVARCHAR(50),
    SuperVisor NVARCHAR(50),
    Fuding MONEY
)

create table StudentProject
(
    StudentID VARCHAR(10),
    ProjectID VARCHAR(10),
    InternshipPlace NVARCHAR(50),
    Distance float,
    Result float,
)

INSERT into Students
VALUES
    ('SV01', N'Tran Thanh Tram', 'Sai Gon', '1998-03-23', 8.5),
    ('SV02', N'Nguyen Hong Linh', 'Thanh Hoa', '2000-01-20', 9.0),
    ('SV03', N'Tran Thanh Phuoc', 'Tien Giang', '2001-07-12', 7.5),
    ('SV04', N'Nguyen Minh Hai', 'Nghe An', '1993-02-28', 7.0),
    ('SV05', N'Tran Thi Hong Nhung', 'Kien Giang', '1998-07-15', 9.0);


Insert into Project
VALUES
    ('DT01', N'Quản lý quán ăn', N'Nguyễn Thễ Hữu', 100000000),
    ('DT02', N'Quản lý khách sạn', N'Trần Trung Hiếu', 200000000),
    ('DT03', N'Quản lý sân bóng đá mini', N'Nguyễn Công Tâm', 300000000),
    ('DT04', N'Quản lý shop hoa tươi', N'Đặng Đức Trung', 150000000),
    ('DT05', N'Quản lý cửa hàng điện thoại', N'Trịnh Thanh Duy', 2000000000);

INSERT INTO StudentProject
VALUES
    ('SV01', 'DT01', N'Tiền Giang', 70, 8.0),
    ('SV02', 'DT01', N'Bình Dương', 50, 7.0),
    ('SV03', 'DT02', N'Vũng Tàu', 150, 9.5),
    ('SV03', 'DT03', N'Long An', 50, 8.5),
    ('SV04', 'DT03', N'Nha Trang', 500, 10);
