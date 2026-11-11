CREATE PROCEDURE sp_ObtenerVentasPorVendedor
	@fecha_inicio DATE,
	@fecha_fin DATE
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		v.id_venta AS [ID Venta],
		v.nro_factura AS [Nro. Factura],
		v.fecha_hora AS [Fecha y Hora], 
		CONCAT(u.nombre, ' ', u.apellido) AS [Vendedor], 
		v.descuento AS [Descuento],
		v.total AS [Total]
	FROM Venta v
	INNER JOIN Usuario u ON (v.id_usuario = u.id_usuario)
	WHERE CAST(v.fecha_hora AS DATE) BETWEEN @fecha_inicio AND @fecha_fin
	ORDER BY v.fecha_hora DESC;
END;