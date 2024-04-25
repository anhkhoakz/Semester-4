use master

go

create database QuanLyThuVien
--drop database QuanLyThuVien

go

use QuanLyThuVien

go

create table DocGia (
docgiaID varchar(100),
hoten nvarchar(100),
ngaysinh date,
constraint PK_DG primary key (docgiaID) 
)

create table Sach (
sachID varchar(100),
tensach nvarchar(100),
tacgia nvarchar(100),
soluong integer,
constraint PK_S primary key (sachID)
)

create table MuonSach (
phieuID varchar(100),
docgiaID varchar(100),
ngaymuon date,
constraint PK_MS primary key (phieuID),
constraint FK_DS foreign key (docgiaID) references DocGia (docgiaID)
)

create table CTPM (
phieuID varchar(100),
sachID varchar(100),
ngaytra date,
constraint PK_CT primary key (phieuID),
constraint FK_CT foreign key (phieuID) references MuonSach (phieuID)
)

set dateformat DMY

insert into DocGia 
values 
('DG001', N'Nguyễn Văn A','01/12/1998'),
('DG002', N'Nguyễn Thị B','12/03/2004'),
('DG003', N'Đoàn Ngọc C','07/07/2003')

insert into Sach
values
('S001', N'Sách A', N'Trần Văn A', 3),
('S002', N'Sách B', N'Đỗ Trung B', 1),
('S003', N'Sách C', N'Tô C', 2)

insert into MuonSach
values
('PM001', 'DG001', '12/12/2023'),
('PM002', 'DG002', '07/02/2024'),
('PM003', 'DG003', '29/01/2024')
select * from MuonSach


insert into CTPM
values
('PM001', 'S002', '15/12/2023'),
('PM002', 'S003', '10/03/2024'),
('PM003', 'S001', '30/01/2024')
