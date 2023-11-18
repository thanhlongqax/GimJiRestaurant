drop database if exists Gimji
go

create database Gimji;
go

use Gimji;
go


-- Tạo bảng Khach_hang
CREATE TABLE Khach_hang (
   id_khach_hang varchar(8) PRIMARY KEY,
   ten_dang_nhap VARCHAR(100) not null,
   mat_khau VARCHAR(20) not null,
   ten_khach_hang NVARCHAR(200) ,
   ngay_sinh DATE,
   gioi_tinh nvarchar(4),
   so_dien_thoai NVARCHAR(20),
   dia_chi NVARCHAR(200),
   email NVARCHAR(100),
   diem_thuong INT default 0,
   loai_tai_khoan NVARCHAR(100) not null default N'Đồng' check (loai_tai_khoan in (N'Đồng' , N'Bạc' , N'Vàng' , N'Kim Cương'))
);

go
INSERT INTO Khach_hang (id_khach_hang, ten_dang_nhap, mat_khau, ten_khach_hang, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, email, diem_thuong, loai_tai_khoan)
VALUES
('UID00002', 'customer1', 'password1', N'Nguyễn Văn Khánh', '1990-01-15', N'Nam', '1234567891', N'123 Main St, Hanoi', 'customer1@email.com', 100, N'Đồng'),
('UID00003', 'customer2', 'password2', N'Nguyễn Thị Hằng', '1985-03-20', N'Nữ', '1234567892', N'456 Oak St, Ho Chi Minh City', 'customer2@email.com', 150, N'Bạc'),
('UID00004', 'customer3', 'password3', N'Trần Đức Anh', '1992-05-10', N'Nam', '1234567893', N'789 Pine St, Da Nang', 'customer3@email.com', 200, N'Vàng'),
('UID00005', 'customer4', 'password4', N'Phạm Thị Mai', '1980-08-05', N'Nữ', '1234567894', N'101 Elm St, Hanoi', 'customer4@email.com', 250, N'Kim Cương'),
('UID00006', 'customer5', 'password5', N'Hoàng Đình Trường', '1988-12-30', N'Nam', '1234567895', N'222 Maple St, Ho Chi Minh City', 'customer5@email.com', 300, N'Đồng'),
('UID00007', 'customer6', 'password6', N'Nguyễn Thị Lan', '1983-02-25', N'Nữ', '1234567896', N'333 Cedar St, Da Nang', 'customer6@email.com', 350, N'Bạc'),
('UID00008', 'customer7', 'password7', N'Lê Văn Đức', '1995-07-18', N'Nam', '1234567897', N'444 Walnut St, Hanoi', 'customer7@email.com', 400, N'Vàng'),
('UID00009', 'customer8', 'password8', N'Nguyễn Thị Hoa', '1987-11-12', N'Nữ', '1234567898', N'555 Birch St, Ho Chi Minh City', 'customer8@email.com', 450, N'Kim Cương'),
('UID00010', 'customer9', 'password9', N'Vũ Minh Tuấn', '1991-04-22', N'Nam', '1234567899', N'666 Oak St, Da Nang', 'customer9@email.com', 500, N'Đồng'),
('UID00011', 'customer10', 'password10', N'Phạm Thị Hương', '1989-09-08', N'Nữ', '1234567890', N'777 Elm St, Hanoi', 'customer10@email.com', 550, N'Bạc');
go
CREATE PROCEDURE UpdateCustomerById
    @id_khach_hang varchar(8),
	@ten_dang_nhap VARCHAR(100),
    @mat_khau VARCHAR(20),
    @ten_khach_hang NVARCHAR(200),
    @ngay_sinh DATE,
    @gioi_tinh nvarchar(4),
    @so_dien_thoai NVARCHAR(20),
    @dia_chi NVARCHAR(200),
    @email NVARCHAR(100),
    @diem_thuong INT
