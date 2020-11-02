DROP DATABASE IF EXISTS Magasin 
GO
CREATE DATABASE Magasin
GO

USE Magasin;


CREATE TABLE Category (
	CategoryId INT PRIMARY KEY IDENTITY(1, 1),
	CategoryName VARCHAR(100) NOT NULL,
)

GO

CREATE TABLE Product (
	ProductId INT PRIMARY KEY IDENTITY(1, 1),
	ProductName VARCHAR(100) NOT NULL,
	ProductPrice DECIMAL NOT NULL,
	FK_CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId) NOT NULL
)
GO

CREATE TABLE ShoppingCart(
	ShoppingCartId INT PRIMARY KEY IDENTITY(1,1),
	ShoppingCartDate DATETIME NOT NULL,
	FK_ProductId INT FOREIGN KEY REFERENCES Product(ProductId) NOT NULL
)
GO
CREATE TABLE Stock (
	StockId INT PRIMARY KEY IDENTITY(1, 1),
	FK_ProductId INT FOREIGN KEY REFERENCES Product(ProductId) NOT NULL,
	Quantity INT NOT NULL
	
)
GO

INSERT INTO Category (CategoryName)
	VALUES ('Frais'),('Epicerie'),('Boissons'),('Jouets')
GO
INSERT INTO Product (ProductName,ProductPrice,FK_CategoryId)
	VALUES 
		('Jambon',4,1),('Oeufs',3,1),('Oignons',1,1),
		('PunkIPA',8,3),('Tropico',6,3),('Negrita',8,3),('Gaillac',9,3),
		('Uno',10,4),('Monopoli',15,4),('PS4',299,4),('ResidentEvil',20,4)
GO
 
INSERT INTO Stock (FK_ProductId,Quantity)
	VALUES (1,915),(2,916),(3,190),(4,925),(5,100),(6,150),(7,946),(8,895),(9,999),(10,666),(11,666)
GO
INSERT INTO ShoppingCart(ShoppingCartDate,FK_ProductId) 
	VALUES ('2018-01-01 00:50:00',11),('2018-01-01 00:50:00',10),('2018-01-01 00:50:00',9),('2018-01-01 00:50:00',8),('2018-01-01 00:50:00',7),('2018-01-01 00:50:00',6),('2018-01-01 00:50:00',5),('2018-01-01 00:50:00',4),('2018-01-01 00:50:00',3),('2018-01-01 00:50:00',2),('2018-01-01 00:50:00',1),
	(GETDATE(),1),('2019-01-01 00:00:00',1),('2020-01-11 00:00:00',2),('2019-01-09 00:00:00',3),('2020-01-04 00:00:00',4),('2019-01-11 00:00:00',5),('2019-01-05 00:00:00',6),('2019-02-05 00:00:00',7),('2019-01-03 00:00:00',8),('2020-01-04 00:00:00',9),('2019-03-02 00:00:00',10),('2019-02-07 00:00:00',11),('2019-04-12 00:00:00',10),('2019-07-11 00:00:00',9),('2019-09-10 00:00:00',8),('2019-09-12 00:00:00',7),('2019-05-06 00:00:00',6),('2019-06-05 00:00:00',5)
	

	/*IF EXISTS (SELECT COUNT(FK_ProductId)  FROM ShoppingCart WHERE FK_ProductId=1)
		UPDATE Stock SET Quantity = Quantity - 1 WHERE Stock.FK_ProductId=1
		
SELECT COUNT(ShoppingCart.FK_ProductId) FROM ShoppingCart WHERE FK_ProductId=1

SELECT *
	FROM Product WHERE FK_CategoryId=1
SELECT *FROM ShoppingCart
SELECT *
	FROM Product WHERE FK_CategoryId=2

SELECT *
	FROM Product WHERE FK_CategoryId=3

SELECT StockId AS 'Identifiant',ProductName AS 'Nom du produit',ProductPrice AS 'Prix en €', Quantity AS 'Quantité disponible'
	FROM Stock 
		INNER JOIN Product Category ON ProductId=StockId WHERE FK_CategoryId=1
		

SELECT ProductName AS 'Nom du produit',ProductPrice AS 'Prix en €',ShoppingCartDate AS 'Date de mon achat' 
	FROM ShoppingCart 
		INNER JOIN Product ON ProductId=FK_ProductId*/

SELECT COUNT(ShoppingCart.ShoppingCartId) AS 'Nombre d`achats Total' , CategoryName 
	FROM ShoppingCart 
		INNER JOIN Product ON FK_ProductId=ProductId 
		INNER JOIN Category ON FK_CategoryId=CategoryId 
			GROUP BY CategoryName

SELECT SUM(Product.ProductPrice) AS 'Somme des prix des produits', CategoryName 
	FROM ShoppingCart INNER JOIN Product ON FK_ProductId=ProductId 
		INNER JOIN Category ON FK_CategoryId=CategoryId 
			GROUP BY CategoryName

SELECT COUNT(ShoppingCart.ShoppingCartId) AS 'Nombre d`achats a partir du 2018-31-12 23:59:59' , CategoryName 
	FROM ShoppingCart 
		INNER JOIN Product ON FK_ProductId=ProductId 
		INNER JOIN Category ON FK_CategoryId=CategoryId 
			WHERE ShoppingCartDate > '2018-31-12 23:59:59'
			GROUP BY CategoryName 
			
			