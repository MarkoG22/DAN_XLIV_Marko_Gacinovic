IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Pizzeria')
CREATE database Pizzeria;
GO

-- deleting tables
IF OBJECT_ID('tblMenu', 'U') IS NOT NULL DROP TABLE tblMenu;
IF OBJECT_ID('tblOrder', 'U') IS NOT NULL DROP TABLE tblOrder;

use Pizzeria
CREATE TABLE tblMenu (ArticleID int IDENTITY(1,1) PRIMARY KEY NOT NULL, ArticleName nvarchar(50), Price int);

use Pizzeria
INSERT INTO tblMenu (ArticleName, Price) 
VALUES ('SmallPizza', 350),
('MediumPizza', 500),
('BigPizza', 700),
('JumboPizza', 900);

use Pizzeria
CREATE TABLE tblOrder (OrderID int IDENTITY(1,1) PRIMARY KEY NOT NULL, SmallPizza int, MediumPizza int, BigPizza int, JumboPizza int,
 OrderDate datetime, CustomerJMBG nvarchar(13) check(len(CustomerJMBG) = 13) NOT NULL UNIQUE, OrderStatus nvarchar(50),
 CONSTRAINT checkJMBG check(CustomerJMBG not like '%[^0-9]%')); 