AS
BEGIN
    UPDATE Khach_hang
    SET
        ten_khach_hang = @ten_khach_hang,
        ngay_sinh = @ngay_sinh,
        gioi_tinh = @gioi_tinh,
        so_dien_thoai = @so_dien_thoai,
        dia_chi = @dia_chi,
        email = @email,
        diem_thuong = @diem_thuong
    WHERE
        id_khach_hang = @id_khach_hang;
END

go
-- procedure de tao nguoi dung
create procedure InsertCusTomerLoginData
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'UID00001'
	select @maxUserID = cast(max(cast(substring(id_khach_hang, 4, 8) as int)) + 1 as varchar) from Khach_hang where substring(id_khach_hang, 1, 3) = 'UID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'UID' + @maxUserID 
	end
	    insert into Khach_hang(id_khach_hang , ten_dang_nhap , mat_khau) values (@newUserID, @userName, @userPassword )
end
go

CREATE PROCEDURE InsertCustomer
    @ten_dang_nhap VARCHAR(30),
    @mat_khau VARCHAR(20),
    @ten_khach_hang NVARCHAR(200),
    @ngay_sinh DATE,
    @gioi_tinh nvarchar(4),
    @so_dien_thoai NVARCHAR(20),
    @dia_chi NVARCHAR(200),
    @email NVARCHAR(100),
    @diem_thuong INT
AS
BEGIN
declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'UID00001'
	select @maxUserID = cast(max(cast(substring(id_khach_hang, 4, 8) as int)) + 1 as varchar) from Khach_hang where substring(id_khach_hang, 1, 3) = 'UID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'UID' + @maxUserID 
	end
    INSERT INTO Khach_hang (id_khach_hang, ten_dang_nhap, mat_khau, ten_khach_hang, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, email, diem_thuong)
    VALUES (@newUserID, @ten_dang_nhap, @mat_khau, @ten_khach_hang, @ngay_sinh, @gioi_tinh, @so_dien_thoai, @dia_chi, @email, @diem_thuong);
END

go

-- Tạo bảng Nhan_vien
CREATE TABLE Nhan_vien (
	id_nhan_vien varchar(8) primary key,
   ten_dang_nhap VARCHAR(200) not null,
   mat_khau VARCHAR(20) not null,
   ten_nhan_vien NVARCHAR(500) not null ,
   ngay_sinh varchar(10) not null,
   gioi_tinh NVARCHAR(4),
   dia_chi NVARCHAR(200) not null,
   so_dien_thoai NVARCHAR(20) not null,
   email NVARCHAR(100),
   ngay_bat_dau varchar(10),
   muc_luong FLOAT,
   viTri Nvarchar (50) 
);
go

-- Tạo procedure cập nhật thông tin nhân viên dựa vào id_nhan_vien
CREATE PROCEDURE UpdateStaffById
    @id_nhan_vien varchar(8),
    @ten_dang_nhap VARCHAR(200),
    @mat_khau VARCHAR(20),
    @ten_nhan_vien NVARCHAR(500),
    @ngay_sinh varchar(10),
    @gioi_tinh NVARCHAR(4),
    @dia_chi NVARCHAR(200),
    @so_dien_thoai NVARCHAR(20),
    @email NVARCHAR(100),
    @ngay_bat_dau varchar(10),
    @muc_luong FLOAT,
    @viTri Nvarchar(50)
AS
BEGIN
    -- Kiểm tra xem nhân viên có tồn tại dựa vào id_nhan_vien
    IF EXISTS (SELECT 1 FROM Nhan_vien WHERE id_nhan_vien = @id_nhan_vien)
    BEGIN
        -- Nếu nhân viên tồn tại, thực hiện cập nhật thông tin
        UPDATE Nhan_vien
        SET
            ten_dang_nhap = @ten_dang_nhap,
            mat_khau = @mat_khau,
            ten_nhan_vien = @ten_nhan_vien,
            ngay_sinh = @ngay_sinh,
            gioi_tinh = @gioi_tinh,
            dia_chi = @dia_chi,
            so_dien_thoai = @so_dien_thoai,
            email = @email,
            ngay_bat_dau = @ngay_bat_dau,
            muc_luong = @muc_luong,
            viTri = @viTri
        WHERE id_nhan_vien = @id_nhan_vien;
    END
