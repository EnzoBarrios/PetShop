-- Obtenemos los productos cuyo stock actual es menor o igual al stock mínimo
CREATE PROCEDURE sp_ObtenerStockCritico
AS
BEGIN -- Manera de evitar que se muestren mensajes de conteo de filas afectadas
	SET NOCOUNT ON;

	SELECT
		p.id_producto AS [ID Producto],
		p.codigo_barra AS [Codigo Barra],
		p.nombre_producto AS [Producto],
		c.nombre_categoria AS [Categoria],
		ISNULL(e.nombre_especie, 'No especificado') AS [Especie],
		ISNULL(t.nombre_tamano, 'No especificado') AS [Tamaño],
		p.stock_actual AS [Stock Actual],
		p.stock_minimo AS [Stock Minimo]
	FROM Producto p
	INNER JOIN Categoria c ON (p.id_categoria = c.id_categoria)
	LEFT JOIN Especie e ON (p.id_especie = e.id_especie)
	LEFT JOIN Tamano t ON (p.id_tamano = t.id_tamano)
	WHERE p.stock_actual <= p.stock_minimo
	ORDER BY p.stock_actual ASC;
END;