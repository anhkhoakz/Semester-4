use master

go

create database QuanLyThuVien
--drop database QuanLyThuVien

go

use QuanLyThuVien

go

create table DocGia
(
    madocgia varchar(100),
    hoten nvarchar(100),
    ngaysinh date,
    constraint PK_DG primary key (madocgia)
)

create table Sach
(
    masach varchar(100),
    tensach nvarchar(100),
    tacgia nvarchar(100),
    soluong integer,
    constraint PK_S primary key (masach)
)

create table MuonSach
(
    maphieumuon varchar(100),
    madocgia varchar(100),
    ngaymuon date,
    constraint PK_MS primary key (maphieumuon),
    constraint FK_DS foreign key (madocgia) references DocGia (madocgia)
)

create table CTPM
(
    maphieumuon varchar(100),
    masach varchar(100),
    ngaytra date,
    constraint PK_CT primary key (maphieumuon),
    constraint FK_CT foreign key (maphieumuon) references MuonSach (maphieumuon)
)

set dateformat DMY

insert into DocGia
values
    ('DG01', N'Nguyễn Văn A', '01/12/1998'),
    ('DG02', N'Nguyễn Thị B', '12/03/2004'),
    ('DG03', N'Đoàn Ngọc C', '07/07/2003')

insert into Sach
values
    ('S01', N'Sách A', N'Trần Văn A', 3),
    ('S02', N'Sách B', N'Đỗ Trung B', 1),
    ('S03', N'Sách C', N'Tô C', 2)

insert into MuonSach
values
    ('PM01', 'DG01', '12/12/2023'),
    ('PM02', 'DG02', '07/02/2024'),
    ('PM03', 'DG03', '29/01/2024')
select *
from MuonSach


insert into CTPM
values
    ('PM01', 'S02', '15/12/2023'),
    ('PM02', 'S03', '10/03/2024'),
    ('PM03', 'S01', '30/01/2024')

