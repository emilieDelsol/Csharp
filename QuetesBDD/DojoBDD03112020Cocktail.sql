CREATE DATABASE MyCocktail
GO 
USE MyCocktail

CREATE TABLE Cocktail (
	Cocktailid INT PRIMARY KEY IDENTITY(1,1),
    CocktailName VARCHAR(50) NOT NULL
)
GO
CREATE TABLE Category (
	CategoryId INT PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(100)
)
GO
CREATE TABLE Ingredient (
	IngredientId INT PRIMARY KEY IDENTITY(1,1),
    IngredientName VARCHAR(50) NOT NULL,
	FK_CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId) 
)
GO
CREATE TABLE Recette (
	RecetteId INT PRIMARY KEY IDENTITY(1,1),
	Quantity INT NOT NULL,
	FK_IngredientId INT FOREIGN KEY REFERENCES Ingredient(IngredientId),
	FK_CocktailId INT FOREIGN KEY REFERENCES Cocktail(CocktailId)
)
GO


INSERT INTO Category(CategoryName)
	VALUES ('Alcool'),('Soft'),('Fruits'),('accessoires')
GO


INSERT INTO Ingredient(IngredientName, FK_CategoryId)
VALUES ('Whisky',1), ('Rhum',1), ('Tequila',1), ('Vodka',1), ('Gin',1), ('Curaçao',1), ('Cointreau',1),
('Champagne',1),
('Coca',2), ('Perrier', 2), ('Limonade', 2), ('Jus Citron vert', 2), ('Jus Camberry',2),
('Citron', 3), ('Menthe', 3), ('Sucre Canne', 3),('Liqueur de Peche',1),('Jus d ananas',2),
('Glace',4), ('Sirop de Violette', 2), ('Jus de Pomme', 2)
GO
INSERT INTO Cocktail(CocktailName)
VALUES ('Mojito'), ('Cuba Libre'), ('Sex On the Beach'), ('Margarita'), ('Cosmopolitan'),
	('Kir Royal'), ('King Kong');
GO
INSERT INTO Recette(FK_CocktailId,FK_IngredientId,Quantity)
VALUES(1,2,5),(1,10,10),(1,16,3),(1,14,5),(1,15,4), (1,19, 5),
	(2,2,10),(2,9,10),(2,19, 5),
	(3,4,10),(3,17,5),(3,13,10),(3,18,7),(3,19, 5),
	(4,3,8), (4,7,8), (4,14,1), (4,6,3), (4,11,15), (4,19,5),
	(5,4,3), (5,6,3), (5,14,1), (5,13,2), (5,19, 5),
	(6,8,15), (6,20, 1),
	(7,21,3),(7,14,2),(7,11,3),(7,19,5)

	SELECT Count(IngredientID) AS 'Number of ingredient' ,IngredientName, STRING_AGG(CocktailName,' | ') AS 'Cocktail' 
	FROM Recette 
	INNER JOIN Ingredient ON IngredientId=FK_IngredientId
	INNER JOIN Cocktail ON Cocktailid=FK_CocktailId
	GROUP BY IngredientName

	SELECT CocktailName, STRING_AGG(IngredientName,' | ') AS 'Ingredients'
	FROM Recette
	INNER JOIN Ingredient ON FK_IngredientId=IngredientId
	INNER JOIN Cocktail ON Cocktailid=FK_CocktailId
	GROUP BY CocktailName
