DROP DATABASE IF EXISTS ChainStore
GO
CREATE DATABASE ChainStore
GO
USE ChainStore

CREATE TABLE Category(
	CategoryId INT PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(100) NOT NULL
)
GO
CREATE TABLE City(
	CityId INT PRIMARY KEY IDENTITY(1,1),
	CityName VARCHAR(100) NOT NULL
)
GO
CREATE TABLE Shop(
	ShopId INT PRIMARY KEY IDENTITY(1,1),
	/*ShopName VARCHAR,*/
	FK_CityId INT FOREIGN KEY REFERENCES City(CityId),
)
GO
CREATE TABLE Employe(
	EmployeId INT PRIMARY KEY IDENTITY(1,1),
	EmployeName VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Product(
	ProductId INT PRIMARY KEY IDENTITY(1,1),
	ProductName VARCHAR (100) NOT NULL ,
	ProductPrice INT NOT NULL,
	FK_CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId)
)
GO
CREATE TABLE ProductSale (
	ProductSaleId INT PRIMARY KEY IDENTITY(1,1),
	BougthAt DATETIME NOT NULL,
	FK_ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
	Fk_ShopId INT FOREIGN KEY REFERENCES Shop(ShopId)
)
GO 
CREATE TABLE ProductStock(
	ProductStockId INT PRIMARY KEY IDENTITY(1,1),
	Quantity INT NOT NULL,
	FK_ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
	FK_ShopId  INT FOREIGN KEY REFERENCES Shop(ShopId),
)
GO
INSERT INTO Category(CategoryName)
	VALUES ('Alcool'),('Frais'),('Epicerie'),('Jeux')
GO
INSERT INTO Product(ProductName,ProductPrice,FK_CategoryId)
	VALUES ('Rhum',8,1),('Vodka',7,1),('Get27',10,1),('Champagne',15,1),
			('Steack',9.8,2),('Salade',0.99,2),('Lait',1.99,2),('Oeufs',2.5,2),
			('Riz',2.6,3),('Farine',0.99,3),('Sucre',0.70,3),('gateaux',3.5,3),
			('PS5',299,4),('Resident Evil',59.99,4),('Uno',4.5,4),('Jeu de cartes',1.99,4)
GO

INSERT INTO City(CityName)
	VALUES ('Toulouse'),('Strasbourg'),('Montpellier')
GO
INSERT INTO Employe(EmployeName)
	VALUES ('Adrien'),('Hervé'),('Sebastien'),('Gab'),('Colas'),('Emilie'),('Fabien'),('Maîlys'),('Sophie')
GO
INSERT INTO Shop(FK_CityId)
	VALUES (1),(2),(3)
GO
INSERT INTO ProductSale(FK_ProductId,BougthAt,Fk_ShopId)
	VALUES (1,GETDATE(),1),(2,GETDATE(),1),(3,GETDATE(),1),(4,GETDATE(),1),(5,GETDATE(),1),(6,GETDATE(),1),(7,GETDATE(),1),(8,GETDATE(),1),(9,GETDATE(),1),(10,GETDATE(),1),(11,GETDATE(),1),(12,GETDATE(),1),(13,GETDATE(),1),(14,GETDATE(),1),(15,GETDATE(),1),(16,GETDATE(),1),
			(12,'2020-25-12 00:00:00',1),(13,'2020-25-12 00:00:00',1),(14,'2020-25-12 00:00:00',1),(15,'2020-25-12 00:00:00',1),(16,'2020-25-12 00:00:00',1),
			(1,GETDATE(),2),(2,GETDATE(),2),(3,GETDATE(),2),(4,GETDATE(),2),(5,GETDATE(),2),(14,'2020-25-12 00:00:00',2),(15,'2020-25-12 00:00:00',2),(16,'2020-25-12 00:00:00',2),
			(8,GETDATE(),3),(9,GETDATE(),3),(10,GETDATE(),3),(11,GETDATE(),3),(12,GETDATE(),3),(13,'2020-25-12 00:00:00',3),(14,'2020-25-12 00:00:00',3),(15,'2020-25-12 00:00:00',3),(16,'2020-25-12 00:00:00',3)
GO
INSERT INTO ProductStock (FK_ShopId,FK_ProductId,Quantity)
	VALUES (1,1,999),(1,2,999),(1,3,999),(1,4,999),(1,5,999),(1,6,999),(1,7,999),(1,8,999),(1,9,999),(1,10,999),(1,11,999),(1,12,999),(1,13,999),(1,14,999),(1,15,999),(1,16,999),
			(2,1,999),(2,2,999),(2,3,999),(2,4,999),(2,5,999),(2,6,999),(2,7,999),(2,8,999),(2,9,999),(2,10,999),(2,11,999),(2,12,999),(2,13,999),(2,14,999),(2,15,999),(2,16,999),
			(3,1,999),(3,2,999),(3,3,999),(3,4,999),(3,5,999),(3,6,999),(3,7,999),(3,8,999),(3,9,999),(3,10,999),(3,11,999),(3,12,999),(3,13,999),(3,14,999),(3,15,999),(3,16,999)
USE ChainStore
/*SELECT * FROM Employe
SELECT * FROM City
SELECT * FROM Shop
SELECT * FROM ProductSale
SELECT * FROM Category
SELECT * FROM Product

Select CityName from Shop INNER JOIN City on FK_CityId=CityId GROUP BY CityName

Select CityName 
from Shop 
	INNER JOIN City on FK_CityId=CityId 
	INNER JOIN ProductStock ON FK_ShopId=ShopId
	GROUP BY CityName

SELECT * FROM ProductStock

SELECT * FROM Shop*/

/*1ere requête demandée dans la deuxieme partie de l'atelier: Une qui renvoie le total du montant des ventes de tous les produits pour chaque magasin*/ 
SELECT CityName AS 'Nom de la ville' ,SUM(ProductPrice) AS 'Total des ventes en €'
FROM ProductSale 
	INNER JOIN Product ON FK_ProductId=FK_ProductId		
	INNER JOIN Shop ON Fk_ShopId=ShopId 
	INNER JOIN City ON FK_CityId=CityId
		GROUP BY CityName

/* 2eme requête demandée dans la deuxieme partie de l'atelier:  le total du nombre ventes de produits pour chaque catégorie chaque mois*/
SELECT CategoryName AS 'Catégories',DATENAME(month, DATEADD(month,MONTH(BougthAt), CAST('2008-01-01' AS datetime))) AS 'Mois', SUM(ProductPrice) AS 'Somme des prix arrondis en €'
FROM Product 
	INNER JOIN Category ON CategoryId=FK_CategoryId 
	INNER JOIN ProductSale ON FK_ProductId=ProductId 
		GROUP BY CategoryName, MONTH(BougthAt)

/*
SELECT DATENAME(month, DATEADD(month,MONTH(BougthAt), CAST('2008-01-01' AS datetime))) FROM ProductSale

SELECT MONTH(BougthAt) AS 'Mois', SUM(ProductPrice) 'Total des ventes en €'
FROM ProductSale 
	INNER JOIN Product ON FK_ProductId=ProductId
	GROUP BY MONTH(BougthAt)*/