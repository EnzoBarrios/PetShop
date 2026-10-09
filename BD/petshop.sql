CREATE DATABASE PetShopBD;
GO

USE PetShopBD;
GO

-- 1. Tabla Rol
CREATE TABLE Rol (
	id_rol INT IDENTITY(1,1),
	nombre_rol VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Rol PRIMARY KEY (id_rol)
);
GO

-- 2. Tabla Usuario
CREATE TABLE Usuario (
	id_usuario INT IDENTITY(1,1),
	nombre VARCHAR (50) NOT NULL,
	apellido VARCHAR (50) NOT NULL,
	nombre_usuario VARCHAR(50) NOT NULL,
	dni VARCHAR(8) NULL,
	clave VARCHAR(255) NOT NULL,
	correo VARCHAR(100) NULL,
	telefono VARCHAR(15) NULL,
	estado BIT NOT NULL DEFAULT 1, -- 1: Activo, 0: Inactivo
	fecha_creacion DATETIME NOT NULL DEFAULT GETDATE(),
	id_rol INT NOT NULL,
	CONSTRAINT PK_Usuario PRIMARY KEY (id_usuario),
	CONSTRAINT FK_Usuario_Rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol),
	CONSTRAINT UQ_Usuario_Nombre UNIQUE (nombre_usuario),

	-- Índices filtrados únicos para campos opcionales
	INDEX IX_UQ_Usuario_Dni UNIQUE NONCLUSTERED (dni) 
        WHERE dni IS NOT NULL, 
    INDEX IX_UQ_Usuario_Correo UNIQUE NONCLUSTERED (correo) 
        WHERE correo IS NOT NULL,   
    INDEX IX_UQ_Usuario_Telefono UNIQUE NONCLUSTERED (telefono) 
        WHERE telefono IS NOT NULL
);
GO

-- 3. Tabla Categoria
CREATE TABLE Categoria (
	id_categoria INT IDENTITY(1,1),
	nombre_categoria VARCHAR(50) NOT NULL,
	descripcion VARCHAR(255) NULL,
	estado BIT NOT NULL DEFAULT 1, -- 1: Activo, 0: Inactivo
	CONSTRAINT PK_Categoria PRIMARY KEY (id_categoria)
);
GO

