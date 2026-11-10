USE PetShopBD;
GO

INSERT INTO Rol (nombre_rol) 
VALUES ('Administrador'), ('Gerente'), ('Vendedor');
GO

INSERT INTO Usuario (nombre, apellido, nombre_usuario, dni, clave, correo, telefono, id_rol)
VALUES 
('Franco', 'Díaz',    'admin',       '12345678', 'admin123',   'francodiaz@gmail.com',  '3794101010', 1),
('Enzo',   'Barrios', 'EnzoBarrios', '87654321', 'asdf1234',   'enzobarrios@gmail.com', '3794123450', 2),
('Carlos', 'Gómez',   'CarlosGomez', '12341234', 'carlos1234', 'carlosgomez@gmail.com', '3794010101', 3),
('Agustin', 'López',   'AgustinLopez', '56785678', 'agustin1234', 'agustinlopez@gmail.com', '3794010102', 3);
GO

INSERT INTO Especie (nombre_especie)
VALUES ('Ave'), ('Conejo'), ('Gato'), ('Perro'), ('Pez');
GO

INSERT INTO Categoria (nombre_categoria)
VALUES ('Accesorio'), ('Alimento'), ('Higiene'), ('Juguete'), ('Salud');
GO

INSERT INTO Tamano (nombre_tamano)
VALUES ('Toy'), ('Pequeño'), ('Mediano'), ('Grande'), ('Extra Grande'), ('Cualquiera');
GO


INSERT INTO Especie_Tamano (id_especie, id_tamano)
VALUES
(1, 2), -- Ave - Pequeño
(2, 2), -- Conejo - Pequeño
(3, 2), -- Gato - Pequeño
(3, 3), -- Gato - Mediano
(3, 4), -- Gato - Grande
(3, 6), -- Gato - Cualquiera
(4, 1), -- Perro - Toy
(4, 2), -- Perro - Pequeño
(4, 3), -- Perro - Mediano
(4, 4), -- Perro - Grande
(4, 5), -- Perro - Extra Grande
(5, 2)  -- Pez - Pequeño
GO

INSERT INTO Producto 
(codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, stock_actual, stock_minimo, id_categoria, id_especie, id_tamano)
VALUES
('779800000001', 'Alimento Perro Cachorro 15kg', 'Balanceado crecimiento raza grande',      14000.00, 22000.00, 5, 5, 2, 4, 4), -- Alimento, Perro, Grande
('779800000002', 'Pipeta Antiparasitaria Gato',   'Protección mensual felina',              2500.00,  4500.00,  8, 8, 5, 3, 2), -- Salud, Gato, Pequeño
('779800000003', 'Hueso Prensado de Cuero 10u',   'Snack dental digestible',                1200.00,  2300.00,  4, 4, 2, 4, 3), -- Alimento, Perro, Mediano
('779800000004', 'Alimento Gato Adulto 3kg',     'Fórmula control bola de pelo',            5200.00,  8500.00,  6, 6, 2, 3, 3), -- Alimento, Gato, Mediano
('779800000005', 'Collar Regulable Perro',        'Nylon reforzado con argolla',            1200.00,  2400.00,  3, 3, 1, 4, 3), -- Accesorio, Perro, Mediano
('779800000006', 'Alimento Mezcla Semillas 1kg',  'Semillas para aves pequeñas',            800.00,   1500.00,  4, 5, 2, 1, 2), -- Alimento, Ave, Pequeño
('779800000007', 'Cepillo Cardina Deslanador',   'Remueve pelo muerto felino/canino',       1800.00,  3200.00,  5, 5, 3, 4, 3), -- Higiene, Perro, Mediano
('779800000008', 'Pelota Goma Mordillo',          'Juguete interactivo irrompible',         900.00,   1800.00,  25, 5, 4, 4, 2), -- Juguete, Perro, Pequeño
('779800000010', 'Piedras Sanitarias Gato 4kg',   'Absorbentes aglomerantes',               1900.00,  3400.00,  40, 10, 3, 3, 6), -- Higiene, Gato, Cualquiera
('779800000011', 'Comedero Acero Inoxidable 1L',  'Base antideslizante goma',               1500.00,  2900.00,  18, 5, 1, 4, 4), -- Accesorio, Perro, Grande
('779800000012', 'Rascador Poste Yute Gato',      'Rascador compacto con base de felpa',    4500.00,  7900.00,  12, 3, 4, 3, 2), -- Juguete, Gato, Pequeño
('779800000013', 'Vitaminas Suplemento Canino',   'Complejo vitamínico 60 comprimidos',     3800.00,  6500.00,  15, 4, 5, 4, 3), -- Salud, Perro, Mediano
('779800000014', 'Bebedero Automático Conejos',   'Pico de bronce antiderrame 500ml',       1100.00,  2100.00,  20, 6, 1, 2, 2), -- Accesorio, Conejo, Pequeño
('779800000015', 'Alimento Pez Hojuelas 100g',    'Alimento completo para peces tropicales',650.00,   1250.00, 30, 8, 2, 5, 2); -- Alimento, Pez, Pequeño

INSERT INTO Producto 
(codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, stock_actual, stock_minimo, id_categoria)
VALUES
('7798000000016', 'Shampoo Antiséptico 500ml', 'Higiene dermatológica', 3100.00,  5800.00, 4, 4, 3); -- Higiene, Sin Especie, Sin Tamaño

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