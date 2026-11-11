CREATE PROCEDURE sp_ObtenerVentasPorVendedor
    @fecha_inicio DATETIME,
    @fecha_fin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.id_usuario AS [ID Vendedor],
        CONCAT(u.nombre, ' ', u.apellido) AS [Vendedor],
        COUNT(v.id_venta) AS [Cantidad Ventas],
        SUM(v.descuento) AS [Total Descuentos],
        SUM(v.total) AS [Total],
        AVG(v.total) AS [Promedio Ticket]
    FROM Venta v
    INNER JOIN Usuario u ON v.id_usuario = u.id_usuario
    WHERE v.fecha_hora >= @fecha_inicio 
      AND v.fecha_hora <= @fecha_fin
    GROUP BY u.id_usuario, u.nombre, u.apellido
    ORDER BY Total DESC;
END;