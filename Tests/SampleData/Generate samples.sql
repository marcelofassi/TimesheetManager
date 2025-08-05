SET IDENTITY_INSERT Pais ON;
INSERT INTO Pais (IdPais, Descripcion) VALUES (1, 'Argentina');
INSERT INTO Pais (IdPais, Descripcion) VALUES (2, 'Brasil');
INSERT INTO Pais (IdPais, Descripcion) VALUES (3, 'Chile');
SET IDENTITY_INSERT Pais OFF;
GO
SET IDENTITY_INSERT Clientes ON;

INSERT INTO Clientes (IdCliente, NombreRazonSocial, Codigo, Domicilio, FechaBaja, IdPais, FechaAlta, NoVolverPreguntarNotifica)
VALUES (1, 'Cliente Fantasía 1', 'CLNT001', 'Calle Falsa 10', NULL, 1, GETDATE(), 0);

INSERT INTO Clientes (IdCliente, NombreRazonSocial, Codigo, Domicilio, FechaBaja, IdPais, FechaAlta, NoVolverPreguntarNotifica)
VALUES (2, 'Cliente Fantasía 2', 'CLNT002', 'Calle Falsa 20', NULL, 2, GETDATE(), 0);

INSERT INTO Clientes (IdCliente, NombreRazonSocial, Codigo, Domicilio, FechaBaja, IdPais, FechaAlta, NoVolverPreguntarNotifica)
VALUES (3, 'Cliente Fantasía 3', 'CLNT003', 'Calle Falsa 30', NULL, 3, GETDATE(), 0);

SET IDENTITY_INSERT Clientes OFF;

-- Repetido hasta el cliente 50

GO
-----------------------------------------------------------------------------------------------------------