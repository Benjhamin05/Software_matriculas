CREATE DATABASE BD_MATRICULA

USE BD_MATRICULA

CREATE TABLE ESTUDIANTES(
id_estudiante INT PRIMARY KEY,
dni VARCHAR(8)NOT NULL,
nombre VARCHAR(8)NOT NULL,
codigo char(10)not null,
)

CREATE TABLE PENSIONES(
id_PENSIONES INT PRIMARY KEY,
monto DECIMAL(10, 2) not null,
fecha_pago DATE not null,
estado_pago VARCHAR(20) not null,
id_estudiante INT not null,
FOREIGN KEY (id_estudiante) REFERENCES ESTUDIANTES(id_estudiante)
)


CREATE TABLE MATRICULA(
id_matricula INT PRIMARY KEY not null,
fecha_matricula DATE not null,
periodo_academico VARCHAR(20)not null,
id_estudiante INT not null,
FOREIGN KEY (id_estudiante) REFERENCES ESTUDIANTES(id_estudiante)
)

CREATE TABLE FACTURA(
id_factura INT PRIMARY KEY not null,
fecha_emision DATE not null,
monto_total DECIMAL(10, 2) not null,
id_estudiante INT not null,
FOREIGN KEY (id_estudiante) REFERENCES ESTUDIANTES(id_estudiante)
)