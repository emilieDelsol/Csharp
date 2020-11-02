DROP DATABASE IF EXISTS School
GO
CREATE DATABASE School
GO

USE School;



CREATE TABLE Class (
	ClassId INT PRIMARY KEY IDENTITY(1, 1),
	ClassName VARCHAR(100) NOT NULL,
)
GO
CREATE TABLE Pupil (
	PupilId INT PRIMARY KEY IDENTITY(1, 1),
	PupilName VARCHAR(100) NOT NULL,
	FK_ClassId INT FOREIGN KEY REFERENCES Class(ClassId) NOT NULL,
)
GO
CREATE TABLE Topic (
	TopicId INT PRIMARY KEY IDENTITY(1, 1),
	TopicName VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Exam (
	ExamId INT PRIMARY KEY IDENTITY(1, 1),
	ExamNote INT NOT NULL,
	FK_PupilId INT FOREIGN KEY REFERENCES Pupil(PupilId) NOT NULL,
	FK_TopicId INT FOREIGN KEY REFERENCES Topic(TopicId) NOT NULL,
)
GO
INSERT INTO Class (ClassName)
	VALUES ('C#'),('JS')
GO
INSERT INTO Pupil (PupilName,FK_ClassId)
	VALUES ('M’gann',1),('M’orzz',1),('M’yrnn',1),('J’onnz',2),('M’yri’ah',2)
GO
INSERT INTO Topic (TopicName)
	VALUES ('APIREST'),('BDD'),('REACT'),('VUEJS'),('ALGO')
GO
INSERT INTO Exam (ExamNote,FK_PupilId,FK_TopicId)
	VALUES (10,1,1),(20,1,2),(19,1,3),(16,1,4),(13,1,5),
			(19,2,1),(10,2,2),(12,2,3),(14,2,4),(14,2,5),
			(10,3,1),(5,3,2),(16,3,3),(12,3,4),(8,3,5),
			(15,4,1),(2,4,2),(17,4,3),(7,4,4),(18,4,5),
			(20,5,1),(20,5,2),(9,5,3),(9,5,4),(1,5,5)
GO
/*
SELECT AVG(Exam.ExamNote) AS 'Moyenne de tous les examens' FROM Exam
SELECT PupilId, PupilName, ClassName FROM Pupil INNER JOIN Class ON FK_ClassId=ClassId
SELECT TopicName,AVG(ExamNote) AS 'Average' FROM Topic INNER JOIN Exam ON FK_TopicId=TopicId  GROUP BY TopicName 
SELECT * FROM Exam
SELECT AVG(Exam.ExamNote) AS 'Moyenne de l`élève' FROM Exam WHERE FK_PupilId=1 
SELECT COUNT(Pupil.PupilName) AS 'Nombre total d`élèves'  FROM Pupil
SELECT COUNT(Pupil.PupilName) AS 'Nombre élèves en C#'  FROM Pupil WHERE FK_ClassId=1
SELECT COUNT(Pupil.PupilName) AS 'Nombre élèves en JS'  FROM Pupil WHERE FK_ClassId=2
SELECT COUNT(Pupil.PupilName) AS 'Nombre élèves ' FROM Pupil GROUP BY FK_ClassId
*/

SELECT COUNT(Pupil.PupilName) AS 'Nombre total d`élèves'  FROM Pupil

SELECT COUNT(Pupil.PupilName) AS 'Nombre élèves ' , ClassName FROM Pupil 
	INNER JOIN Class ON FK_ClassId=ClassId 
	GROUP BY FK_ClassId, ClassName

SELECT ClassName,PupilName,AVG(ExamNote) 'Moyenne de l`élève' FROM Class 
	INNER JOIN Pupil ON FK_ClassId=ClassId 
	INNER JOIN Exam ON FK_PupilId=PupilId 
	GROUP BY ClassName,PupilName

SELECT ClassName, AVG(ExamNote) 'Moyenne de la classe' FROM Class 
	INNER JOIN Pupil ON FK_ClassId=ClassId 
	INNER JOIN Exam ON FK_PupilId=PupilId 
	GROUP BY ClassName
 