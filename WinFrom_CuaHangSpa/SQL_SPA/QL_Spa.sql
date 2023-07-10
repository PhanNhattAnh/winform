create database QL_Spa
go
use QL_Spa
go
set dateformat dmy
create table NhanVien
(
	tennhanvien varchar(50) primary key,
	tentaikhoan nvarchar(50),
	matkhau nvarchar(50),
	ngaysinh Date,
	chucvu nvarchar(50),
	gioitinh nvarchar(10)
)
create table Sanpham
(
	idsanpham varchar(10) primary key,
	tensanpham nvarchar(50),
	mota nvarchar(50),
	gianhap int,
	giaban int,
	soluong int
)
SELECT * FROM Sanpham WHERE idsanpham = 'SP01'
create table Nhacungcap
(
	idnhacungcap varchar(10) primary key,
	tennhacungcap nvarchar(50),
	diachi nvarchar(50),
	sodt varchar(10)
)

CREATE TABLE Phieunhaphang
(
    idphieunhap varchar(10) primary key,
    idnhacungcap varchar(10) foreign key references Nhacungcap(idnhacungcap),
    ngaynhap date,
    tongtien int DEFAULT 0
)


CREATE TABLE CTPhieunhap
(
    idctphieunhap varchar(10),
    idphieunhap varchar(10) foreign key references Phieunhaphang(idphieunhap),
    idsanpham varchar(10) foreign key references Sanpham(idsanpham)
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    soluong int,
    gianhap int,
	constraint pk_ctphieunhap primary key (idctphieunhap)
)
create table Khachhang
(
	idkhach varchar(10),
	hoten nvarchar(30) unique,
	ngaysinh date,
	gioitinh nvarchar(5),
	diachi nvarchar(50),
	sodt varchar(10),
	email varchar(50)
	constraint pk_Khachhang primary key(idkhach, hoten)
)

create table Dichvu
(
	iddichvu varchar(10),
	tendichvu nvarchar(50) unique,
	mota nvarchar(Max),
	giatien int
	constraint pk_Dichvu primary key(iddichvu, tendichvu)
)

create table Lichhen
(
	idlichhen varchar(10) primary key,
	hoten nvarchar(30),
	ngayhen date,
	giohen time,
	tendichvu nvarchar(50),
	constraint fk_Lichhen_hoten foreign key (hoten) references Khachhang(hoten),
	constraint fk_Lichhen_tendichvu foreign key (tendichvu) references Dichvu(tendichvu)
)
go
CREATE TRIGGER Trg_CTPhieunhap_Insert
ON CTPhieunhap
AFTER INSERT
AS
BEGIN
    -- Cập nhật số lượng sản phẩm trong bảng Sanpham
    UPDATE sp
    SET sp.soluong = sp.soluong + i.soluong
    FROM Sanpham sp
    INNER JOIN inserted i ON sp.idsanpham = i.idsanpham;
END;
go
GO

CREATE PROCEDURE ThemChiTietPhieuNhap
    @idCTphieunhap varchar(10),
    @idPhieuNhap varchar(10),
    @idSanPham varchar(10),
    @soLuong int,
    @giaNhap int
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm chi tiết phiếu nhập vào bảng CTPhieunhap
    INSERT INTO CTPhieunhap (idctphieunhap, idphieunhap, idsanpham, soluong, gianhap)
    VALUES (@idCTphieunhap, @idPhieuNhap, @idSanPham, @soLuong, @giaNhap);

    -- Cập nhật tổng tiền trên phiếu nhập hàng
    UPDATE Phieunhaphang
    SET tongtien = (SELECT SUM(ctpn.soluong * ctpn.gianhap)
                    FROM CTPhieunhap ctpn
                    WHERE ctpn.idphieunhap = @idPhieuNhap)
    WHERE idphieunhap = @idPhieuNhap;
END
go
CREATE PROCEDURE ChinhSuaChiTietPhieuNhap
    @idCTphieunhap varchar(10),
    @idPhieuNhap varchar(10),
    @idSanPham varchar(10),
    @soLuong int,
    @giaNhap int
