USE PetShopBD;
GO

INSERT INTO Rol (nombre_rol) 
VALUES ('Administrador'), ('Gerente'), ('Vendedor');
GO

INSERT INTO Usuario (nombre, apellido, nombre_usuario, dni, clave, correo, telefono, id_rol)
VALUES 
-- Administrador
('Franco',  'Díaz',   'FrancoDiaz',    '12345678', 'franco1234', 'francodiaz@gmail.com',    '3794101010', 1),

-- Gerentes
('Enzo',    'Barrios','EnzoBarrios',   '87654321', 'asdf1234',   'enzobarrios@gmail.com',   '3794123450', 2),
('Mariana', 'Silva',  'MarianaSilva',  '23456789', 'mariana1234','marianasilva@gmail.com',  '3794123451', 2),
('Gonzalo', 'Romero', 'GonzaloRomero', '34567890', 'gonzalo1234','gonzaloromero@gmail.com', '3794123452', 2),

-- Vendedores
('Carlos',  'Gómez',    'CarlosGomez',    '12341234', 'carlos1234', 'carlosgomez@gmail.com',    '3794010101', 3),
('Agustin', 'López',    'AgustinLopez',   '56785678', 'agustin1234','agustinlopez@gmail.com',   '3794010102', 3),
('Sofia',   'Fernández','SofiaFernandez', '45678901', 'sofia1234',  'sofiafernandez@gmail.com', '3794010103', 3),
('Lucas',   'Benítez',  'LucasBenitez',   '56789012', 'lucas1234',  'lucasbenitez@gmail.com',   '3794010104', 3),
('Camila',  'Torres',   'CamilaTorres',   '67890123', 'camila1234', 'camilatorres@gmail.com',   '3794010105', 3),
('Mateo',   'Acuña',    'MateoAcuna',     '78901234', 'mateo1234',  'mateoacuna@gmail.com',     '3794010106', 3),
('Valeria', 'Ríos',     'ValeriaRios',    '89012345', 'valeria1234','valeriarios@gmail.com',    '3794010107', 3),
('Nicolás', 'Martínez', 'NicolasMartinez','90123456', 'nicolas1234','nicolasmartinez@gmail.com','3794010108', 3),
('Lucía',   'Navarro',  'LuciaNavarro',   '11223344', 'lucia1234',  'lucianavarro@gmail.com',   '3794010109', 3);
GO

INSERT INTO Categoria (nombre_categoria)
VALUES
('Alimento Seco'), 
('Alimento Húmedo y Snacks'), 
('Accesorios y Paseo'), 
('Higiene y Estética'), 
('Juguetes y Enriquecimiento'), 
('Salud y Farmacia'), 
('Indumentaria y Camas'), 
('Hábitat y Estética de Peces/Aves');
GO

INSERT INTO Especie (nombre_especie)
VALUES ('Ave'), ('Conejo'), ('Gato'), ('Perro'), ('Pez');
GO

INSERT INTO Tamano (nombre_tamano)
VALUES 
('Extra Pequeño / Toy'), 
('Pequeño'), 
('Mediano'), 
('Grande'), 
('Extra Grande'), 
('Universal');
GO

INSERT INTO Especie_Tamano (id_especie, id_tamano)
VALUES
-- 1. AVE
(1, 1), -- Ave - Extra Pequeño / Toy (Canarios, finches)
(1, 2), -- Ave - Pequeño (Cotorritas, agapornis)
(1, 3), -- Ave - Mediano (Loras, ninfas)
(1, 6), -- Ave - Universal / Único (Jaulas estándar, mixturas, accesorios)

-- 2. CONEJO / ROEDORES
(2, 1), -- Conejo - Extra Pequeño / Toy (Conejo Enano, hámsters)
(2, 2), -- Conejo - Pequeño (Conejo Holandés)
(2, 3), -- Conejo - Mediano (Conejo Cabaña)
(2, 6), -- Conejo - Universal / Único (Heno, viruta, comederos)

-- 3. GATO
(3, 1), -- Gato - Extra Pequeño / Toy (Kittens / Gatitos)
(3, 2), -- Gato - Pequeño
(3, 3), -- Gato - Mediano
(3, 4), -- Gato - Grande (Maine Coon, Ragdoll)
(3, 6), -- Gato - Universal / Único (Piedras sanitarias, rascadores, arneses)

-- 4. PERRO
(4, 1), -- Perro - Extra Pequeño / Toy (Caniche Toy, Chihuahua)
(4, 2), -- Perro - Pequeño (Pug, Dachshund)
(4, 3), -- Perro - Mediano (Bulldog Francés, Cocker)
(4, 4), -- Perro - Grande (Golden Retriever, Labradors)
(4, 5), -- Perro - Extra Grande (Gran Danés, San Bernardo)
(4, 6), -- Perro - Universal / Único (Shampoos, pretales regulables, juguetes)

-- 5. PEZ
(5, 2), -- Pez - Pequeño (Guppys, Tetras)
(5, 3), -- Pez - Mediano (Carassius, Escalares)
(5, 4), -- Pez - Grande (Cíclidos, Carpas)
(5, 6); -- Pez - Universal / Único (Anticloro, escamas, adornos)
GO

