create database QLBH_DB
go
use QLBH_DB
go
set dateformat DMY
create	table 	KHACHHANG
(	MAKH 	char(4) primary key,
	HOTEN	varchar(40),
	DCHI	varchar(50),
	SODT 	varchar(20),
	NGSINH	datetime,
	NGDK	datetime,
	DOANHSO	money,
	GT varchar(4),
	Email  varchar(40),
	MucDo char(4)
)

create 	table 	NHANVIEN
(	MANV	char(4) primary key,
	HOTEN	varchar(40),
	SODT	varchar(20),
	DCHI	varchar(50),
	NGSINH	datetime,
	NGVL	datetime,
	GT varchar(4),
	Email  varchar(40),
	MucDo char(4)
)
create	table 	SANPHAM
(	MASP	char(4) primary key,
	TENSP	varchar(40),
	DVT	varchar(20),
	NSX datetime,
	HSD datetime,
	NCC	varchar(100),
	GIA	money,
	CTKM varchar(100)
	
)

create 	table	HOADON
(	SOHD	int primary key, 
	NGHD	datetime, 
	MAKH	char(4) references KHACHHANG(MAKH),
	MANV	char(4) references NHANVIEN(MANV),
	TRIGIA	money
)

CREATE TABLE CTHD
(
	SOHD int foreign key (SOHD) 
	references HOADON(SOHD),

	MASP char(4)foreign key (MASP) 
	references SANPHAM(MASP),
	SL int,
	
)
CREATE TABLE TAIKHOAN
(	TAIKHOAN varchar(40) primary key,
	HOTEN	varchar(40),
	GT CHAR(5),
	Email  varchar(40),
	MATKHAU VARCHAR(40),
	NGSINH DATETIME,
	DCHI VARCHAR(50),
	SDT VARCHAR(12),
	TRANGTHAI INT
 )
 INSERT INTO TAIKHOAN(TAIKHOAN,MATKHAU)
 VALUES('ADMIN','ADMIN')