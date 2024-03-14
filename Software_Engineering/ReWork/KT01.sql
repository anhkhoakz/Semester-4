
use master 
GO
create database QuanLyThuVien
-- drop database QuanLyThuVien

use quanlythuvien

create table DocGia
(
    madocgia varchar(10),
    hoten nvarchar(30),
    ngaysinh date,
    primary key (madocgia)
)

create table Sach
(
    masach varchar(10),
    tensach NVARCHAR(30),
    tacgia NVARCHAR(30),
    soluong int,
    primary key (masach)
)

create table MuonSach
(
    maphieumuon VARCHAR(10),
    madocgia VARCHAR(10),
    ngaymuon DATE,
    primary key (maphieumuon),
    FOREIGN KEY (madocgia) REFERENCES docgia(madocgia)
)

create table CTPM
(
    maphieumuon VARCHAR(10),
    masach VARCHAR(10),
    ngaytra DATE,
    primary key(maphieumuon, masach),
    foreign key (maphieumuon) REFERENCES muonsach(maphieumuon),
    foreign key (masach) REFERENCES sach(masach)
)

set dateformat DMY

insert into DocGia
VALUES
    ('DG01', N'Lâm Phú Cường', '01/01/2003'),
    ('DG02', N'Phạm Bảo Long', '02/03/2004'),
    ('DG03', N'Phạm Duy Khánh', '16/08/2003')

insert into Sach
VALUES
    ('S001', N'Mắt biếc', N'Nguyễn Ánh', 10),
    ('S002', N'Những Người Cùng Khổ', N'Albert Enstein', 12),
    ('S003', N'Harry Potter', N'J.K Rolling', 20),
    ('S004', N'Số đỏ', N'Vũ trọng Phụng', 7)

insert into MuonSach
VALUES
    ('PM01', 'DG01', '07/12/2023'),
    ('PM02', 'DG03', '08/12/2023')

insert into CTPM
VALUES
    ('PM01', 'S001', '25/12/2023'),
    ('PM02', 'S004', '30/12/2023')

select *
from ctpm