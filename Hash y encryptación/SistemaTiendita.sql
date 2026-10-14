CREATE DATABASE SistemaTienda;
USE SistemaTienda;

create table EmpleadosTienda(
	idUsuario 		INT AUTO_INCREMENT PRIMARY KEY,
    userName 		VARCHAR(50) UNIQUE NOT NULL, 
    password 		VARCHAR(128) NOT NULL,
    firstName 		VARCHAR(100) NOT NULL,
    lastName 		VARCHAR(100) NOT NULL,
    gender 			ENUM('Masculino', 'Femenino', 'Otro', 'Prefiero no decirlo'),
    email 			VARCHAR(150) UNIQUE NOT NULL,
    sucursal        VARCHAR(100) NOT NULL,
    puesto          VARCHAR(100) NOT NULL,
    userStatus 		ENUM('Active', 'Inactive') DEFAULT 'Active',
    rol 			ENUM('Administrador', 'Empleado') NOT NULL,
    createdDate 	DATETIME DEFAULT CURRENT_TIMESTAMP,
    phone 			VARCHAR(20),
    address 		VARCHAR(255),
    birthdate 		DATE,
    curp 			BLOB,
    rfc 			BLOB,
    cuentaBancaria 	BLOB,
    salario 		BLOB
);

CREATE USER 'SaulZJ'@'%' IDENTIFIED BY 'clave123';

GRANT ALL PRIVILEGES ON *.* TO 'SaulZJ'@'%' WITH GRANT OPTION;

INSERT INTO EmpleadosTienda (
    userName, password, firstName, lastName, gender, email, 
    sucursal, puesto, userStatus, rol, phone, address, birthdate, 
    curp, rfc, cuentaBancaria, salario
) VALUES 
('admin_carlos', SHA2('PassAdmin1!', 256), 'Carlos', 'Ruiz', 'Masculino',
 'cruiz@mitienda.com', 'Sucursal Centro', 'Gerente General', 'Active', 
 'Administrador', '555-1111', 'Av. Reforma 123, CDMX', '1985-06-15', 
 AES_ENCRYPT('RUIC850615HDFXYZ', 'ClaveSecretaCURP'), 
 AES_ENCRYPT('RUIC850615ABC', 'ClaveSecretaRFC'), 
 AES_ENCRYPT('1234567890', 'ClaveSecretaCuentaB'), 
 AES_ENCRYPT('35000', 'ClaveSecretaSalario')),
 
('admin_diana', SHA2('PassAdmin2!', 256), 'Diana', 'Torres', 'Femenino', 
'dtorres@mitienda.com','Sucursal Norte', 'Supervisora de Ventas', 'Active',
'Administrador', '555-2222', 'Calle Pino 45, MTY', '1992-09-30', 
 AES_ENCRYPT('TORD920930MNLXYZ', 'ClaveSecretaCURP'), 
 AES_ENCRYPT('TORD920930DEF', 'ClaveSecretaRFC'), 
 AES_ENCRYPT('0987654321', 'ClaveSecretaCuentaB'), 
 AES_ENCRYPT('28000', 'ClaveSecretaSalario')),

('emp_laura', SHA2('UserPass1!', 256), 'Laura', 'Gómez', 'Femenino', 
'lgomez@mitienda.com','Sucursal Centro', 'Cajera', 'Active', 'Empleado',
 '555-3333', 'Blvrd. Insurgentes 789, GDL', '1995-11-22', 
 AES_ENCRYPT('GOML951122MJCXYZ', 'ClaveSecretaCURP'), 
 AES_ENCRYPT('GOML951122GHI', 'ClaveSecretaRFC'), 
 AES_ENCRYPT('1122334455', 'ClaveSecretaCuentaB'), 
 AES_ENCRYPT('12000', 'ClaveSecretaSalario')),

('emp_mario', SHA2('UserPass2!', 256), 'Mario', 'Silva', 'Masculino', 
'msilva@mitienda.com', 'Sucursal Norte', 'Asesor de Piso', 'Active', 
'Empleado', '555-4444', 'Calle Roble 12, PUE', '1998-02-14', 
 AES_ENCRYPT('SILM980214HPLXYZ', 'ClaveSecretaCURP'), 
 AES_ENCRYPT('SILM980214JKL', 'ClaveSecretaRFC'), 
 AES_ENCRYPT('5544332211', 'ClaveSecretaCuentaB'), 
 AES_ENCRYPT('11500', 'ClaveSecretaSalario')),

('emp_sofia', SHA2('UserPass3!', 256), 'Sofía', 'Reyes', 'Femenino', 
'sreyes@mitienda.com', 'Sucursal Sur', 'Encargada de Almacén', 'Inactive', 
'Empleado', '555-5555', 'Av. Universidad 456, QRO', '1990-08-05', 
 AES_ENCRYPT('REYS900805MQTXYZ', 'ClaveSecretaCURP'), 
 AES_ENCRYPT('REYS900805MNO', 'ClaveSecretaRFC'), 
 AES_ENCRYPT('9988776655', 'ClaveSecretaCuentaB'), 
 AES_ENCRYPT('13000', 'ClaveSecretaSalario'));