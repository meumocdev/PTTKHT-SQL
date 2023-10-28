CREATE DATABASE Storage 
Go
Use Storage
CREATE TABLE PRODUCT(
		ProductID  CHAR(4),
		ProductName  VARCHAR(100),
		Currency  VARCHAR(10) DEFAULT '',
		ImportPriceItem decimal(18,2),
		ExportPriceItem decimal(18,2), 
		CONSTRAINT PRK_Product_ProductID PRIMARY KEY(ProductID),
		CONSTRAINT UNQ_Product_ProductName UNIQUE(ProductName),
);
CREATE TABLE Supplier(
		SupplierID  CHAR (3),
		SupplierName  VARCHAR(100),
		Address VARCHAR (200),
		Tel  VARCHAR(20) DEFAULT 'Chua co'
		CONSTRAINT PRK_Supplier_SupplierID PRIMARY KEY(SupplierID),
		CONSTRAINT UNQ_Supplier_SupplierID_SupplierName UNIQUE(SupplierName)
);
CREATE TABLE Orders(
		ShippmentID  CHAR(4),
		SupplierID  CHAR(3),
		OrderDate  DATETIME DEFAULT GETDATE(),
		CONSTRAINT PRK_Orders_ShippmentID PRIMARY KEY(ShippmentID)
);
CREATE TABLE DetailOrder(
		ShippmentID  CHAR(4),
		ProductID  CHAR(4),
		AmountOrder  INT 
		CONSTRAINT PRK_DetailOrder_ShippmentID_ProductID PRIMARY KEY(ShippmentID,ProductID),
		CONSTRAINT CHK_DetailOrder_AmountOrder CHECK(AmountOrder > 0)
);
CREATE TABLE ImportBill(
		ImportBillID  CHAR(4),
		ShippmentID  CHAR(4),
		ImportDate  DATETIME 
		CONSTRAINT PRK_ImportBill_ImportBillID PRIMARY KEY(ImportBillID)
);

CREATE TABLE DetailBillImport(
		ImportBillID  CHAR(4),
		ProductID  CHAR(4),
		AmountImport  INT,
		PriceImport  decimal(18,2), 
		CONSTRAINT PRK_DetailBillImport_ImportBillID_ProductID PRIMARY KEY(ImportBillID,ProductID),
		CONSTRAINT CHK_DetailBillImport_AmountImport CHECK(AmountImport > 0 AND PriceImport > 0)
);
CREATE TABLE ExportBill(
		ExportBillID  CHAR(4),
		ExportDate  DATETIME,
		CONSTRAINT PRK_ExportBill_ExportBillID PRIMARY KEY(ExportBillID)
);
CREATE TABLE DetailBillExport(
		ExportBillID  CHAR(4),
		ProductID  CHAR(4),
		AmountExport  INT,
		PriceExport  decimal(18,2), 
		CONSTRAINT PRK_DetailBillExport_ExportBillID_ProductID PRIMARY KEY(ExportBillID,ProductID),
		CONSTRAINT CHK_DetailBillExport_AmountExport_PriceExport CHECK(AmountExport > 0 AND PriceExport > 0)
);
CREATE TABLE InStorage(
		MonthYear  CHAR(6),
		ProductID  CHAR(4),
		InStorageBefore  INT DEFAULT 0,
		TotalAmountImport INT DEFAULT 0,
		TotalAmountExport  INT DEFAULT 0,
		InStorageAfter  AS InStorageBefore + TotalAmountImport - TotalAmountExport 
		CONSTRAINT PRK_InStorage_MonthYear_ProductID PRIMARY KEY(MonthYear,ProductID),
		CONSTRAINT CHK_InStorage_InStorageBefore_TotalAmountImport_TotalAmountExport CHECK(InStorageBefore >= 0 AND TotalAmountImport >= 0 AND TotalAmountExport >= 0)
);

