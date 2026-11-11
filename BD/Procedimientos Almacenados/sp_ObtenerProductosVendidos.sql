CREATE PROCEDURE sp_ObtenerProductosVendidos
    @fecha_inicio DATE,
    @fecha_fin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 10
        p.nombre_producto AS [Producto],
        ISNULL(c.nombre_categoria, 'Sin Categoria') AS [Categoria],
        SUM(dv.cantidad) AS [Unidades Vendidas],
        SUM(dv.cantidad * dv.precio_unitario) AS [Total Generado]
    FROM Detalle_Venta dv
    INNER JOIN Producto p ON dv.id_producto = p.id_producto
    INNER JOIN Categoria c ON p.id_categoria = c.id_categoria
    INNER JOIN Venta v ON dv.id_venta = v.id_venta
    WHERE v.fecha_hora >= @fecha_inicio 
      AND v.fecha_hora <= @fecha_fin
    GROUP BY p.nombre_producto, c.nombre_categoria
    ORDER BY [Unidades Vendidas] DESC;
END;