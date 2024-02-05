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
)

