USE PetShopBD;
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

SELECT * FROM Rol;
SELECT * FROM Usuario;
SELECT * FROM Categoria;
SELECT * FROM Especie;
SELECT * FROM Tamano;
SELECT * FROM Especie_Tamano;
SELECT * FROM Producto;

SELECT * FROM Venta;
SELECT * FROM Detalle_Venta;
SELECT * FROM Pago;

-- Ejemplo para consultar el detalle de la venta mostrando nombres reales
SELECT 
    v.id_venta,
    v.nro_factura,
    v.fecha_hora,
    v.descuento AS Descuento,
    v.total AS TotalFinal,
    p.nombre_producto AS NombreProducto,
    dv.cantidad,
    dv.precio_unitario,
    dv.subtotal
FROM Detalle_Venta dv
INNER JOIN Producto p ON dv.id_producto = p.id_producto
INNER JOIN Venta v ON dv.id_venta = v.id_venta
WHERE dv.id_venta = 5;

-- Ejemplo para consultar los pagos mostrando el método de pago real
SELECT 
    pg.id_venta,
    mp.nombre_metodo AS MetodoPago,
    pg.monto
FROM Pago pg
INNER JOIN Metodo_Pago mp ON pg.id_metodo_pago = mp.id_metodo_pago
WHERE pg.id_venta = 4;

--Productos con stock menor al mínimo
SELECT 
    id_producto,
    nombre_producto,
    stock_actual,
    stock_minimo
FROM Producto
WHERE stock_actual <= stock_minimo;