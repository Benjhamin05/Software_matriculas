CREATE DATABASE DBCpensiones
use DBCpensiones
-- tabla para los pensionados
CREATE TABLE Pensionados (
    ID_Pensionado INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    FechaNacimiento DATE,
    Direccion VARCHAR(100)
);

-- tabla detalles de la pensión
CREATE TABLE DetallesPension (
    ID_Detalle INT PRIMARY KEY,
    ID_Pensionado INT,
    MontoPension DECIMAL(10, 2),
    FechaInicio DATE,
    FOREIGN KEY (ID_Pensionado) REFERENCES Pensionados(ID_Pensionado)
);

-- tabla para los pagos de pensiones
CREATE TABLE PagosPension (
    ID_Pago INT PRIMARY KEY,
    ID_Detalle INT,
    MontoPago DECIMAL(10, 2),
    FechaPago DATE,
    FOREIGN KEY (ID_Detalle) REFERENCES DetallesPension(ID_Detalle)
);

