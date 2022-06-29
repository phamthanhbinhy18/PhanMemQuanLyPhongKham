create database QLPKDY
go

use QLPKDY
go

create table BenhNhan
(
	MaBN int primary key identity,
	TenBN nvarchar(max) null,
	SDT char(10) null,
	DiaChi nvarchar(max) null,
)
go

create table Thuoc
(
	MaThuoc int primary key identity,
	TenThuoc nvarchar(max) null,
	QuyCach nvarchar(10) null,
	CongDung nvarchar(max) null,
	CachDung nvarchar(max) null,
	NSX datetime null,
	HSD datetime null,
	Gia bigint null,
)
go

create table DonThuoc
(
	MaDT int primary key identity,
	MaBN int null,
	NgayLap datetime null,
	TongTien bigint null,
	constraint FK_DonThuoc_BenhNhan foreign key (MaBN)
									references BenhNhan(MaBN)
									on delete cascade
									on update cascade
)
go

create table ChiTietDonThuoc
(
	MaCTDT int primary key identity,
	MaDT int null,
	MaThuoc int null,
	SL int null,
	ThanhTien bigint null,
	constraint FK_ChiTietDonThuoc_DonThuoc foreign key (MaDT)
									references DonThuoc(MaDT)
									on delete cascade
									on update cascade,
	constraint FK_ChiTietDonThuoc_Thuoc foreign key (MaThuoc)
									references Thuoc(MaThuoc)
									on delete cascade
									on update cascade,
)
go

create table TaiKhoan
(
	TDN nvarchar(20) primary key,
	MK nvarchar(max) null,
)
go

insert into TaiKhoan
values('admin','admin')
go