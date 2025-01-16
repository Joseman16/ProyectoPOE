-- Creación de la base de datos
CREATE DATABASE SistemaCampeonato;
GO

USE SistemaCampeonato;

-- Tabla para posiciones
CREATE TABLE Posicion (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);

-- Tabla para equipos
CREATE TABLE Equipo (
    IdEquipo INT PRIMARY KEY IDENTITY(1,1),
    NombreEquipo NVARCHAR(100) NOT NULL,
    NombreFacultad NVARCHAR(100) NOT NULL
);

-- Tabla para jugadores
CREATE TABLE Jugador (
    Cedula NVARCHAR(20) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Dorsal INT NOT NULL,
    IdPosicion INT NOT NULL,
    IdEquipo INT NOT NULL,
    FOREIGN KEY (IdPosicion) REFERENCES Posicion(Id),
    FOREIGN KEY (IdEquipo) REFERENCES Equipo(IdEquipo)
);

-- Tabla para partidos
CREATE TABLE Partidos (
    IdPartido INT PRIMARY KEY IDENTITY(1,1),
    IdEquipoLocal INT NOT NULL,
    IdEquipoVisitante INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    FOREIGN KEY (IdEquipoLocal) REFERENCES Equipo(IdEquipo),
    FOREIGN KEY (IdEquipoVisitante) REFERENCES Equipo(IdEquipo)
);

-- Tabla para resultados
CREATE TABLE Resultados (
    IdResultado INT PRIMARY KEY IDENTITY(1,1),
    IdPartido INT NOT NULL,
    GolesEquipoLocal INT NOT NULL,
    GolesEquipoVisitante INT NOT NULL,
    EsEmpate BIT NOT NULL,
    IdEquipoGanador INT NULL,
    FOREIGN KEY (IdPartido) REFERENCES Partidos(IdPartido),
    FOREIGN KEY (IdEquipoGanador) REFERENCES Equipo(IdEquipo)
);

-- Tabla para la tabla de posiciones
CREATE TABLE TablaPosicion (
    IdTablaPosicion INT PRIMARY KEY IDENTITY(1,1),
    IdEquipo INT NOT NULL,
    Puntos INT DEFAULT 0,
    GolesFavor INT DEFAULT 0,
    GolesEnContra INT DEFAULT 0,
    FOREIGN KEY (IdEquipo) REFERENCES Equipo(IdEquipo)
);

-- Inserción de posiciones predeterminadas
INSERT INTO Posicion (Nombre) VALUES 
('Arquero'),
('Defensa Central'),
('Lateral Izquierdo'),
('Lateral Derecho'),
('Mediocampista'),
('Extremo Izquierdo'),
('Extremo Derecho'),
('Delantero');

-- Ejemplo de datos iniciales para equipos
INSERT INTO Equipo (NombreEquipo, NombreFacultad) VALUES 
('Equipo A', 'Facultad de Ingeniería'),
('Equipo B', 'Facultad de Medicina'),
('Equipo C', 'Facultad de Ciencias');


select * from Posicion
select * from Equipo
select * from Partidos