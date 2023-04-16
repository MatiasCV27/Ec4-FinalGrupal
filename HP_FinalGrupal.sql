-- Creando las tablas
CREATE TABLE Peliculas (
    CooPeli     CHAR(4) NOT NULL,
    TituloPeli  VARCHAR2(50) NOT NULL,
    AniOEsPeli  DATE NOT NULL,
    DuracPeli   NUMBER NOT NULL,
    IdiomaPeli  VARCHAR2(12) NOT NULL,
    SinopPeli   VARCHAR2(500) NOT NULL,
    PresuPeli   NUMBER NOT NULL,
    IngresoPeli NUMBER NOT NULL,
    CodEstud    CHAR(4) NOT NULL, 
    CodDirec    CHAR(4) NOT NULL,
    CodGenero   CHAR(4) NOT NULL,
    CodClasi    CHAR(4) NOT NULL,
    CONSTRAINT pk_Pelicula PRIMARY KEY(CooPeli)
);
-- El prosupuesto sera en Millones de dolares
INSERT INTO peliculas(CooPeli, TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli
, CodEstud, CodDirec, CodGenero, CodClasi) 
VALUES('P001', 'Jurassic Park', '09/06/1993', 127, 'Ingles', 'El multimillonario John Hammond hace realidad su 
sueño de clonar dinosaurios del Jurásico y crear con ellos un parque temático en una isla. Antes de abrir el 
parque al público general, Hammond invita a una pareja de científicos y a un matemático para que comprueben la 
viabilidad del proyecto. Sin embargo, el sistema de seguridad falla y los dinosaurios se escapan.', 63, 
1029, 'E001', 'D001', 'G001', 'C001');

INSERT INTO peliculas(CooPeli, TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli
, CodEstud, CodDirec, CodGenero, CodClasi) 
VALUES('P002', 'The Lost World: Jurassic Park', '19/05/1997', 129, 'Ingles', 'Cuatro años después del 
desastre en el Parque Jurásico, Ian Malcolm llega a una isla situada en Costa Rica, perteneciente a la Costa 
de las Cinco Muertes, donde los dinosaurios, modificados genéticamente, viven y se reproducen en libertad. Se 
trata de la llamada zona B, el lugar que servía como laboratorio.', 73, 
619, 'E001', 'D001', 'G001', 'C001');

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
-- Procedimiento para Listar peliculas
CREATE OR REPLACE PROCEDURE sp_ListarPeliculas (listapelicula OUT SYS_REFCURSOR) AS
BEGIN
    OPEN listapelicula FOR SELECT * FROM Peliculas;
END;
-- Procedimiento para registrar peliculas
CREATE OR REPLACE PROCEDURE sp_RegistrarPeliculas(
    CooPeli OUT CHAR, TituloPeli IN VARCHAR2, AniOEsPeli IN DATE, DuracPeli IN NUMBER,
    IdiomaPeli IN VARCHAR2, SinopPeli IN VARCHAR2, PresuPeli IN NUMBER, IngresoPeli IN NUMBER, 
    CodEstud OUT VARCHAR2, CodDirec OUT VARCHAR2, CodGenero OUT VARCHAR2, CodClasi OUT VARCHAR2) IS 
    max_num NUMBER;
BEGIN
    SELECT MAX(TO_NUMBER(SUBSTR(CooPeli,2,3))) INTO max_num FROM Peliculas;
    IF max_num IS NOT NULL THEN
        CooPeli := 'P'||LPAD(max_num+1,3,'0');
    ELSE 
        CooPeli := 'P001'; 
    END IF;
    INSERT INTO Peliculas(CooPeli, TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli,
    IngresoPeli, CodEstud, CodDirec, CodGenero, CodClasi) VALUES(CooPeli, TituloPeli, AniOEsPeli, DuracPeli, 
    IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli, CodEstud, CodDirec, CodGenero, CodClasi);
END sp_RegistrarPeliculas;


--Desc peliculas;
DROP SEQUENCE codPeliAuto;
DROP TRIGGER tr_insert_peliculas;
EXEC sp_ListarPeliculas;
DROP PROCEDURE sp_RegistrarPelicula;

SELECT * FROM v$version;

/*----------------------------------------------------------------
CREATE OR REPLACE PROCEDURE sp_ListarPeliculas AS
    v_CooPeli Peliculas.CooPeli%TYPE; v_TituloPeli Peliculas.TituloPeli%TYPE;
    v_AniOEsPeli Peliculas.AniOEsPeli%TYPE; v_DuracPeli Peliculas.DuracPeli%TYPE;
    v_IdiomaPeli Peliculas.IdiomaPeli%TYPE; v_SinopPeli Peliculas.SinopPeli%TYPE;
    v_PresuPeli Peliculas.PresuPeli%TYPE; v_IngresoPeli Peliculas.IngresoPeli%TYPE;
    v_CodEstud Peliculas.CodEstud%TYPE; v_CodDirec Peliculas.CodDirec%TYPE;
    v_CodGenero Peliculas.CodGenero%TYPE; v_CodClasi Peliculas.CodClasi%TYPE;
BEGIN
    SELECT CooPeli, TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli
        , CodEstud, CodDirec, CodGenero, CodClasi INTO v_CooPeli, v_TituloPeli, v_AniOEsPeli, v_DuracPeli, 
        v_IdiomaPeli, v_SinopPeli, v_PresuPeli, v_IngresoPeli  , v_CodEstud, v_CodDirec, 
        v_CodGenero, v_CodClasi FROM Peli
--------------------------------------------------
CREATE OR REPLACE PROCEDURE sp_RegistrarPelicula (tituloP IN VARCHAR2, anioP IN DATE, duracP IN NUMBER,
    idiomaP IN VARCHAR2, sinopP  VARCHAR2, presuP IN NUMBER, ingresoP IN NUMBER, codEst IN VARCHAR2, codDirec IN 
    CHAR, codGen IN VARCHAR2, codClas IN VARCHAR2) AS
BEGIN 
    INSERT INTO Peliculas (TituloPeli, AniOEsPeli, DuracPeli, IdiomaPeli, SinopPeli, PresuPeli, IngresoPeli,
    CodEstud, CodDirec, CodGenero, CodClasi) VALUES (tituloP, anioP, duracP, idiomaP, sinopP, presuP, ingresoP,
    codEst, codDirec, codGen, codClas);
END;
-- Numeracion de codigo 
CREATE SEQUENCE codPeliAuto START WITH 1 INCREMENT BY 1;
-- Trigger 
CREATE OR REPLACE TRIGGER peliculaAdd 
BEFORE INSERT ON Peliculas 
FOR EACH ROW
BEGIN 
    SELECT 'P' || LPAD(codPeliAuto.NEXTVAL, 4, '0') INTO :NEW.CooPeli FROM dual;
END; */

