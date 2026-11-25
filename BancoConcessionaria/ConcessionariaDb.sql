-- =============================================
-- Banco: Concessionaria
-- Aula 05 - Desafio: API nova do banco ao Postman
-- =============================================

CREATE DATABASE Concessionaria;
GO

USE Concessionaria;
GO

CREATE TABLE Marca (
    IdMarca    INT PRIMARY KEY IDENTITY,
    Nome       VARCHAR(50) NOT NULL UNIQUE,
    PaisOrigem VARCHAR(50) NOT NULL
);

CREATE TABLE Veiculo (
    IdVeiculo INT PRIMARY KEY IDENTITY,
    Modelo    VARCHAR(100) NOT NULL,
    Placa     CHAR(7) NOT NULL UNIQUE,
    Ano       INT NOT NULL,
    Cor       VARCHAR(30) NULL,
    Preco     DECIMAL(10,2) NOT NULL,
    IdMarca   INT NOT NULL FOREIGN KEY REFERENCES Marca(IdMarca)
);

INSERT INTO Marca (Nome, PaisOrigem) VALUES
('Fiat', 'Itália'),
('Volkswagen', 'Alemanha'),
('Chevrolet', 'Estados Unidos'),
('Toyota', 'Japão');

INSERT INTO Veiculo (Modelo, Placa, Ano, Cor, Preco, IdMarca) VALUES
('Argo',    'BRA2E19', 2023, 'Branco',   79990.00,  1),
('Mobi',    'FIA1B23', 2022, 'Vermelho', 62500.00,  1),
('T-Cross', 'VWT3C45', 2025, 'Cinza',    149990.00, 2),
('Polo',    'POL4D56', 2024, NULL,       94900.00,  2),
('Onix',    'ONX5E67', 2024, 'Preto',    89990.00,  3),
('Corolla', 'TOY6F78', 2025, 'Prata',    189990.00, 4);

-- Conferir
SELECT * FROM Marca;
SELECT * FROM Veiculo;