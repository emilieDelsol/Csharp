CREATE DATABASE Dojo031120
GO
USE  Dojo031120
CREATE TABLE Provider (
	ProviderId INT PRIMARY KEY IDENTITY (1,1),
	ProviderName VARCHAR (100) 
	)
GO
CREATE TABLE Product (
	ProductId INT PRIMARY KEY IDENTITY (1,1),
	ProductName VARCHAR (100) NOT NULL,
	ProductPrice DECIMAL NOT NULL
)
GO
CREATE TABLE Shop(
	ShopId INT PRIMARY KEY IDENTITY (1,1),
	StreetName VARCHAR(100) NOT NULL,
	StreetNb VARCHAR(100) NOT NULL
)
GO
CREATE TABLE Stock(
	StockId INT PRIMARY KEY IDENTITY (1,1),
	FK_ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
	FK_ProviderId INT FOREIGN KEY REFERENCES Provider(ProviderId),
	FK_ShopId INT FOREIGN KEY REFERENCES Shop(ShopId)
)
GO
ALTER TABLE Stock ADD StockCount DECIMAL NOT NULL
GO

INSERT INTO Product (ProductName,ProductPrice)
	VALUES ('Tomato',2.5),('Banana',0.99),('flour',0.90),('Desherbant',35)
GO
INSERT INTO Provider(ProviderName)
	VALUES ('Monsanto'),('Biocoop');
GO
INSERT INTO Shop(StreetName, StreetNb)
	VALUES ('WallStreet', '5èmeAvenue'), ('RuedesLégumes', '55') 
GO
INSERT INTO Stock(StockCount,FK_ProductId,FK_ProviderId,FK_ShopId)
	VALUES (300,1,2,2),(600,2,2,2),(1000,3,2,2),(200,1,1,1),(230,2,1,1),(5000,3,1,1)
GO
/*Requête n°1 Tous les stock d'un produit par produit*/
SELECT  Product.ProductName, sum(Stock.StockCount) AS 'Product in stock'
	FROM Stock
	INNER JOIN Product ON ProductId=FK_ProductId
		GROUP BY ProductName

/*Requete n°2 Le nombre de provider par produit*/
SELECT ProductName, COUNT(FK_ProviderId) AS 'Number of providers'
	From Stock 
	INNER JOIN Product ON ProductId=FK_ProductId
	INNER JOIN Provider ON ProviderId=FK_ProviderId
	GROUP BY ProductName

/* Les 2 premières requêtes en une*/
SELECT  Product.ProductName, sum(Stock.StockCount) AS 'Product in stock', COUNT(FK_ProviderId) AS 'Number of provider'
	FROM Stock
	INNER JOIN Product ON ProductId=FK_ProductId
		GROUP BY ProductName
SELECT ProviderName + ' ' AS [text()]
FROM [Provider] 
FOR XML PATH('')

SELECT ProviderName + ' ' AS 'Fournisseur'
FROM [Provider] 
FOR JSON PATH


SELECT ProductName, COUNT(FK_ProviderId) AS Fournisseur, STRING_AGG(ProviderName, ',')AS 'Providers'
FROM Stock
INNER JOIN Product ON FK_ProductId = ProductId
INNER JOIN Provider ON FK_ProviderId = ProviderId
GROUP BY ProductName