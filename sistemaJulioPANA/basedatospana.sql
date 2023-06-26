CREATE DATABASE panaDB;

USE panaDB;

CREATE TABLE Contadores (
  id INT PRIMARY KEY,
  nombre VARCHAR(50),
  apellido VARCHAR(50),
  matricula VARCHAR(20),
  estudio VARCHAR(100),
  localidad VARCHAR(50),
  domicilio VARCHAR(100),
  telefono VARCHAR(20),
  celular VARCHAR(20),
  email VARCHAR(100),
  passwrd VARCHAR(50),
  profesion VARCHAR(50)
);

CREATE TABLE Afiliados (
  id INT PRIMARY KEY,
  nombre VARCHAR(50),
  apellido VARCHAR(50),
  tipo_documento VARCHAR(50),
  dni VARCHAR(20),
  cuil VARCHAR(20),
  fecha_nacimiento DATE,
  hora_entrada_manana TIME,
  hora_salida_manana TIME,
  hora_entrada_tarde TIME,
  hora_salida_tarde TIME,
  nacionalidad VARCHAR(50),
  provincia_trabajo VARCHAR(50),
  delegacion VARCHAR(50),
  localidad VARCHAR(50),
  direccion VARCHAR(100),
  telefono VARCHAR(20),
  cargo VARCHAR(50),
  fecha_alta_afip DATE,
  fecha_ingreso DATE,
  email VARCHAR(100),
  horas_trabajadas INT,
  remuneracion DECIMAL(10, 2),
  sexo VARCHAR(10)
);

CREATE TABLE Empresa (
  id INT PRIMARY KEY,
  razon_social VARCHAR(100),
  cuit VARCHAR(20),
  titular VARCHAR(50),
  nombre_fantasia VARCHAR(100),
  socios INT,
  fecha_alta DATE,
  fecha_inicio_actividades DATE,
  domicilio_fiscal VARCHAR(100),
  domicilio_empresa VARCHAR(100),
  localidad VARCHAR(50),
  telefono VARCHAR(20),
  legajo VARCHAR(50)
);
