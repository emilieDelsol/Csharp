﻿SELECT Count(AnimalId) , SpecieName FROM Animals INNER JOIN Specie ON Specie.SpecieID=Animals.SpecieID GROUP BY Specie.SpecieName