INSERT INTO Producto 
(codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, stock_actual, stock_minimo, id_categoria, id_especie, id_tamano)
VALUES
-- PERROS
('779800000001', 'Alimento Perro Cachorro 15kg',  'Balanceado crecimiento raza grande',        14000.00, 22000.00,  5,  5, 2, 4, 4), -- Alimento, Perro, Grande (Stock Mínimo)
('779800000003', 'Hueso Prensado de Cuero 10u',   'Snack dental digestible',                  1200.00,  2300.00,  3,  4, 2, 4, 3), -- Alimento, Perro, Mediano (Stock Crítico)
('779800000005', 'Collar Regulable Perro',        'Nylon reforzado con argolla',              1200.00,  2400.00, 15,  5, 1, 4, 3), -- Accesorio, Perro, Mediano
('779800000007', 'Cepillo Cardina Deslanador',   'Remueve pelo muerto felino/canino',         1800.00,  3200.00,  5,  5, 3, 4, 3), -- Higiene, Perro, Mediano
('779800000008', 'Pelota Goma Mordillo',          'Juguete interactivo irrompible',           900.00,   1800.00, 25,  5, 4, 4, 2), -- Juguete, Perro, Pequeño
('779800000011', 'Comedero Acero Inoxidable 1L',  'Base antideslizante goma',                 1500.00,  2900.00, 18,  5, 1, 4, 4), -- Accesorio, Perro, Grande
('779800000013', 'Vitaminas Suplemento Canino',   'Complejo vitamínico 60 comprimidos',       3800.00,  6500.00, 15,  4, 5, 4, 3), -- Salud, Perro, Mediano
('779800000016', 'Shampoo Antipulgas Canino 500ml','Fórmula antiseborreica con aloe vera',    2100.00,  3800.00,  2,  5, 3, 4, 6), -- Higiene, Perro, Universal (Stock Crítico)
('779800000017', 'Cama Cueva Rellena Canina',     'Almohadón térmico desmontable',            8500.00, 14900.00,  8,  3, 1, 4, 1), -- Accesorio, Perro, Extra Pequeño/Toy

-- GATOS
('779800000002', 'Pipeta Antiparasitaria Gato',   'Protección mensual felina',                2500.00,  4500.00,  8,  8, 5, 3, 6), -- Salud, Gato, Universal
('779800000004', 'Alimento Gato Adulto 3kg',     'Fórmula control bola de pelo',              5200.00,  8500.00,  6,  6, 2, 3, 3), -- Alimento, Gato, Mediano
('779800000010', 'Piedras Sanitarias Gato 4kg',   'Absorbentes aglomerantes ecológicas',      1900.00,  3400.00, 40, 10, 3, 3, 6), -- Higiene, Gato, Universal
('779800000012', 'Rascador Poste Yute Gato',      'Rascador compacto con base de felpa',      4500.00,  7900.00, 12,  3, 4, 3, 2), -- Juguete, Gato, Pequeño
('779800000018', 'Hierba Gatera Catnip 50g',      'Estimulante natural para juego',            950.00,  1750.00, 22,  5, 4, 3, 6), -- Juguete, Gato, Universal

-- AVES
('779800000006', 'Alimento Mezcla Semillas 1kg',  'Semillas seleccionadas para aves pequeñas',  800.00,   1500.00, 14,  5, 2, 1, 2), -- Alimento, Ave, Pequeño
('779800000019', 'Jaula Espaciosa para Aves',     'Bandeja extraíble con comederos',          9800.00, 16500.00,  4,  2, 1, 1, 3), -- Accesorio, Ave, Mediano

-- CONEJOS Y ROEDORES
('779800000014', 'Bebedero Automático Conejos',   'Pico de bronce antiderrame 500ml',         1100.00,  2100.00, 20,  6, 1, 2, 2), -- Accesorio, Conejo, Pequeño
('779800000020', 'Alfalfa en Rama Heno 500g',     'Fibra natural para digestión roedores',    1100.00,  1950.00,  3,  6, 2, 2, 6), -- Alimento, Conejo, Universal (Stock Crítico)

-- PECES 
('779800000015', 'Alimento Pez Hojuelas 100g',    'Alimento completo para peces tropicales',   650.00,  1250.00, 30,  8, 2, 5, 2), -- Alimento, Pez, Pequeño
('779800000021', 'Acondicionador Anticloro 100ml','Neutraliza cloro y metales pesados',        850.00,  1600.00, 18,  4, 5, 5, 6); -- Salud, Pez, Universal

INSERT INTO Producto 
(codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, stock_actual, stock_minimo, id_categoria)
VALUES
-- HIGIENE Y LIMPIEZA GENERAL
('7798000000016', 'Shampoo Antiséptico 500ml',   'Higiene dermatológica de uso general',     3100.00,  5800.00,  4, 4, 3), -- Stock Mínimo
('7798000000022', 'Desinfectante Limpiador 1L',  'Eliminador de olores y bacterias amonio',  1800.00,  3200.00, 15, 5, 3),
('7798000000023', 'Paños Absorbentes Multiuso',   'Rollos de papel absorbente para clínica',   1200.00,  2100.00,  2, 5, 3), -- Stock Crítico

-- ACCESORIOS Y GENERALES
('7798000000024', 'Bolsas Biodegradables 3u',    'Bolsas para residuos de paseo en rollo',    850.00,  1500.00, 50, 10, 1),
('7798000000025', 'Transportadora Rígida Std',   'Caja de transporte homologada estándar',   9500.00, 16900.00,  6,  2, 1),

-- SALUD / FARMACIA
('7798000000026', 'Gasas Esterilizadas 50u',     'Insumo de curación para botiquín',          650.00,  1200.00, 25,  8, 5),
('7798000000027', 'Solución Fisiológica 500ml', 'Limpieza de heridas y mucosas',              900.00,  1700.00,  3,  5, 5), -- Stock Crítico

-- SERVICIOS / ALIMENTACIÓN GENERAL
('7798000000028', 'Consulta Veterinaria General','Atención médica ambulatoria básica',      8000.00, 12000.00, 999, 10, 5),
('7798000000029', 'Snack Premios Surtidos 250g', 'Golosinas mixtas para adiestramiento',   1100.00,  2100.00, 18,  6, 2);

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