END
go
--procedure tao nhan vien
create procedure InsertStaffLoginData
    @userName varchar(500),
    @userPassword varchar(500),
    @fullName nvarchar(500),
	@contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @emailAddress varchar(500),
	@DateOfBirth varchar(10),
	@position nvarchar(50),
	@gender nvarchar(10)
as
begin
    declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'SID00001'
	select @maxUserID = cast(max(cast(substring(id_nhan_vien, 4, 8) as int)) + 1 as varchar) from Nhan_vien where substring(id_nhan_vien, 1, 3) = 'SID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'SID' + @maxUserID 
	end
	    insert into Nhan_vien(id_nhan_vien,ten_dang_nhap ,  mat_khau , ten_nhan_vien ,dia_chi,so_dien_thoai,email , ngay_sinh ,viTri ,gioi_tinh) values 
			(@newUserID,@userName , @userPassword, @fullName, @contactAddress , @phoneNumber , @emailAddress, @DateOfBirth ,@position ,@gender);
end
go

-- Insert the first Vietnamese employee
EXEC InsertStaffLoginData
    @fullName = N'Nguyễn Văn An',
    @emailAddress = 'nguyenvanan@example.com',
    @contactAddress = N'123 Đường A, Quận 1, TP.HCM',
    @phoneNumber = '0901234567',
    @DateOfBirth = '1990-01-15',
    @userName = 'nguyenvanan',
    @userPassword = 'password123',
    @position = N'Nhân viên',
	@gender = N'Nam';
go
-- Insert the second Vietnamese employee
EXEC InsertStaffLoginData
    @fullName = N'Trần Thị Bình',
    @emailAddress = 'tranthibinh@example.com',
    @contactAddress = N'456 Đường B, Quận 2, TP.HCM',
    @phoneNumber = '0909876543',
    @DateOfBirth = '1985-07-22',
    @userName = 'tranthibinh',
    @userPassword = 'securepassword',
    @position = N'Đầu Bếp',
	@gender = N'Nữ';
go
-- Insert the third Vietnamese employee
EXEC InsertStaffLoginData
    @fullName = N'Hoàng Minh Cường',
    @emailAddress = 'hoangminhcuong@example.com',
    @contactAddress = N'789 Đường C, Quận 3, TP.HCM',
    @phoneNumber = '0912345678',
    @DateOfBirth = '1995-03-10',
    @userName = 'hoangminhcuong',
    @userPassword = 'mypassword123',
    @position = N'Nhân Viên',
	@gender = N'Nam';
go
CREATE TABLE Admin (
   id_admin varchar(8) PRIMARY KEY,
   ten_dang_nhap VARCHAR(30) not null,
   mat_khau VARCHAR(20) not null,
   ten_admin NVARCHAR(500) not null,
   ngay_sinh DATE null,
   email NVARCHAR(200) not null,
   so_dien_thoai NVARCHAR(20) not null


);
go
--procedure tao admin
create procedure InsertAdminLoginData
    @userName varchar(500),
    @userPassword varchar(500),
    @fullName nvarchar(500),
	@phoneNumber varchar(10),
	@emailAddress varchar(500),
	@DateOfBirth varchar(10)
