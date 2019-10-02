CREATE DATABASE QUANLYTIVI
GO
USE QUANLYTIVI
GO

-- Product
-- TiviCategory
-- Account
-- Custommer
-- Bill
-- BillInfo
-- warehouse

CREATE TABLE ACCOUNT
(
	NAME NVARCHAR(100) NOT NULL,
	USERNAME VARCHAR(100) PRIMARY KEY,
	PASSWORD VARCHAR(1000) NOT NULL,
	ROLE INT NOT NULL DEFAULT 0, -- 0: STAFF 1: ADMIN
	STATUS INT NOT NULL DEFAULT 0,-- 0: NONACTIVE 1: ACTIVED
)
GO

CREATE TABLE TIVICATEGORY
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE TIVI
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL,
	IDCATEGORY INT NOT NULL,
	PRICE FLOAT NOT NULL DEFAULT 0,
	picture_url VARCHAR(50),
	FOREIGN KEY (IDCATEGORY) REFERENCES TIVICATEGORY(ID)
)
GO

CREATE TABLE CUSTOMMER
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL,
	PHONENUMBER VARCHAR(12) NOT NULL,
	TYPE NVARCHAR(100) NOT NULL DEFAULT 0,
	PAYCOUNT FLOAT NOT NULL DEFAULT 0,
)
GO

CREATE TABLE BILL
(
	ID INT IDENTITY PRIMARY KEY,
	DATECHECKIN DATE NOT NULL,
	IDCUSTOMMER INT NOT NULL,
	STATUS INT NOT NULL DEFAULT 0 -- 1: DA THANH TOAN && 0 CHUA THANH TOAN
	FOREIGN KEY (IDCUSTOMMER) REFERENCES CUSTOMMER(ID)
)

GO

CREATE TABLE BILLINFO
(
	ID INT IDENTITY PRIMARY KEY,
	IDBILL INT NOT NULL,
	IDTIVI INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0
	FOREIGN KEY (IDBILL) REFERENCES BILL(ID),
	FOREIGN KEY (IDTIVI) REFERENCES TIVI(ID)
)

INSERT INTO dbo.ACCOUNT
        ( NAME ,
          USERNAME ,
          PASSWORD ,
          ROLE ,
          STATUS
        )
VALUES  ( N'Nam B�o' , -- NAME - nvarchar(100)
          'pntn0705' , -- USERNAME - varchar(100)
          'Cccc1254' , -- PASSWORD - varchar(1000)
          1 , -- ROLE - int
          1  -- STATUS - int
        )

		SELECT * FROM dbo.ACCOUNT

CREATE PROC USP_Login
@Username nvarchar(100), @Password nvarchar(1000)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE USERNAME = @Username AND PASSWORD = @Password
END
GO

insert into TIVICATEGORY(Name) values (N'samsung')

INSERT INTO dbo.TIVI
        ( NAME, IDCATEGORY, PRICE, picture_url)
VALUES  ( N'S10', -- NAME - nvarchar(100)
          1, -- IDCATEGORY - int
          10000000.0,  -- PRICE - float
		  'C:\\Users\\pntn0\\OneDrive\\Desktop'
          )

		  SELECT * FROM dbo.TIVI
		  INSERT INTO dbo.TIVI
		          ( NAME, IDCATEGORY, PRICE,picture_url)
		  VALUES  ( N'S8', -- NAME - nvarchar(100)
		            1, -- IDCATEGORY - int
		            8000000.0,  -- PRICE - float
		            'C:\\Users\\pntn0\\OneDrive\\Desktop'
					)

select * from TIVICATEGORY