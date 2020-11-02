DROP DATABASE IF EXISTS RencontreExtraTerrestre
GO
CREATE DATABASE RencontreExtraterrestre
GO

USE RencontreExtraterrestre;

CREATE TABLE BaseMars  (
	BaseMarsId INT PRIMARY KEY IDENTITY(1, 1),
	BaseMarsName VARCHAR(100) NOT NULL,
)
GO
CREATE TABLE Continent  (
	ContinentId INT PRIMARY KEY IDENTITY(1, 1),
	ContinentName VARCHAR(100) NOT NULL,
)
GO
CREATE TABLE EmpereurMartien (
	EmpereurMartienId INT PRIMARY KEY IDENTITY(1, 1),
	EmpereurMartienName VARCHAR(100) NOT NULL,
)
GO
CREATE TABLE Terrien (
	TerrienId INT PRIMARY KEY IDENTITY(1, 1),
	TerrienName VARCHAR(100) NOT NULL,
	FK_ContinentId INT FOREIGN KEY REFERENCES Continent(ContinentId) NOT NULL,

)
GO
CREATE TABLE Martien (
  MartienId INT PRIMARY KEY IDENTITY(1, 1)NOT NULL,
  MartienName VARCHAR (100) NOT NULL,
  MartienGrade INT NOT NULL,
  FK_TerrienId INT FOREIGN KEY REFERENCES Terrien(TerrienId),
  FK_EmpereurId INT FOREIGN KEY REFERENCES EmpereurMartien(EmpereurMartienId),
  FK_BaseMarsId INT FOREIGN KEY REFERENCES BaseMars(BaseMarsId),
)
GO
CREATE TABLE SuperieurMartien(
	SuperieurMartienId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	FK_EmpereurMartienId INT FOREIGN KEY REFERENCES EmpereurMartien(EmpereurMartienId),
	FK_MartienId INT FOREIGN KEY REFERENCES Martien(MartienId)
)
INSERT INTO BaseMars (BaseMarsName)
	VALUES ('Base verte'),('Base jaune'),('Base Blanche')
GO
INSERT INTO Continent (ContinentName)
	VALUES ('Europe'),('Afrique'),('Asie'),('Amerique'),('Océanie'),('Atlantide')
GO
INSERT INTO Terrien(TerrienName,FK_ContinentId)
	VALUES ('Vincent',1),('Imany',2),('Amida',3),('Jason',4),('Titouan',5),('Poseidon',6)
GO
INSERT INTO EmpereurMartien(EmpereurMartienName)
	VALUES ('Empereur de tous les empereurs')
GO
INSERT INTO Martien (MartienName,MartienGrade,FK_EmpereurId,FK_BaseMarsId,FK_TerrienId)
	VALUES ('M’gann',0,1,1,6),('M’orzz',3,1,2,5),('M’yrnn',5,1,3,4),('J’onnz',10,1,2,3),('M’yri’ah',100,1,1,2),('taH’ahL',150,1,3,1)
GO

SELECT * FROM Martien
SELECT *FROM Terrien

SELECT MartienName,TerrienName AS 'Terrien référent' ,BaseMarsName AS 'Base martienne de référence', ContinentName AS 'Continent de référence'
	FROM Martien 
		INNER JOIN Terrien ON FK_TerrienId=TerrienId
		INNER JOIN BaseMars ON FK_BaseMarsId=BaseMarsId
		INNER JOIN Continent ON FK_ContinentId=ContinentId