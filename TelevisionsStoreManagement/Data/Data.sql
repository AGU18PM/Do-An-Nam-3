﻿USE MASTER

drop database TVSTOREMANAGERMENT

CREATE DATABASE TVSTOREMANAGERMENT

GO

USE TVSTOREMANAGERMENT

GO

CREATE TABLE ACCOUNT(
	USERNAME VARCHAR(100) PRIMARY KEY,
	PASSWORD VARCHAR(1000),
	DISPLAYNAME NVARCHAR(100),
	ROLE INT, -- 1: Admin 2: Staff
)

GO

CREATE TABLE CUSTOMER(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100),
	PHONE_NUMBER VARCHAR(10),
	TYPE INT, -- 1:VIP 2:NORMAL
	PAYCOUNT FLOAT -- >30TR = VIP
)


GO



CREATE TABLE TIVI(
	ID INT IDENTITY PRIMARY KEY,
	CATEGORY_NAME VARCHAR(20),
	NAME NVARCHAR(40),
	TYPE NVARCHAR(40), --1:SMART 2:INTERNET 3:CONG 4:THUONG
	SIZE NVARCHAR(40),
	PRICE_IN FLOAT,
	PRICE_OUT FLOAT,
	COUNT INT,
)

GO

CREATE TABLE BILL_OUT(
	ID INT IDENTITY PRIMARY KEY,
	DATE_CHECKIN DATE,
	ID_CUSTOMER INT,
	TOTALPRICE FLOAT,
	STATUS INT,
	FOREIGN KEY (ID_CUSTOMER) REFERENCES CUSTOMER(ID),
)

GO

CREATE TABLE BILL_INFO(
	ID INT IDENTITY PRIMARY KEY,
	ID_BILL INT,
	ID_TV INT,
	COUNT INT,
	TOTAL_PRICE FLOAT,
	FOREIGN KEY (ID_TV) REFERENCES TIVI(ID),
	FOREIGN KEY (ID_BILL) REFERENCES BILL_OUT(ID)
)

GO

--CREATE TABLE WAREHOUSE(
--	ID_TV INT,
--	COUNT INT,
--	FOREIGN KEY (ID_TV) REFERENCES TIVI(ID)
--)

--GO

--CREATE TABLE BILL_IN(
--	ID INT IDENTITY PRIMARY KEY,
--	ID_BILL_INFO VARCHAR(1000),
--	DATE_CHECKIN DATE,
--	TOTAL_PRICE FLOAT,
--	STATUS INT,
--	FOREIGN KEY ID_BILL_INFO REFERENCES BILL_INFO(ID)
--)

CREATE PROC USP_Login
@Username nvarchar(100), @Password nvarchar(1000)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE USERNAME = @Username AND PASSWORD = @Password
END
GO

INSERT INTO ACCOUNT(USERNAME, PASSWORD, DISPLAYNAME, ROLE) VALUES('truongan' , '1' , 'Truong An' , 1)

INSERT INTO TIVI(CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT, PRICE_IN , COUNT) VALUES('Panasonic' , N'Bình thường' , '2' , 51 , 6500000 , 400000 , 20)
INSERT INTO TIVI(CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT, PRICE_IN , COUNT) VALUES('Sony' , N'Bình thường' , '2' , 51 , 6500000 , 400000 , 20)
INSERT INTO TIVI(CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT, PRICE_IN , COUNT) VALUES('Samsung' , N'Bình thường' , '2' , 51 , 6500000 , 400000 , 20)
INSERT INTO TIVI(CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT, PRICE_IN , COUNT) VALUES('LG' , N'Bình thường' , '2' , 51 , 6500000 , 400000 , 20)

select * from tivi where CATEGORY_NAME = 'Samsung' --or CATEGORY_NAME = 'Sony'

delete from tivi where name = 'cùi bắp'


select * from Tivi

select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT from tivi WHERE TYPE = '3'

insert into WAREHOUSE(ID_TV,COUNT) values (1,20)
insert into CUSTOMER(NAME,PHONE_NUMBER,TYPE,PAYCOUNT) values (N'Thái Trường An','0914518169',1,0)


SELECT * FROM ACCOUNT

select * from account where USERNAME = 'pntn0705'

USP_LOGIN 'pntn0705' , '1'

select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT , COUNT from tivi

delete BILL_INFO where 1=1
delete BILL_OUT where 1=1

ALTER TABLE TIVI DROP CK_COUNT