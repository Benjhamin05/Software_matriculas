create DATABASE BD_MATRICULA

USE BD_MATRICULA

CREATE TABLE ESTUDIANTES(
id_estudiante	INT PRIMARY KEY,
dni				VARCHAR(8) NOT NULL,
nombres			VARCHAR(50) NOT NULL,
apellidos		VARCHAR(50) NOT NULL,
codigo			VARCHAR(10) NOT NULL,
correo			VARCHAR(100) NOT NULL
)

CREATE TABLE PENSIONES(
id_pensiones		INT PRIMARY KEY,
id_estudiante		INT NOT NULL,
n_cuota				INT NOT NULL,
monto				MONEY NOT NULL,
fecha_vencimiento	DATE NOT NULL,
mora				MONEY NOT NULL,

FOREIGN KEY (id_estudiante) REFERENCES ESTUDIANTES(id_estudiante)
)

CREATE TABLE MATRICULA(
id_matricula	INT PRIMARY KEY,
id_estudiante	INT NOT NULL,
carrera			VARCHAR(100) NOT NULL,
fecha_matricula DATE NOT NULL,
semestre		INT NOT NULL,
monto			MONEY NOT NULL,

FOREIGN KEY (id_estudiante) REFERENCES ESTUDIANTES(id_estudiante)
)

CREATE TABLE FACTURA(
id_factura		INT PRIMARY KEY NOT NULL,
id_estudiante	INT NOT NULL,
fecha_emision	DATE NOT NULL,
mora			MONEY NOT NULL,
monto_total		MONEY NOT NULL,

FOREIGN KEY (id_estudiante) REFERENCES ESTUDIANTES(id_estudiante)
)