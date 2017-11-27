CREATE DATABASE sistemaInterconectadoCentral; -- DROP DATABASE sistemaInterconectadoCentral
GO
USE sistemaInterconectadoCentral;
GO

CREATE TABLE categoria(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50)
);
GO

CREATE TABLE producto(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50),
	produccionPromedio INT,
	produccionMaximo INT,
	fechaEntrada DATETIME,
	categoriaFK INT,
	disponible BIT,
	FOREIGN KEY (categoriaFK) REFERENCES categoria(id)
);
GO

CREATE TABLE estacion(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50),
	numeroTrans INT
);
GO

CREATE TABLE entregaEnergia(
	id INT PRIMARY KEY IDENTITY(1,1),
	estacionFK INT,
	productoFK INT,
	fecha DATETIME,
	energia FLOAT,
	FOREIGN KEY (estacionFK) REFERENCES estacion(id),
	FOREIGN KEY (productoFK) REFERENCES producto(id)
);
GO

CREATE TABLE red(
	id INT PRIMARY KEY IDENTITY(1,1),
	estacionFK INT,
	volumenEnergia INT,
	minimoEnergia INT,
	maximoEnergia INT,
	fueraDeServicio BIT,
	FOREIGN KEY (estacionFK) REFERENCES estacion(id),
);
GO

CREATE TABLE linea(
	id INT PRIMARY KEY IDENTITY(1,1),
	redFK INT,
	lonigtud INT,
	FOREIGN KEY (redFK) REFERENCES red(id)
);
GO

CREATE TABLE subEstacion(
	id INT PRIMARY KEY IDENTITY(1,1),
	lineaFK INT,
	FOREIGN KEY (lineaFK) REFERENCES linea(id)
);
GO

CREATE TABLE region(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50)
);
GO

CREATE TABLE provincia(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50),
	regionFK INT,
	FOREIGN KEY (regionFK) REFERENCES region(id)
);
GO

CREATE TABLE zona(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50),
	provinciaFK INT,
	subEstacionFK INT,
	FOREIGN KEY (provinciaFK) REFERENCES provincia(id),
	FOREIGN KEY (subEstacionFK) REFERENCES subEstacion(id),
);
GO

INSERT INTO categoria VALUES('Hidroeléctrica');
INSERT INTO categoria VALUES('Solar Fotovoltaica');
INSERT INTO categoria VALUES('Eólica');
INSERT INTO categoria VALUES('Térmica');