as
begin
    declare @newAdminID char(8)
	declare @maxAdminID varchar(500)
	set @newAdminID = 'AID00001'
	select @maxAdminID = cast(max(cast(substring(id_admin, 4, 8) as int)) + 1 as varchar) from Admin where substring(id_admin, 1, 3) = 'AID'
	if (cast(@maxAdminID as int) > cast(substring(@newAdminID, 4, 8) as int))
	begin
		while (len(@maxAdminID) < 5)
		begin
			set @maxAdminID = '0' + @maxAdminID
		end
		set @newAdminID = 'AID' + @maxAdminID 
	end
		    insert into Admin(id_admin,ten_dang_nhap, mat_khau ,ten_admin ,ngay_sinh ,email ,  so_dien_thoai) values (@newAdminID , @userName, @userPassword , @fullName  ,@DateOfBirth ,@emailAddress , @phoneNumber)
end

go 
CREATE TABLE Danh_muc_mon_an (
   id_danhMuc INT PRIMARY KEY ,
   loai_mon NVARCHAR(30) not null
);

go
create procedure InsertCatergory
	@idCategory int ,
    @FoodType Nvarchar(500)
as
begin
	insert into Danh_muc_mon_an(id_danhMuc,loai_mon) values (@idCategory,@FoodType)
end
go
Insert into Danh_muc_mon_an(id_danhMuc,loai_mon) values
	(0,N'All'),
	(1,N'TOKBOKKI'),
	(2,N'THỊT NƯỚNG'),
	(3,N'SALAD'),
	(4,N'KIMBAK'),
	(5,N'CƠM')

go
CREATE TABLE Mon_an(
   id_mon_an INT PRIMARY KEY identity, 
   ten_mon_an NVARCHAR(200),
   don_gia FLOAT,
   hinh_anh NVARCHAR(200),
   tinh_trang NVARCHAR(200),
   id_danh_muc INT 
)
Alter table Mon_an add constraint fk_id_danh_muc Foreign key (id_danh_muc) references Danh_muc_mon_an(id_danhMuc)
go
create procedure InsertDish
    @Name varchar(500),
    @donGia nvarchar(500),
	@picture nvarchar(10),
	@Type varchar(500),
	@id_danhMuc int
as
begin
	insert into Mon_an(ten_mon_an,don_gia ,hinh_anh ,tinh_trang ,id_danh_muc) values (@Name , @donGia ,@picture , @Type, @id_danhMuc)
end

go

INSERT INTO Mon_an(ten_mon_an , don_gia , hinh_anh ,tinh_trang, id_danh_muc) VALUES
	(N'Tobokki Chả Cá Sốt',50.000 , N'Resources/AnhMonAn/Tokbokki/tokbokki_chả_cá_sốt_HQ-removebg-preview.png' , N'Còn Hàng',1),
	(N'Tobokki Gà Sốt HQ',100.000 , N'Resources/AnhMonAn/Tokbokki/tokbokki_gà_sốt_HQ-removebg-preview.png' , N'Còn Hàng',1),
	(N'Tokbokki Sốt Phô Mai',150.000 , N'Resources/AnhMonAn/Tokbokki/Tokbokki_sotPhoMai.png' , N'Còn Hàng',1),
	(N'Ba Chỉ Heo Nướng',150.000 , N'Resources/AnhMonAn/ThitNuong/BaChiHeoNuong.png' , N'Còn Hàng',2),
	(N'Ba Chỉ Heo Nướng Mật Ong',150.000 , N'Resources/AnhMonAn/ThitNuong/BachiHeoNuongMatOng.png' , N'Còn Hàng',2),
	(N'Salad Gà Gốt Mayonnaise',200.000 , N'Resources/AnhMonAn/Salad/salad_gà_sốt_mayonnaise-removebg-preview.png' , N'Còn Hàng',3),
	(N'Salad Gimji',175.000 , N'Resources/AnhMonAn/Salad/salad_gimji-removebg-preview.png' , N'Còn Hàng',3),
	(N'KimBak Truyền Thống',230.000 , N'Resources/AnhMonAn/KimBak/kimbab_truyền_thống-removebg-preview.png' , N'Còn Hàng',4),
	(N'KimBak Chiên Xù',230.000 , N'Resources/AnhMonAn/KimBak/KimbakChienXu.png' , N'Còn Hàng',4),
	(N'KimBak Thịt Heo Chiên',250.000 , N'Resources/AnhMonAn/KimBak/KimBakThitHeoChien.png' , N'Còn Hàng',4),
	(N'KimBak Trướng Cuộn',270.000 , N'Resources/AnhMonAn/KimBak/Trứng_cuộn-removebg-preview.png' , N'Còn Hàng',4),
	(N'Cơm Trộn Hàn Quốc',200.000 , N'Resources/AnhMonAn/Com/ComtronHanQuoc.png' , N'Còn Hàng',5)

