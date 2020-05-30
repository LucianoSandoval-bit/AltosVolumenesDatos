USE keyspace1;
CREATE TABLE Regiones
(ID INT PRIMARY KEY,
 REGION TEXT,
 FechaMod set<DATE>,
 FechaRG DATE,
 RegistradoPor TEXT,
 Caracteristica TEXT
);
INSERT INTO Regiones(ID,REGION,FechaMod,FechaRG,RegistradoPor,Caracteristica)
VALUES(2,'Region2',{'1999-01-29','1999-02-28'},'1999-01-27','ADMIN','CharRegion12');
SELECT Fechamod FROM Regiones ;