AS
BEGIN
    SET NOCOUNT ON;

    -- Thay đổi chi tiết phiếu nhập trong bảng CTPhieunhap
    UPDATE CTPhieunhap
    SET idctphieunhap = @idCTphieunhap,
		idphieunhap = @idPhieuNhap,
		idsanpham = @idSanPham,
        soluong = @soLuong,
        gianhap = @giaNhap
    WHERE idctphieunhap = @idCTphieunhap;

    -- Cập nhật tổng tiền trên phiếu nhập hàng
    UPDATE Phieunhaphang
    SET tongtien = (SELECT SUM(ctpn.soluong * ctpn.gianhap)
                    FROM CTPhieunhap ctpn
                    WHERE ctpn.idphieunhap = @idPhieuNhap)
    WHERE idphieunhap = @idPhieuNhap;
END
go
CREATE TRIGGER UpdateTongTienPhieuNhap
ON CTPhieunhap
AFTER INSERT
AS
BEGIN
    -- Lấy idphieunhap của phiếu nhập vừa được chèn
    DECLARE @idPhieuNhap varchar(10);
    SELECT @idPhieuNhap = idphieunhap
    FROM inserted;

    -- Cập nhật tổng tiền trên phiếu nhập hàng
    UPDATE Phieunhaphang
    SET tongtien = (SELECT SUM(ctpn.soluong * ctpn.gianhap)
                    FROM CTPhieunhap ctpn
                    WHERE ctpn.idphieunhap = @idPhieuNhap)
    WHERE idphieunhap = @idPhieuNhap;
END
go
CREATE TRIGGER Trg_DeleteCTPhieunhap
ON CTPhieunhap
AFTER DELETE
AS
BEGIN
    -- Lấy thông tin chi tiết phiếu nhập bị xóa
    DECLARE @DeletedIDPhieunhap VARCHAR(10)
    DECLARE @DeletedSoLuong INT
    DECLARE @DeletedGiaNhap INT

    SELECT @DeletedIDPhieunhap = idphieunhap,
           @DeletedSoLuong = soluong,
           @DeletedGiaNhap = gianhap
    FROM deleted

    -- Cập nhật tổng tiền và số lượng trong bảng Phieunhaphang
    UPDATE Phieunhaphang
    SET tongtien = tongtien - (@DeletedSoLuong * @DeletedGiaNhap)
    WHERE idphieunhap = @DeletedIDPhieunhap

    -- Cập nhật số lượng trong bảng Sanpham
    UPDATE Sanpham
    SET soluong = soluong - @DeletedSoLuong
    WHERE idsanpham IN (SELECT idsanpham FROM deleted)
END;
go
CREATE TRIGGER UpdateGiaNhap
ON CTPhieunhap
AFTER INSERT
AS
BEGIN
    UPDATE Sanpham
    SET gianhap = inserted.gianhap
    FROM Sanpham
    INNER JOIN inserted ON Sanpham.idsanpham = inserted.idsanpham
END;


insert into Sanpham values('SP01', N'Kem dưỡng da', N'Chăm sóc da', 0, 449000, 0)
insert into Sanpham values('SP02', N'Kem trị mụn', N'Chăm sóc da', 0, 349000, 0)
insert into Sanpham values('SP03', N'Kem trị nám, tàn nhang', N'Chăm sóc da', 0, 349000, 0)
insert into Sanpham values('SP04', N'Kem dưỡng ẩm', N'Chăm sóc da', 0, 299000, 0)
insert into Sanpham values('SP05', N'Kem trị quần thăm', N'Chăm sóc da', 0, 199000, 0)
insert into Sanpham values('SP06', N'Kem trị sẹo', N'Chăm sóc da', 0, 599000, 0)

insert into Nhacungcap values('NCC01', N'Công ty Mỹ Phẩm', N'Lê Trọng Tấn', '0123456789')
insert into Nhacungcap values('NCC02', N'Cong ty Sắc đẹp', N'Sài Gòn', '0987654312')
insert into Nhacungcap values('NCC03', N'Cong ty Chăm sóc bản thân', N'Hà Nội', '0789456123')

insert into Phieunhaphang values('PN01', 'NCC01', '12/2/2023',0)
insert into Phieunhaphang values('PN02', 'NCC03', '20/2/2023',0)
insert into Phieunhaphang values('PN03', 'NCC01', '20/2/2023',0)
insert into Phieunhaphang values('PN04', 'NCC02', '21/2/2023',0)
insert into Phieunhaphang values('PN05', 'NCC02', '22/2/2023',0)