go

CREATE TABLE Ban (
   id_ban INT PRIMARY KEY Identity,
   ten_ban NVARCHAR(20) ,
   tang int,
);
go
INSERT INTO Ban (ten_ban, tang)
VALUES
    (N'Bàn 1', 1),
    (N'Bàn 2', 1),
    (N'Bàn 3', 1),
    (N'Bàn 4', 1),
    (N'Bàn 5', 2),
    (N'Bàn 6', 2),
    (N'Bàn 7', 2)
go
Create table Ban_NV(
	id_nhan_vien VARCHAR(8),
	id_ban INT ,
	ten_khach_hang nvarchar(200) , 
	sdt_khach_hang nvarchar(200) ,
	ghi_chu VARCHAR(200),
	ngay_dat_ban Date,
	primary key (id_nhan_vien , id_ban),
	CONSTRAINT fk_ban FOREIGN KEY (id_ban) REFERENCES Ban(id_ban),
	CONSTRAINT fk_ban_NV FOREIGN KEY (id_nhan_vien) REFERENCES Nhan_vien(id_nhan_vien)
);
go
CREATE PROCEDURE InsertTable_NV (
    @id_nhan_vien VARCHAR(8),
    @id_ban INT,
    @ten_khach_hang NVARCHAR(200),
    @sdt_khach_hang NVARCHAR(200),
    @ghi_chu VARCHAR(200),
    @ngay_dat_ban DATE
)
AS
BEGIN
    -- Insert a new record into Ban_NV table
    INSERT INTO Ban_NV (id_nhan_vien, id_ban, ten_khach_hang, sdt_khach_hang, ghi_chu, ngay_dat_ban)
    VALUES (@id_nhan_vien, @id_ban, @ten_khach_hang, @sdt_khach_hang, @ghi_chu, @ngay_dat_ban);
END;
go
-- Tạo bảng Hoa_don
CREATE TABLE Hoa_don (
   id_hoa_don INT PRIMARY KEY,
   ngay_lap DATETIME not null,
   tong_tien FLOAT not null,
   id_nhan_vien varchar(8) ,
   id_khach_hang varchar(8)
);
go
-- Add a foreign key to nhan_vien_id in the sHoa_don table
ALTER TABLE Hoa_don ADD CONSTRAINT FK_Hoa_don_Nhan_vien FOREIGN KEY (id_nhan_vien) REFERENCES Nhan_vien(id_nhan_vien);
go
-- Add a foreign key to khach_hang_id in the Hoa_don table
ALTER TABLE Hoa_don ADD CONSTRAINT FK_Hoa_don_Khach_hang FOREIGN KEY (id_khach_hang) REFERENCES Khach_hang(id_khach_hang);
go

-- Tạo bảng Phuong_thuc_thanh_toan
CREATE TABLE Phuong_thuc_thanh_toan (
   id_phuong_thuc INT PRIMARY KEY,
   ten_phuong_thuc NVARCHAR(45) not null,
);
go
Insert into Phuong_thuc_thanh_toan(id_phuong_thuc , ten_phuong_thuc )values 
	(1,N'Tiền Mặt'),
	(2,N'Credit Card'),
	(3,N'QR Code')
