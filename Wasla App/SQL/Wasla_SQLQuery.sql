CREATE DATABASE WaslaDB;
USE WaslaDB;

CREATE TABLE Compagnies (
    CompagnieID INT PRIMARY KEY,
    NomCompagnie NVARCHAR(100)
);

CREATE TABLE Villes (
    VilleID INT PRIMARY KEY,
    NomVille NVARCHAR(100)
);

CREATE TABLE LignesBus (
    LigneID INT PRIMARY KEY,
    NomLigne NVARCHAR(100),
    VilleID INT,
    FOREIGN KEY (VilleID) REFERENCES Villes(VilleID)
);

CREATE TABLE Billets (
    BilletID INT PRIMARY KEY,
    LigneID INT,
    CompagnieID INT,
    NomUtilisateur NVARCHAR(100),
    DateVoyage DATE,
    NumeroSiege INT,
    StatutPaiement NVARCHAR(50),
    FOREIGN KEY (LigneID) REFERENCES LignesBus(LigneID),
    FOREIGN KEY (CompagnieID) REFERENCES Compagnies(CompagnieID)
);

CREATE TABLE Paiements (
    PaiementID INT PRIMARY KEY,
    BilletID INT,
    Montant DECIMAL(10,2),
    MethodePaiement NVARCHAR(50),
    DatePaiement DATE,
    FOREIGN KEY (BilletID) REFERENCES Billets(BilletID)
);


INSERT INTO Compagnies (CompagnieID, NomCompagnie) VALUES 
(1, 'Atlas'), 
(2, 'CTM'),
(3, 'Supratours'),
(4, 'Transports Ghazala');

INSERT INTO Villes (VilleID, NomVille) VALUES 
(1, 'Casablanca'), 
(2, 'Rabat'),
(3, 'Marrakech'),
(4, 'Tanger'),
(5, 'Agadir'),
(6, 'Fès'),
(7, 'Meknès'),
(8, 'Oujda'),
(9, 'Tétouan'),
(10, 'Laâyoune');

INSERT INTO LignesBus (LigneID, NomLigne, VilleID) VALUES 
(1, 'Casablanca - Rabat', 1), 
(2, 'Rabat - Marrakech', 2),
(3, 'Marrakech - Agadir', 3),
(4, 'Tanger - Tétouan', 4),
(5, 'Fès - Meknès', 5),
(6, 'Meknès - Rabat', 6),
(7, 'Oujda - Casablanca', 7),
(8, 'Laâyoune - Agadir', 8),
(9, 'Agadir - Fès', 9),
(10, 'Tanger - Casablanca', 10);


SELECT * FROM Billets
SELECT * FROM Compagnies
SELECT * FROM LignesBus
SELECT * FROM Villes
SELECT * FROM Paiements

Data Source=DESKTOP-3HOM7H2\SQLEXPRESS;Initial Catalog=WaslaDB;Integrated Security=True;Encrypt=False

ALTER TABLE LignesBus
ADD VilleDepartID INT,
    VilleArriveeID INT;

UPDATE LignesBus SET VilleDepartID = 1, VilleArriveeID = 2 WHERE LigneID = 1; -- Casablanca - Rabat
UPDATE LignesBus SET VilleDepartID = 2, VilleArriveeID = 3 WHERE LigneID = 2; -- Rabat - Marrakech
UPDATE LignesBus SET VilleDepartID = 3, VilleArriveeID = 5 WHERE LigneID = 3; -- Marrakech - Agadir
UPDATE LignesBus SET VilleDepartID = 4, VilleArriveeID = 9 WHERE LigneID = 4; -- Tanger - Tétouan
UPDATE LignesBus SET VilleDepartID = 6, VilleArriveeID = 7 WHERE LigneID = 5; -- Fès - Meknès
UPDATE LignesBus SET VilleDepartID = 6, VilleArriveeID = 2 WHERE LigneID = 6; -- Meknès - Rabat
UPDATE LignesBus SET VilleDepartID = 8, VilleArriveeID = 1 WHERE LigneID = 7; -- Oujda - Casablanca
UPDATE LignesBus SET VilleDepartID = 10, VilleArriveeID = 5 WHERE LigneID = 8; -- Laâyoune - Agadir
UPDATE LignesBus SET VilleDepartID = 5, VilleArriveeID = 6 WHERE LigneID = 9; -- Agadir - Fès
UPDATE LignesBus SET VilleDepartID = 4, VilleArriveeID = 1 WHERE LigneID = 10; -- Tanger - Casablanca


ALTER TABLE LignesBus
ADD CONSTRAINT FK_LignesBus_VilleDepartID FOREIGN KEY (VilleDepartID) REFERENCES Villes(VilleID);

ALTER TABLE LignesBus
ADD CONSTRAINT FK_LignesBus_VilleArriveeID FOREIGN KEY (VilleArriveeID) REFERENCES Villes(VilleID);

DECLARE @VilleDepart NVARCHAR(100);
DECLARE @VilleArrivee NVARCHAR(100);

SET @VilleDepart = 'Rabat';
SET @VilleArrivee = 'Casablanca';

SELECT L.NomLigne, C.NomCompagnie, V1.NomVille AS VilleDepart, V2.NomVille AS VilleArrivee
FROM LignesBus L
JOIN Compagnies C ON L.CompagnieID = C.CompagnieID
JOIN Villes V1 ON L.VilleDepartID = V1.VilleID
JOIN Villes V2 ON L.VilleArriveeID = V2.VilleID
WHERE V1.NomVille = @VilleDepart AND V2.NomVille = @VilleArrivee;

SELECT CompagnieID FROM Compagnies;

EXEC sp_help 'LignesBus';

ALTER TABLE LignesBus
ADD CompagnieID INT;

ALTER TABLE LignesBus
ADD CONSTRAINT FK_LignesBus_Compagnies
FOREIGN KEY (CompagnieID) REFERENCES Compagnies(CompagnieID);


UPDATE LignesBus
SET CompagnieID = 1
WHERE LigneID IN (1, 2); 

UPDATE LignesBus
SET CompagnieID = 2
WHERE LigneID IN (3, 4);

UPDATE LignesBus
SET CompagnieID = 4
WHERE LigneID IN (5, 6);



ALTER TABLE Billets
ADD NewBilletID INT IDENTITY(1,1);


ALTER TABLE Billets
DROP COLUMN BilletID;


EXEC sp_rename 'Billets.NewBilletID', 'BilletID', 'COLUMN';



CREATE TABLE Billets_New (
    NewBilletID INT IDENTITY(1,1) PRIMARY KEY,
    LigneID INT,
    CompagnieID INT,
    NomUtilisateur NVARCHAR(100),
    DateVoyage DATE,
    NumeroSiege INT,
    StatutPaiement NVARCHAR(50)
);

INSERT INTO Billets_New (LigneID, CompagnieID, NomUtilisateur, DateVoyage, NumeroSiege, StatutPaiement)
SELECT LigneID, CompagnieID, NomUtilisateur, DateVoyage, NumeroSiege, StatutPaiement
FROM Billets;


ALTER TABLE Paiements DROP CONSTRAINT FK__Paiements__Bille__5441852A;






