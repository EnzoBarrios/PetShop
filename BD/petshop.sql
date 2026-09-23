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
	CONSTRAINT UQ_Usuario_Dni UNIQUE (dni),
	CONSTRAINT UQ_Usuario_Correo UNIQUE (correo)
);
GO

-- 3. Tabla Especie
CREATE TABLE Especie (
	id_especie INT IDENTITY(1,1),
	nombre_especie VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Especie PRIMARY KEY (id_especie)
);
GO

-- 4. Tabla Categoria
CREATE TABLE Categoria (
	id_categoria INT IDENTITY(1,1),
	nombre_categoria VARCHAR(50) NOT NULL,
	descripcion VARCHAR(255) NULL,
	estado BIT NOT NULL DEFAULT 1, -- 1: Activo, 0: Inactivo
	CONSTRAINT PK_Categoria PRIMARY KEY (id_categoria)
);
GO

-- 5. Tabla Tamano
CREATE TABLE Tamano (
	id_tamano INT IDENTITY(1,1),
	nombre_tamano VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Tamano PRIMARY KEY (id_tamano)
);
GO

-- 6. Tabla Especie_Tamano
CREATE TABLE Especie_Tamano (
	id_especie INT NOT NULL,
	id_tamano INT NOT NULL,
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
	id_categoria INT NOT NULL,
	id_especie INT NULL,
	id_tamano INT NULL,
	CONSTRAINT PK_Producto PRIMARY KEY (id_producto),
	CONSTRAINT FK_Producto_Categoria FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
	CONSTRAINT FK_Producto_EspecieTamano FOREIGN KEY (id_especie, id_tamano) REFERENCES Especie_tamano(id_especie, id_tamano),
	CONSTRAINT UQ_Producto_Codigo UNIQUE (codigo_barra),
	CONSTRAINT CK_Producto_Precios CHECK (precio_compra >= 0 AND precio_venta >= precio_compra),
	CONSTRAINT CK_Productos_Stock CHECK (stock_actual >= 0 AND stock_minimo >= 0)
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
	CONSTRAINT CK_Venta_Total CHECK (total >= 0)
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
	CONSTRAINT CK_Pago_Monto CHECK (monto >= 0)
);
GO

-- 12. Tabla Detalle_Venta
CREATE TABLE Detalle_Venta (
	id_venta INT NOT NULL,
	id_producto INT NOT NULL,
	cantidad INT NOT NULL,
	precio_unitario DECIMAL(10,2) NOT NULL,
	subtotal DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_DetalleVenta PRIMARY KEY (id_venta, id_producto),
	CONSTRAINT FK_DetalleVenta_Venta FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
	CONSTRAINT FK_DetalleVenta_Producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
	CONSTRAINT CK_DetalleVenta_Cantidad CHECK (cantidad >= 0),
	CONSTRAINT CK_DetalleVenta_Precios CHECK (precio_unitario >= 0 AND subtotal >= 0)
);
GO

SELECT * FROM Usuario;

INSERT INTO Rol (nombre_rol) 
VALUES ('Administrador'), ('Gerente'), ('Vendedor');
GO

INSERT INTO Usuario (nombre, apellido, nombre_usuario, dni, clave, correo, telefono, id_rol)
VALUES 
('Franco', 'Díaz',    'admin',           '12345678', 'admin123', 'francodiaz@gmail.com',  '3794101010', 1),
('Enzo',   'Barrios', 'EnzoBarrios',     '87654321', 'asdf1234', 'enzobarrios@gmail.com', '3794123450', 2),
('Carlos', 'Gómez',   'carlos.empleado', '12341234', 'user123',  'carlosgomez@gmail.com', '3794010101', 3);
GO

INSERT INTO Especie (nombre_especie)
VALUES ('Ave'), ('Conejo'), ('Gato'), ('Perro'), ('Pez');
GO

INSERT INTO Categoria (nombre_categoria)
VALUES ('Accesorio'), ('Alimento'), ('Higiene'), ('Juguete'), ('Salud');
GO

INSERT INTO Tamano (nombre_tamano)
VALUES ('Pequeño'), ('Mediano'), ('Grande');
GO


INSERT INTO Especie_Tamano (id_especie, id_tamano)
VALUES
(4, 1), -- Perro - Pequeño
(4, 2), -- Perro - Mediano
(4, 3), -- Perro - Grande
(3, 1), -- Gato - Pequeño
(3, 2); -- Gato - Mediano
GO

INSERT INTO Tipo_venta (descripcion)
VALUES ('Mostrador'), ('Envío'), ('Virtual');
GO

INSERT INTO Metodo_pago (nombre_metodo)
VALUES ('Efectivo'), ('Transferencia'), ('Qr');
GO