go
-- Tạo bảng Chi_tiet_hoa_don
CREATE TABLE Chi_tiet_hoa_don (
   id_chi_tiet INT PRIMARY KEY identity,
   id_hoa_don INT,
   id_mon_an INT,
   so_luong INT NOT NULL,
   don_gia FLOAT NOT NULL,
   id_phuong_thuc INT
);
go
-- Add a foreign key to hoa_don_id in the Chi_tiet_hoa_don table
ALTER TABLE Chi_tiet_hoa_don ADD CONSTRAINT FK_Chi_tiet_hoa_don_Hoa_don FOREIGN KEY (id_hoa_don) REFERENCES Hoa_don(id_hoa_don);
go
-- Add a foreign key to mon_an_id in the Chi_tiet_hoa_don table
ALTER TABLE Chi_tiet_hoa_don ADD CONSTRAINT FK_Chi_tiet_hoa_don_Danh_muc_mon_an FOREIGN KEY (id_mon_an) REFERENCES Mon_an(id_mon_an);
go
-- Add a foreign key to phuong_thuc_id in the Chi_tiet_hoa_don table
ALTER TABLE Chi_tiet_hoa_don ADD CONSTRAINT FK_Chi_tiet_hoa_don_Phuong_thuc_thanh_toan FOREIGN KEY (id_phuong_thuc) REFERENCES Phuong_thuc_thanh_toan(id_phuong_thuc);
go
-- Tạo bảng Ca_lam
CREATE TABLE Ca_lam (
   id_ca INT PRIMARY KEY,
   ten_ca VARCHAR(45),
   gio_bat_dau DATETIME NOT NULL,
   gio_ket_thuc DATETIME NOT NULL,
   ngay_bat_dau DATE NOT NULL,
   ngay_ket_thuc DATE NOT NULL,
   nhan_vien_id varchar(8)
);
go
-- Add a foreign key to nhan_vien_id in the Ca_lam table
ALTER TABLE Ca_lam ADD CONSTRAINT FK_Ca_lam_Nhan_vien FOREIGN KEY (nhan_vien_id) REFERENCES Nhan_vien(id_nhan_vien);



-- Tạo bảng Giao_hang
CREATE TABLE Giao_hang (
   id_giao_hang INT PRIMARY KEY,
   ngay_dat_hang DATETIME not null default current_timestamp,
   trang_thai INT,
   dia_chi_giao NVARCHAR(200) not null,
   ghi_chu NVARCHAR(500),
   tong_tien FLOAT not null,
   khach_hang_id varchar(8)
);
go
-- Add a foreign key to khach_hang_id in the Giao_hang table
ALTER TABLE Giao_hang ADD CONSTRAINT FK_Giao_hang_Khach_hang FOREIGN KEY (khach_hang_id) REFERENCES Khach_hang(id_khach_hang);


-- Tạo bảng Chi_tiet_giao_hang
CREATE TABLE Chi_tiet_giao_hang (
   id_chi_tiet INT PRIMARY KEY,
   giao_hang_id INT,
   mon_an_id INT,
   so_luong INT not null,
   don_vi_van_chuyen NVARCHAR(100)
);
go
-- Add a foreign key to giao_hang_id in the Chi_tiet_giao_hang table
ALTER TABLE Chi_tiet_giao_hang ADD CONSTRAINT FK_Chi_tiet_giao_hang_Giao_hang FOREIGN KEY (giao_hang_id) REFERENCES Giao_hang(id_giao_hang);

-- Add a foreign key to mon_an_id in the Chi_tiet_giao_hang table
ALTER TABLE Chi_tiet_giao_hang ADD CONSTRAINT FK_Chi_tiet_giao_hang_Danh_muc_mon_an FOREIGN KEY (mon_an_id) REFERENCES Mon_an(id_mon_an);

go
CREATE TABLE Uu_Dai(
   id_UuDai INT PRIMARY KEY,
   ten_UuDai NVARCHAR(200),
   mo_ta NVARCHAR(200),
   dieu_kien NVARCHAR(200),
   timeBatDau DATE default current_timestamp,
   timeKetThuc DATE default current_timestamp
)