-- 4. Tabla Especie
CREATE TABLE Especie (
	id_especie INT IDENTITY(1,1),
	nombre_especie VARCHAR(50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Especie PRIMARY KEY (id_especie)
);
GO

-- 5. Tabla Tamano
CREATE TABLE Tamano (
	id_tamano INT IDENTITY(1,1),
	nombre_tamano VARCHAR(50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Tamano PRIMARY KEY (id_tamano)
);
GO

-- 6. Tabla Especie_Tamano
CREATE TABLE Especie_Tamano (
	id_especie INT NOT NULL,
	id_tamano INT NOT NULL,
	estado BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Especie_Tamano PRIMARY KEY (id_especie, id_tamano),
	CONSTRAINT FK_EspecieTamano_Especie FOREIGN KEY (id_especie) REFERENCES Especie(id_especie),
	CONSTRAINT FK_EspecieTamano_Tamano FOREIGN KEY (id_tamano) REFERENCES Tamano(id_tamano)
);
GO

-- 7. Tabla Producto
CREATE TABLE Producto (
	id_producto INT IDENTITY(1,1),
	codigo_barra VARCHAR(50) NOT NULL,
	nombre_producto VARCHAR(50) NOT NULL,
	descripcion VARCHAR(255) NULL,
	precio_compra DECIMAL(10, 2) NOT NULL,
	precio_venta DECIMAL(10, 2) NOT NULL,
	stock_actual INT NOT NULL DEFAULT 0,
	stock_minimo INT NOT NULL DEFAULT 0,
	estado BIT NOT NULL DEFAULT 1, -- 1: Activo, 0: Inactivo
	fecha_creacion DATETIME NOT NULL DEFAULT GETDATE(),
	id_categoria INT NOT NULL,
	id_especie INT NULL,
	id_tamano INT NULL,
	CONSTRAINT PK_Producto PRIMARY KEY (id_producto),
	CONSTRAINT FK_Producto_Categoria FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
	CONSTRAINT FK_Producto_EspecieTamano FOREIGN KEY (id_especie, id_tamano) REFERENCES Especie_tamano(id_especie, id_tamano),
	CONSTRAINT UQ_Producto_Codigo UNIQUE (codigo_barra),
	CONSTRAINT CK_Producto_Precios CHECK (precio_compra >= 0 AND precio_venta >= precio_compra),
	CONSTRAINT CK_Productos_Stock CHECK (stock_actual >= 0 AND stock_minimo >= 0),
	CONSTRAINT CK_Producto_EspecieTamano_Consistencia CHECK (
		(id_especie IS NULL AND id_tamano IS NULL) OR
		(id_especie IS NOT NULL AND id_tamano IS NOT NULL))
);
GO

-- 8. Tabla Tipo_venta
CREATE TABLE Tipo_venta (
	id_tipo_venta INT IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Tipo_Venta PRIMARY KEY (id_tipo_venta)
);
GO

-- 9. Tabla Metodo_pago
CREATE TABLE Metodo_pago (
	id_metodo_pago INT IDENTITY(1,1),
	nombre_metodo VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Metodo_Pago PRIMARY KEY (id_metodo_pago)
);
GO

-- 10. Tabla Venta
CREATE TABLE Venta (
	id_venta INT IDENTITY(1,1),
	nro_factura VARCHAR(50) NOT NULL,
	fecha_hora DATETIME NOT NULL DEFAULT GETDATE(),
	total DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	estado VARCHAR(20) NOT NULL DEFAULT 'Completada', -- 'Completada', 'Anulada'
	id_tipo_venta INT NOT NULL,
	id_usuario INT NOT NULL,
	CONSTRAINT PK_Venta PRIMARY KEY (id_venta),
	CONSTRAINT FK_Venta_TipoVenta FOREIGN KEY (id_tipo_venta) REFERENCES Tipo_venta(id_tipo_venta),
	CONSTRAINT FK_Venta_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
	CONSTRAINT UQ_Venta_NroFactura UNIQUE (nro_factura),
	CONSTRAINT CK_Venta_Total CHECK (total >= 0),
	CONSTRAINT CK_Venta_Estado CHECK (estado IN ('Completada', 'Anulada'))
);
GO

-- 11. Tabla Pago
CREATE TABLE Pago (
	id_venta INT NOT NULL,
	id_metodo_pago INT NOT NULL,
	monto DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_Pago PRIMARY KEY (id_venta, id_metodo_pago),
	CONSTRAINT FK_Pago_Venta FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
	CONSTRAINT FK_Pago_MetodoPago FOREIGN KEY (id_metodo_pago) REFERENCES Metodo_pago(id_metodo_pago),
	CONSTRAINT CK_Pago_Monto CHECK (monto > 0)
);
GO

-- 12. Tabla Detalle_Venta
CREATE TABLE Detalle_Venta (
	id_venta INT NOT NULL,
	id_producto INT NOT NULL,
	cantidad INT NOT NULL,
	precio_unitario DECIMAL(10,2) NOT NULL,
	subtotal DECIMAL(10, 2) NOT NULL,
	CONSTRAINT PK_DetalleVenta PRIMARY KEY (id_venta, id_producto),
	CONSTRAINT FK_DetalleVenta_Venta FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
	CONSTRAINT FK_DetalleVenta_Producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
	CONSTRAINT CK_DetalleVenta_Cantidad CHECK (cantidad > 0),
	CONSTRAINT CK_DetalleVenta_Precios CHECK (precio_unitario >= 0 AND subtotal >= 0),
	CONSTRAINT CK_DetalleVenta_Subtotal CHECK (subtotal = cantidad * precio_unitario)
);
GO

INSERT INTO Rol (nombre_rol) 
VALUES ('Administrador'), ('Gerente'), ('Vendedor');
GO

INSERT INTO Usuario (nombre, apellido, nombre_usuario, dni, clave, correo, telefono, id_rol)
VALUES 
('Franco', 'Díaz',    'admin',           '12345678', 'admin123', 'francodiaz@gmail.com',  '3794101010', 1),
('Enzo',   'Barrios', 'EnzoBarrios',     '87654321', 'asdf1234', 'enzobarrios@gmail.com', '3794123450', 2),
('Carlos', 'Gómez',   'carlos.empleado', '12341234', 'user123',  'carlosgomez@gmail.com', '3794010101', 3);
GO

INSERT INTO Categoria (nombre_categoria, descripcion) VALUES
('Alimentos Secos', 'Balanceados e idóneos para la nutrición diaria'),
('Alimentos Húmedos', 'Latas y sobres con alta palatabilidad'),
('Accesorios', 'Platos, correas, rascadores y pretales'),
('Juguetes', 'Pelotas, mordillos y juguetes interactivos'),
('Estética e Higiene', 'Shampoos, cepillos y arenas sanitarias'),
('Fármacos y Salud', 'Antiparasitarios, pipetas y suplementos');

INSERT INTO Especie (nombre_especie)
VALUES ('Ave'), ('Conejo'), ('Gato'), ('Perro'), ('Pez');
GO

INSERT INTO Tamano (nombre_tamano)
VALUES ('Toy'), ('Pequeño'), ('Mediano'), ('Grande'), ('Gigante');
GO

INSERT INTO Especie_Tamano (id_especie, id_tamano)
VALUES
(1, 2), -- Ave - Pequeño (ID 2)
(1, 3), -- Ave - Mediano (ID 3)
(1, 4), -- Ave - Grande (ID 4)
(2, 2), -- Conejo - Pequeño (ID 2)
(2, 3), -- Conejo - Mediano (ID 3)
(3, 2), -- Gato - Pequeño (ID 2)
(3, 3), -- Gato - Mediano (ID 3)
(3, 4), -- Gato - Grande (ID 4)
(4, 1), -- Perro - Toy (ID 1)
(4, 2), -- Perro - Pequeño (ID 2)
(4, 3), -- Perro - Mediano (ID 3)
(4, 4), -- Perro - Grande (ID 4)
(4, 5); -- Perro - Gigante (ID 5)
GO

-- CASO A: Productos con Especie y Tamaño definidos (Cumplen FK y CHECK Consistency)
INSERT INTO Producto (
    codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, 
    stock_actual, stock_minimo, estado, id_categoria, id_especie, id_tamano
) VALUES
('779123456701', 'Royal Canin Mini Adult 3kg', 'Alimento balanceado para perros adultos de raza pequeña', 12500.00, 18200.00, 25, 5, 1, 1, 4, 2),
('779123456702', 'Pro Plan Dog Adult Medium 15kg', 'Balanceado completo para perros adultos medianos', 38000.00, 54500.00, 10, 2, 1, 1, 4, 3),
('779123456703', 'Eukanuba Large Breed Adult 15kg', 'Alimento balanceado para perros de razas grandes', 41000.00, 59000.00, 8, 2, 1, 1, 4, 4),
('779123456704', 'Pedigree Puppy 3kg', 'Alimento completo para perros cachorros pequeños', 8500.00, 12900.00, 15, 4, 1, 1, 4, 2),
('779123456708', 'Pipeta Antiparasitaria Perro Grande', 'Antiparasitario externo para perros grandes (>20kg)', 3100.00, 4900.00, 18, 5, 1, 6, 4, 4),
('779123456709', 'Shampoo Perro Cachorro 250ml', 'Shampoo suave e hipoalergénico para razas pequeñas', 2200.00, 3600.00, 12, 3, 1, 5, 4, 2),
('779123456714', 'Cama Cueva Perro Toy', 'Cama acolchada térmica para perros pequeños o toy', 12000.00, 18500.00, 6, 2, 1, 3, 4, 1),
('779123456715', 'Arnés Reforzado Perro Gigante', 'Pretal de alta resistencia para razas gigantes', 9500.00, 14800.00, 4, 2, 1, 3, 4, 5),
('779123456705', 'Cat Chow Adulto Salmón 1.5kg', 'Alimento para gatos adultos medianos', 6200.00, 9300.00, 30, 6, 1, 1, 3, 3),
('779123456706', 'Whiskas Gatitos Carne 1kg', 'Balanceado seco para gatos cachorros o pequeños', 4800.00, 7100.00, 20, 5, 1, 1, 3, 2),
('779123456707', 'Lata Felix Pavo en Salsa 85g', 'Alimento húmedo completo para gatos medianos', 800.00, 1350.00, 50, 10, 1, 2, 3, 3),
('779123456716', 'Lata Royal Canin Cat Instinctive 85g', 'Alimento húmedo premium para gatos', 1500.00, 2400.00, 40, 8, 1, 2, 3, 3),
('779123456717', 'Pipeta Felina Antiparasitaria', 'Protección contra pulgas para gatos pequeños/medianos', 2800.00, 4200.00, 15, 5, 1, 6, 3, 2),
('779123456718', 'Alimento Balanceado Cacatúas 1kg', 'Mezcla especial de semillas y extruidos para aves medianas', 3200.00, 4800.00, 12, 3, 1, 1, 1, 3),
('779123456719', 'Jaula Especial para Aves Pequeñas', 'Jaula de metal con comederos y perchas incluidas', 15000.00, 22500.00, 3, 1, 1, 3, 1, 2),
('779123456720', 'Heno de Alfalfa para Conejos 500g', 'Fibra natural indispensable para digestión de roedores', 1800.00, 2900.00, 25, 5, 1, 1, 2, 2);

-- CASO B: Productos Generales / Multiespecie (id_especie e id_tamano son NULL)
-- Respeta la restricción CHECK: ((id_especie IS NULL AND id_tamano IS NULL) OR (id_especie IS NOT NULL AND id_tamano IS NOT NULL))
INSERT INTO Producto (
    codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, 
    stock_actual, stock_minimo, estado, id_categoria, id_especie, id_tamano
) VALUES
('779123456710', 'Plato Doble Acero Inoxidable', 'Comedero y bebedero universal antideslizante', 3500.00, 5800.00, 14, 3, 1, 3, NULL, NULL),
('779123456711', 'Arena Sanitaria Piedras 4kg', 'Absorbente de olores para bandeja sanitaria', 2100.00, 3400.00, 40, 8, 1, 5, NULL, NULL),
('779123456712', 'Rascador Árbol 2 Niveles', 'Torre de juego con soga de yute para felinos', 18500.00, 27900.00, 5, 1, 1, 3, NULL, NULL),
('779123456713', 'Mezcla Semillas Aves Universal 1kg', 'Alimento variado para aves domésticas generales', 1500.00, 2400.00, 22, 5, 1, 1, NULL, NULL),
('779123456721', 'Pelota Mordillo Goma Rígida', 'Juguete interactivo con dispensador de alimento', 2900.00, 4500.00, 18, 4, 1, 4, NULL, NULL),
('779123456722', 'Cardina Cepillo Metálico Pelo Cuerda', 'Cepillo removedor de pelo muerto para mascotas', 2400.00, 3900.00, 11, 3, 1, 5, NULL, NULL),
('779123456723', 'Acondicionador de Agua Acuarios 100ml', 'Neutralizador de cloro y metales pesados para peces', 1900.00, 3100.00, 15, 4, 1, 6, NULL, NULL);
GO
GO

INSERT INTO Tipo_venta (descripcion)
VALUES ('Mostrador'), ('Envío'), ('Virtual');
GO

INSERT INTO Metodo_pago (nombre_metodo)
VALUES ('Efectivo'), ('Transferencia'), ('Qr');
GO

SELECT * FROM Rol;
SELECT * FROM Usuario;
SELECT * FROM Categoria;
SELECT * FROM Especie;
SELECT * FROM Tamano;
SELECT * FROM Especie_Tamano;
SELECT * FROM Producto;