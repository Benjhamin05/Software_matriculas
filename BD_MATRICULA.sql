create DATABASE BD_MATRICULA

USE BD_MATRICULA

CREATE TABLE ESTUDIANTES(
id_estudiante int primary key not null,
dni				VARCHAR(8) UNIQUE,
codigo			VARCHAR(10) UNIQUE,
nom_completo	VARCHAR(100) NOT NULL,
genero			VARCHAR(10) NOT NULL,
celular			VARCHAR(9) NOT NULL,
correo			VARCHAR(100) NOT NULL,
direccion		VARCHAR(100) NOT NULL
)

create TABLE PENSIONES(
id_pensiones	INT PRIMARY KEY NOT NULL,
monto			MONEY NOT NULL,
f_vencimiento	DATE NOT NULL,
)

CREATE TABLE MATRICULA(
id_matricula	INT PRIMARY KEY,
dni				VARCHAR(8) NOT NULL,
fecha_matricula DATE NOT NULL,
semestre		VARCHAR(6) NOT NULL,
)

create TABLE FACTURA
id_factura      INT PRIMARY KEY,
dni             VARCHAR(8) NOT NULL,
id_pensiones    INT NOT NULL,
id_matricula    INT NOT NULL,
monto_t         MONEY NOT NULL,
fecha_emision   DATE NOT NULL,
estado          DATE NOT NULL,

FOREIGN KEY (dni) REFERENCES ESTUDIANTE(dni),
FOREIGN KEY (id_pensiones) REFERENCES PENSIONES(id_pensiones),
FOREIGN KEY (id_matricula) REFERENCES MATRICULA(id_matricula)
)

