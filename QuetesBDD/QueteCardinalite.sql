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
	ShoppingCart INT PRIMARY KEY IDENTITY(1,1),
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
		('Jambon',4,1),('Oeufs',3,1),('Oignons',1,1),('Bananes',0.99,1),('Tomates',2,1),('Oranges',3.99,1),('Beurre',3,1),('Lait',3,1),('PouletFermier',5.99,1),
		('Riz',2,2),('Pates',2.2,2),('Sucre',0.99,2),('Farine',2,2),('Miel',4.99,2),('Levure',2,2),
		('PunkIPA',2,3),('Tropico',2,3),('Negrita',8,3),('Gaillac',5,3),
		('Uno',2,4),('Monopoli',2,4),('PS4',2,4),('ResidentEvil',2,4)
GO
INSERT INTO ShoppingCart(ShoppingCartDate,FK_ProductId) 
	VALUES(GETDATE(),1)
		UPDATE Stock SET Quantity=Quantity-1 WHERE StockId = 1
GO 
INSERT INTO Stock (FK_ProductId,Quantity)
	VALUES (1,5),(2,6),(3,10),(4,25),(5,100),(6,150),(7,6),(8,85),(9,45),(10,16),(11,15),(12,19),(13,50),(14,93),(15,178),(16,12),(17,32),(18,58),(19,48),(20,69),(21,95),(22,66),(23,666)

SELECT *
	FROM Product WHERE FK_CategoryId=1

SELECT *
	FROM Product WHERE FK_CategoryId=2

SELECT *
	FROM Product WHERE FK_CategoryId=3

SELECT StockId AS 'Identifiant',ProductName AS 'Nom du produit',ProductPrice AS 'Prix en €', Quantity AS 'Quantité disponible'
	FROM Stock 
		INNER JOIN Product Category ON ProductId=StockId WHERE FK_CategoryId=1
		

SELECT ProductName AS 'Nom du produit',ProductPrice AS 'Prix en €',ShoppingCartDate AS 'Date de mon achat' 
	FROM ShoppingCart 
		INNER JOIN Product ON ProductId=FK_ProductId