ALTER TABLE Orders  ADD CONSTRAINT FRK_Orders_Supplier_SupplierID FOREIGN KEY (SupplierID)  REFERENCES Supplier(SupplierID)
ALTER TABLE DetailOrder  ADD CONSTRAINT FRK_DetailOrder_Product_ProductID FOREIGN KEY (ProductID)  REFERENCES Product(ProductID)
ALTER TABLE DetailOrder  ADD CONSTRAINT FRK_DetailOrder_Orders_ShippmentID FOREIGN KEY (ShippmentID)  REFERENCES Orders(ShippmentID)
ALTER TABLE ImportBill  ADD CONSTRAINT FRK_ImportBill_Orders_ShippmentID FOREIGN KEY (ShippmentID)  REFERENCES Orders(ShippmentID)
ALTER TABLE DetailBillImport  ADD CONSTRAINT FRK_DetailBillImport_Product_ProductID FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
ALTER TABLE DetailBillImport  ADD CONSTRAINT FRK_DetailBillImport_ImportBill_ImportBillID FOREIGN KEY (ImportBillID)  REFERENCES ImportBill(ImportBillID)
ALTER TABLE DetailBillExport  ADD CONSTRAINT FRK_DetailBillExport_Product_ProductID FOREIGN KEY(ProductID)  REFERENCES Product(ProductID)
ALTER TABLE DetailBillExport  ADD CONSTRAINT FRK_DetailBillExport_ExportBill_ExportBillID FOREIGN KEY(ExportBillID)  REFERENCES ExportBill(ExportBillID)
ALTER TABLE InStorage  ADD CONSTRAINT FRK_InStorage_Product_ProductID FOREIGN KEY(ProductID)  REFERENCES Product(ProductID)
GO

---- Stored and trigger
-- ImportDate After OrderDate
CREATE TRIGGER TG_ImportBill_Add ON IMPORTBILL 
FOR INSERT 
AS 
	DECLARE  @ImportDate DATETIME ,@OrderDate DATETIME ,@ShippmentID CHAR(4)
SELECT @ImportDate  = ImportDate ,@ShippmentID  = ShippmentID FROM  IMPORTBILL
SELECT @OrderDate  = OrderDate FROM ORDERS
WHERE  ShippmentID = @ShippmentID
IF @ImportDate < @OrderDate
	BEGIN 
		PRINT ' ImportDate After OrderDate '
		ROLLBACK TRANSACTION
		END
SELECT * FROM ORDERS 
INSERT INTO IMPORTBILL VALUES('N005','D001','2002/01/16')
SELECT * FROM IMPORTBILL
--



INSERT INTO Supplier (SupplierID,SupplierName,Address,Tel) VALUES ('C01','Bui Tien  Truong','Xuan La, Tay Ho, Ha Noi','0989995221')
INSERT INTO Supplier (SupplierID,SupplierName,Address,Tel) VALUES ('C02','Nguyen  Thi Thu','Quan La, Tay Ho, Ha Noi','0979012300')
INSERT INTO Supplier (SupplierID,SupplierName,Address,Tel) VALUES ('C03','Ngo  Thanh Tung','Kim Lien, Dong Da','0988098591')
INSERT INTO Supplier (SupplierID,SupplierName,Address,Tel) VALUES ('C04','Bui Tien  Lap','Ha Noi','0904255934')
INSERT INTO Supplier (SupplierID,SupplierName,Address,Tel) VALUES ('C05','Hong  That Cong','Ha Noi','chua co')
INSERT INTO Supplier (SupplierID,SupplierName,Address,Tel) VALUES ('C07','Bui Duc  Kien','To 11, Cum 2, Xuan La','0437530097')

INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('DD01','Dau DVD Hitachi 1 dia','Bo',20000,40000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('DD02','Dau DVD Hitachi 3 dia','Bo',40000,80000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('TL15','Tu lanh Sanyo 150 lit','Cai',25000,50000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('TL90','Tu lanh Sanyo 90 lit','Cai',20000,40000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('TV14','Tivi Sony 14 inches','Cai',15000,30000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('TV21','Tivi Sony 21 inches','Cai',10000,100000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('TV29','Tivi Sony 29 inches','Cai',10000,200000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('VD01','Dau VCD Sony 1 dia','Bo',30000,60000)
INSERT INTO Product (ProductID,ProductName,Currency,ImportPriceItem,ExportPriceItem) VALUES ('VD02','Dau VCD Sony 3 dia','Bo',30000,40000)

INSERT INTO Orders(ShippmentID,SupplierID,OrderDate) VALUES ('D001','C03','01/15/2002')
INSERT INTO Orders(ShippmentID,SupplierID,OrderDate) VALUES ('D002','C01','01/30/2002')
INSERT INTO Orders(ShippmentID,SupplierID,OrderDate) VALUES ('D003','C02','02/10/2002')
INSERT INTO Orders(ShippmentID,SupplierID,OrderDate) VALUES ('D004','C05','02/17/2002')
INSERT INTO Orders(ShippmentID,SupplierID,OrderDate) VALUES ('D005','C02','03/01/2002')
INSERT INTO Orders(ShippmentID,SupplierID,OrderDate) VALUES ('D006','C05','03/12/2002')
INSERT INTO ImportBill(ImportBillID,ShippmentID,ImportDate) VALUES ('N001','D001','01/17/2002')
INSERT INTO ImportBill(ImportBillID,ShippmentID,ImportDate) VALUES ('N002','D001','01/20/2002')
INSERT INTO ImportBill(ImportBillID,ShippmentID,ImportDate) VALUES ('N003','D002','01/31/2002')
INSERT INTO ImportBill(ImportBillID,ShippmentID,ImportDate) VALUES ('N004','D003','02/15/2002')

INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D001','DD01',10)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D001','DD02',15)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D002','VD02',30)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D003','TV14',10)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D003','TV29',20)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D004','TL90',10)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D005','TV14',10)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D005','TV29',20)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D006','TV14',10)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D006','TV29',20)
INSERT INTO DetailOrder(ShippmentID,ProductID,AmountOrder) VALUES('D005','VD01',20)

INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N001','DD01',8,2500000)
INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N001','DD02',10,3500000)
INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N002','DD01',2,2500000)
INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N002','DD02',5,3500000)
INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N003','VD02',30,2500000)
INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N004','TV14',5,2500000)
INSERT INTO DetailBillImport(ImportBillID,ProductID,AmountImport,PriceImport) VALUES('N004','TV29',12,3500000)

INSERT INTO ExportBill(ExportBillID,ExportDate,CustomerName) VALUES('X001','01/17/2002','Duong Minh Chau')
INSERT INTO ExportBill(ExportBillID,ExportDate,CustomerName) VALUES('X002','01/25/2002','Nguyen Kim Dung')
INSERT INTO ExportBill(ExportBillID,ExportDate,CustomerName) VALUES('X003','01/31/2002','Nguyen Tien Dung')
INSERT INTO DetailBillExport(ExportBillID,ProductID,AmountExport,PriceExport) VALUES('X001','DD01',2,3500000)
INSERT INTO DetailBillExport(ExportBillID,ProductID,AmountExport,PriceExport) VALUES('X002','DD01',1,3500000)
INSERT INTO DetailBillExport(ExportBillID,ProductID,AmountExport,PriceExport) VALUES('X002','DD02',5,4900000)
INSERT INTO DetailBillExport(ExportBillID,ProductID,AmountExport,PriceExport) VALUES('X003','DD01',3,3500000)
INSERT INTO DetailBillExport(ExportBillID,ProductID,AmountExport,PriceExport) VALUES('X003','DD02',2,4900000)
INSERT INTO DetailBillExport(ExportBillID,ProductID,AmountExport,PriceExport) VALUES('X003','VD02',10,3250000)

INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200201','DD01',0,10,6)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200201','DD02',0,15,7)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200201','VD02',0,30,10)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','DD01',4,0,0)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','DD02',8,0,0)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','VD02',20,0,0)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','TV14',5,0,0)
INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','TV29',12,0,0)

---------------------------------------------------------------PERMISSION-----------------------------------------------------------------------------
-- Tạo User Người Đại Diện bán hàng (SaleRep) với các quyền sau

-- Sửa , xóa   Order
-- Sửa , xóa   DetailOrder
-- Sửa , xóa , thêm [DetailBillExport]

-- Xem [ExportBill]
-- Xem [InStorage]

------ Tạo Người Đại Diện Bán Hàng ------
CREATE LOGIN Sale WITH PASSWORD = '123456789';

USE Storage;
CREATE USER SaleRep FOR LOGIN Sale;

