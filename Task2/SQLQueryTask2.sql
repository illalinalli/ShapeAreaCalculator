CREATE DATABASE Shop
GO

USE [Shop]
GO

--создадим таблицы для запросов
CREATE TABLE Products (
    ID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Products PRIMARY KEY,
    ProductName VARCHAR(50)
);

INSERT INTO Products (ProductName) VALUES 
('Телефон'),
('Ноутбук'),
('Наушники'),
('Коврик для мышки'),
('Салфетка для электроники');

CREATE TABLE Categories (
    ID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Categories PRIMARY KEY,
    CategoryName VARCHAR(50)
);

INSERT INTO Categories (CategoryName) VALUES 
('Электроника'),
('Бытовая техника'),
('Компьютеры');

--для связи многие-ко-многим
CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
	CONSTRAINT FK_ProductCategories_ProductsID FOREIGN KEY(ProductID) REFERENCES Products(ID),
	CONSTRAINT FK_ProductCategories_CategoryID FOREIGN KEY(CategoryID) REFERENCES Categories(ID)
);

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES 
(1, 1),
(1, 2),
(2, 3),
(3, 1),
(3, 2),
(4, NULL),
(5, NULL);

select * from dbo.Categories
select * from dbo.Products
select * from dbo.ProductCategories

SELECT p.ProductName, 
       COALESCE(c.CategoryName, 'Без категории') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.ID
ORDER BY p.ProductName;
