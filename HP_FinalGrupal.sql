-- Creando las tablas

CREATE TABLE Peliculas (
    CooPeli     CHAR(5) NOT NULL,
    TituloPeli  VARCHAR2(50) NOT NULL,
    AniOEsPeli  DATE NOT NULL,
    DuracPeli   NUMBER NOT NULL,
    GeneroPeli  VARCHAR2(20) NOT NULL,
    IdiomaPeli  VARCHAR2(12) NOT NULL,
    SinopPeli   VARCHAR2(120) NOT NULL,
    PresuPeli   NUMBER NOT NULL,
    IngresoPeli NUMBER NOT NULL,
    CodClasi   VARCHAR2(12) NOT NULL,  
    CodEstud    CHAR(5) NOT NULL, 
    CodDirec    CHAR(5) NOT NULL,
    CONSTRAINT pk_Pelicula PRIMARY KEY(CooPeli)
)

--CREATE TABLE Directores (
--    CodDirec    CHAR(5) NOT NULL,
--    nombreDirec VARCHAR2(30) NOT NULL,  
--    nacionDirec VARCHAR2(12) NOT NULL,
--    CONSTRAINT pk_Directores PRIMARY KEY(CodDirec)
--);

--CREATE TABLE Estudios (
--    CodEstud    CHAR(5) NOT NULL,
--    CONSTRAINT pk_Estudios PRIMARY KEY(CodEstud)
--);