insert into CTPhieunhap values('CTPN01', 'PN01', 'SP01', 40, 399000)
insert into CTPhieunhap values('CTPN02', 'PN02', 'SP03', 80, 300000)
insert into CTPhieunhap values('CTPN03', 'PN03', 'SP02', 50, 300000)
insert into CTPhieunhap values('CTPN04', 'PN01', 'SP04', 80, 250000)
insert into CTPhieunhap values('CTPN05', 'PN03', 'SP05', 70, 150000)
insert into CTPhieunhap values('CTPN06', 'PN05', 'SP05', 70, 150000)
insert into CTPhieunhap values('CTPN07', 'PN05', 'SP06', 60, 500000)


insert into Khachhang values('KH01', N'Lê Văn Thuận', '10/5/1999', N'Nam', N'Hà Nội', 0123654789, 'lvt@gmail.com')
insert into Khachhang values('KH02', N'Lê Văn Thy', '11/5/1995', N'Nam', N'Sài Gòn', 0124578963, 'lvt1@gmail.com')
insert into Khachhang values('KH03', N'Nguyễn Thị Huệ', '20/4/2001', N'Nu', N'Huế', 0325689741, 'nth@gmail.com')
insert into Khachhang values('KH04', N'Lê Văn My', '30/3/2000', N'Nam', N'Cà Mau', 0124568732, 'lvm@gmail.com')
insert into Khachhang values('KH05', N'Trần Công Kiên', '29/5/1997', N'Nu', N'Tây Ninh', 0159753287, 'tck@gmail.com')
insert into Khachhang values('KH06', N'Trần Đình Toàn', '17/3/2002', N'Nu', N'Tây Ninh', 0159753287, 'tck@gmail.com')
insert into Khachhang values('KH07', N'Nguyễn Tố Như', '9/6/2003', N'Nu', N'Tây Ninh', 0159753287, 'tck@gmail.com')

insert into Dichvu values('DV01', N'Chăm sóc da', N'Dưỡng da bị thâm', 200000)
insert into Dichvu values('DV02', N'Dịch vụ trị mụn, sẹo', N'Trị mụn, da', 2500000)
insert into Dichvu values('DV03', N'Dịch vụ giảm béo', N'Chăm sóc cơ thể', 500000)
insert into Dichvu values('DV04', N'Dịch vụ trẻ hóa da', N'Dưỡng da trắng sáng', 450000)
insert into Dichvu values('DV05', N'Dịch vụ tắm trắng', N'Chăm sóc da trắng sáng', 300000)
insert into Dichvu values('DV06', N'Dịch vụ triệt lông vĩnh viễn', N'Loại bỏ tế bào chết', 300000)
insert into Dichvu values('DV07', N'Dịch vụ message', N'Thoải mái thư giản cho cơ thể', 350000)

insert into Lichhen values('L01', N'Lê Văn Thuận', '29/5/2023', '13:01', N'Chăm sóc da')
insert into Lichhen values('L02', N'Nguyễn Thị Huệ', '28/5/2023', '10:50', N'Dịch vụ giảm béo')
insert into Lichhen values('L03', N'Lê Văn My', '30/5/2023', '9:15', N'Dịch vụ trẻ hóa da')
insert into Lichhen values('L04', N'Lê Văn Thy', '31/5/2023', '15:30', N'Dịch vụ tắm trắng')
insert into Lichhen values('L05', N'Trần Công Kiên', '1/6/2023', '14:45', N'Dịch vụ trị mụn, sẹo')
insert into Lichhen values('L06', N'Trần Công Kiên', '2/6/2023', '14:00', N'Dịch vụ message')
insert into Lichhen values('L07', N'Lê Văn Thuận', '3/6/2023', '15:00', N'Dịch vụ message')
insert into Lichhen values('L08', N'Nguyễn Tố Như', '3/6/2023', '9:00', N'Dịch vụ message')
insert into Lichhen values('L09', N'Trần Đình Toàn', '4/6/2023', '10:00', N'Chăm sóc da')

insert into NhanVien values(N'Phan Nhật Anh', 'nhatanh250502', '123123z', '25/5/2002', N'Quản Lí','Nam')
SELECT * FROM NhanVien
SELECT idsanpham FROM Sanpham;