GRANT SELECT ON [dbo].[InStorage] TO SaleRep;
----------------------------------------

------ KIỂM TRA XEM ĐÃ HOẠT ĐỘNG HAY CHƯA -------
SELECT permission_name 
FROM sys.database_permissions 
WHERE grantee_principal_id = USER_ID('SaleRep');

-- NHỚ kết nối với Sale trước khi sử dụng câu lệnh dứoi

SELECT * FROM  [dbo].[InStorage]

DELETE FROM InStorage WHERE ProductID = 'TV29'

INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','TV29',13,0,0)

-- NẾU KHÔNG DELETE ĐƯỢC THÌ ĐÃ THÀNH CÔNG ( NẾU DEBUG KO ĐƯỢC VUI LÒNG LIÊN HỆ 114)

-------------------- CẤP QUYỀN XEM THÊM SỬA XÓA -----------------------------------

--(NHỚ CHUYỂN LẠI SANG QUYỀN ADMIN TRƯỚC KHI THỰC HIỆN CÁC LỆNH SAU) ---

GRANT INSERT, UPDATE  ON [Storage].[dbo].[DetailOrder] TO DBUser;
GRANT INSERT, UPDATE  ON [Storage].[dbo].[Orders] TO DBUser;
GRANT SELECT ON [Storage].[dbo].[ExportBill] TO DBUser;
GRANT INSERT, UPDATE, DELETE ON [Storage].[dbo].[DetailBillExport] TO DBUser;

--CHECK XEM ĐÃ THÀNH CÔNG HAY CHƯA

SELECT permission_name 
FROM sys.database_permissions 
WHERE grantee_principal_id = USER_ID('SaleRep');

-----------------------------------------------------------------------------------------------------

-- Tạo User Người Đại Diện Nhập Hàng (ProductRep) với các quyền sau

-- Sửa , xóa , thêm [DetailBillImport]

-- Xem [PRODUCT]
-- Xem [SUPPLIER]
-- Xem [BillImport]


------ Tạo Người Đại Diện Nhập Hàng ------
--(NHỚ CHUYỂN LẠI SANG QUYỀN ADMIN TRƯỚC KHI THỰC HIỆN CÁC LỆNH SAU) ---


CREATE LOGIN Import WITH PASSWORD = '123456789';

USE Storage;
CREATE USER ImportRep FOR LOGIN Import;

GRANT SELECT ON [dbo].[InStorage] TO ImportRep;

GRANT SELECT ON [dbo].[Product] TO ImportRep;

GRANT SELECT ON [dbo].[Supplier] TO ImportRep;

GRANT SELECT ON [dbo].[ExportBill] TO ImportRep;

----------------------------------------

------ KIỂM TRA XEM ĐÃ HOẠT ĐỘNG HAY CHƯA -------
--(NHỚ CHUYỂN SANG ADMIN)

SELECT permission_name 
FROM sys.database_permissions 
WHERE grantee_principal_id = USER_ID('ImportRep');

-- NHỚ kết nối với Sale trước khi sử dụng câu lệnh dứoi

SELECT * FROM  [dbo].[InStorage]

DELETE FROM InStorage WHERE ProductID = 'TV29'

INSERT INTO InStorage(MonthYear,ProductID,InStorageBefore,TotalAmountImport,TotalAmountExport) VALUES('200202','TV29',13,0,0)

-- NẾU KHÔNG DELETE ĐƯỢC THÌ ĐÃ THÀNH CÔNG ( NẾU DEBUG KO ĐƯỢC VUI LÒNG LIÊN HỆ 114)

-------------------- CẤP QUYỀN XEM THÊM SỬA XÓA -----------------------------------

--(NHỚ CHUYỂN LẠI SANG QUYỀN ADMIN TRƯỚC KHI THỰC HIỆN CÁC LỆNH SAU) ---

GRANT INSERT, UPDATE, DELETE ON [Storage].[dbo].[DetailBillImport] TO ImportRep;

--CHECK XEM ĐÃ THÀNH CÔNG HAY CHƯA

SELECT permission_name 
FROM sys.database_permissions 
WHERE grantee_principal_id = USER_ID('ImportRep');


---------------------------


