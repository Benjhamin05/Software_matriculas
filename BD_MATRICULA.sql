create DATABASE BD_MATRICULA

USE BD_MATRICULA

CREATE TABLE ESTUDIANTES(

id_estudiante INT PRIMARY KEY not null,
dni VARCHAR(8) NOT NULL,
nombre VARCHAR(40) NOT NULL,
apellidos varchar(40) not null,
codigoEstudiante char(10)not null,
)

create TABLE PENSIONES(
id_PENSIONES INT PRIMARY KEY,
precioPension money not null,
id_matricula int not null,
foreign key (id_matricula) references matricula(id_matricula)

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
id_matricula INT PRIMARY KEY,
precioMatricula money not null,
semestreMatricula int not null,
id_estudiante int not null,
foreign key (id_estudiante) references ESTUDIANTES(id_estudiante)
)

create TABLE FACTURA
(id_factura INT PRIMARY KEY,
nombreCompleto VARCHAR(100) NOT NULL,
codigoEstudiante char(10)not null,
dni VARCHAR(8) NOT NULL,
fechaEmision date not null,
precioTotal money not null,
tipoPago varchar(50) not null,
id_pensiones int not null,
foreign key (id_pensiones) references pensiones(id_pensiones)

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