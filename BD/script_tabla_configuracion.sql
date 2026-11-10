-- 1. Crear la tabla de configuración global
CREATE TABLE Configuracion (
    clave VARCHAR(50) PRIMARY KEY,
    valor VARCHAR(50) NOT NULL,
    descripcion VARCHAR(150) NULL
);

-- 2. Insertar el permiso por defecto (1 = Habilitado, 0 = Deshabilitado)
INSERT INTO Configuracion (clave, valor, descripcion) 
VALUES ('PermisoBackupGerente', '1', 'Indica si el Rol Gerente tiene habilitado el botón de Backup');