-- Creando las tablas
CREATE TABLE Peliculas (
    CooPeli     CHAR(5) NOT NULL,
    TituloPeli  VARCHAR2(50) NOT NULL,
    AniOEsPeli  DATE NOT NULL,
    DuracPeli   NUMBER NOT NULL,
    IdiomaPeli  VARCHAR2(12) NOT NULL,
    SinopPeli   VARCHAR2(500) NOT NULL,
    PresuPeli   NUMBER NOT NULL,
    IngresoPeli NUMBER NOT NULL,
    CodEstud    CHAR(5) NOT NULL, 
    CodDirec    CHAR(5) NOT NULL,
    CodGenero   CHAR(5) NOT NULL,
    CodClasi    CHAR(5) NOT NULL,
    CONSTRAINT pk_Pelicula PRIMARY KEY(CooPeli)
);
-- El prosupuesto sera en Millones de dolares
INSERT INTO peliculas(CooPeli, TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli
, CodEstud, CodDirec, CodGenero, CodClasi) 
VALUES('P0001', 'Jurassic Park', '09/06/1993', 127, 'Ingles', 'El multimillonario John Hammond hace realidad su 
sueño de clonar dinosaurios del Jurásico y crear con ellos un parque temático en una isla. Antes de abrir el 
parque al público general, Hammond invita a una pareja de científicos y a un matemático para que comprueben la 
viabilidad del proyecto. Sin embargo, el sistema de seguridad falla y los dinosaurios se escapan.', 63, 
1029, 'E0001', 'D0001', 'G0001', 'C0001');

INSERT INTO peliculas(CooPeli, TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli
, CodEstud, CodDirec, CodGenero, CodClasi) 
VALUES('P0002', 'The Lost World: Jurassic Park', '19/05/1997', 129, 'Ingles', 'Cuatro años después del 
desastre en el Parque Jurásico, Ian Malcolm llega a una isla situada en Costa Rica, perteneciente a la Costa 
de las Cinco Muertes, donde los dinosaurios, modificados genéticamente, viven y se reproducen en libertad. Se 
trata de la llamada zona B, el lugar que servía como laboratorio.', 73, 
619, 'E0001', 'D0001', 'G0001', 'C0001');

SELECT * FROM peliculas;

--CREATE TABLE Directores (
--    CodDirec    CHAR(5) NOT NULL,
--    NombreDirec VARCHAR2(30) NOT NULL,  
--    NacionDirec VARCHAR2(12) NOT NULL,
--    CONSTRAINT pk_Directores PRIMARY KEY(CodDirec)
--);

--CREATE TABLE Estudios (
--    CodEstud    CHAR(5) NOT NULL,
--    CONSTRAINT pk_Estudios PRIMARY KEY(CodEstud)
--);

--CREATE TABLE GENERO (
--    CodGenero   CHAR(5) NOT NULL,
--    NombreGen   VARCHAR2(30) NOT NULL,
--    DescGen     VARCHAR2(125) NOT NULL,
--    CONSTRAINT pk_Genero PRIMARY KEY(CodGenero)
--);

--CREATE TABLE CLASIFICACION (
--    CodClasi   CHAR(5) NOT NULL,
--    NombClasi  VARCHAR2(30) NOT NULL,
--    DescClasi  VARCHAR2(125) NOT NULL,
--    CONSTRAINT pk_clasificacion PRIMARY KEY(CodClasi)
--);

-- Procedimientos almacenados de Peliculas
CREATE OR REPLACE PROCEDURE sp_ListarPeliculas (
    pelicula_cursor OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN pelicula_cursor FOR SELECT * FROM Peliculas ORDER BY TituloPeli ASC;
END;

--Desc peliculas;
EXEC sp_ListarPeliculas();
DROP PROCEDURE sp_ListarPeliculas;



