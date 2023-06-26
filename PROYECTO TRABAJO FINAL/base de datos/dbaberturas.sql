create database dbaberturas;
use dbaberturas;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dbaberturas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aberturas`
--

CREATE TABLE `aberturas` (
  `idaberturas` int(11) NOT NULL,
  `alto` decimal(8,2) DEFAULT NULL,
  `ancho` decimal(8,2) DEFAULT NULL,
  `kgtotal` decimal(8,2) DEFAULT NULL,
  `preciokg` decimal(8,2) DEFAULT NULL,
  `idperfiles` int(11) DEFAULT NULL,
  `idvidrios` int(11) DEFAULT NULL,
  `idpresupuestos` int(11) DEFAULT NULL,
  `accesorios` varchar(50) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `aberturas`
--

INSERT INTO `aberturas` (`idaberturas`, `alto`, `ancho`, `kgtotal`, 
`preciokg`, `idperfiles`, `idvidrios`, `idpresupuestos`, `accesorios`) VALUES
(1, '3.00', '4.00', '114.00', '650.00', 1, 2, 1, 1),
(2, '3.00', '2.00', '115.20', '650.00', 16, NULL, 2, 0),
(3, '1.00', '2.00', '8.32', '650.00', 6, 1, 3, 0),
(4, '2.00', '2.00', '35.60', '650.00', 4, 2, 4, 0);


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `accesorios`
--

CREATE TABLE `accesorios` (
  `idaccesorios` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `kgaccesorios` decimal(8,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `accesorios`
--

INSERT INTO `accesorios` (`idaccesorios`, `descripcion`, `kgaccesorios`) VALUES
(1, 'contramarco', '1.00'),
(2, 'mosquitero', '1.70'),
(3, 'compacto', '1.00'),
(4, 'silovatiente', '3.00'),
(5, 'premarco', '1.00'),
(6, 'colocacion', '2.50');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `accesorios_de_aberturas`
--

CREATE TABLE `accesorios_de_aberturas` (
  `idaccesorios` int(11) NOT NULL,
  `idaberturas` int(11) NOT NULL,
  `nro_presupuesto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `accesorios_de_aberturas`
--

INSERT INTO `accesorios_de_aberturas` (`idaccesorios`, `idaberturas`, `nro_presupuesto`) VALUES
(2, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `idperfiles` int(11) NOT NULL,
  `linea` varchar(45) DEFAULT NULL,
  `kg` decimal(8,2) DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`idperfiles`, `linea`, `kg`, `tipo`, `descripcion`) VALUES
(1, 'modena', '8.90', 'ventana', 'corrediza'),
(2, 'modena', '4.52', 'ventana', 'paño fijo'),
(3, 'modena', '8.10', 'ventana', 'rebatir'),
(4, 'modena', '9.50', 'puerta', 'rebatir'),
(5, 'vesta', '6.88', 'ventana', 'rebatir'),
(6, 'vesta', '4.16', 'ventanta', 'paño fijo'),
(7, 'vesta', '9.44', 'ventana', 'rebatir'),
(8, 'vesta', '7.56', 'puerta', 'rebatir'),
(10, 'herrero', '7.76', 'ventana', 'corrediza'),
(11, 'herrero', '4.20', 'ventana', 'paño fijo'),
(12, 'herrero', '6.25', 'puerta', 'rebatir'),
(13, '30new', '6.00', 'ventana', 'paño fijo'),
(14, '30new', '10.60', 'ventana', 'rebatir'),
(15, '30new', '14.00', 'ventana', 'corrediza'),
(16, '30new', '19.20', 'puerta', 'rebatir');

-- --------------------------------------------------------

CREATE TABLE `personas` (
  `nombre` varchar(60) NOT NULL,
  `apellido` varchar(60) NOT NULL,
  `email` varchar(60) DEFAULT NULL,
  `user_id` int(11) primary key auto_increment
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`nombre`, `apellido`, `email`) VALUES
('Ana', 'Gonzales', NULL),
('Pablo', 'Perez', NULL),
('Carlos', 'Fernandez', NULL),
('Juan', 'Perez', NULL),
('Ana Karenina', 'Fernández', NULL),
('Vicente', 'Juarez', NULL),
('Juana', 'Perez', NULL),
('Karina', 'Kunt', NULL);

CREATE TABLE `usuarios` (
  `user_dni` int(8) NOT NULL,
  `user_perfil` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `user_psw` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `user_id` int(11) primary key auto_increment
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`user_dni`, `user_perfil`, `user_psw`) VALUES
(123, 'E', '3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2'),
(456, 'E', 'f6b07b6c1340e947b861def5f8b092d8ee710826dc56bd175bdc8f3a16b0b8acf853c64786a710dedf9d1524d61e32504e27d60de159af110bc3941490731578'),
(789, 'A', 'ca9879bd727ba3bd815f05fe6b9e4640c774b61cc8f141295542cefc1b7b8fc6e3daf3f656555cdec355894e7af48964e88994d960f41ba8f61f7a05d5ddbd07');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `presupuestos`
--

CREATE TABLE `presupuestos` (
  `idpresupuestos` int(11) NOT NULL,
  `cliente` varchar(45) DEFAULT NULL,
  `fecharealizado` date DEFAULT NULL,
  `preciototal` decimal(8,2) DEFAULT NULL,
  `fechaexpira` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `presupuestos`
--

INSERT INTO `presupuestos` (`idpresupuestos`, `cliente`, `fecharealizado`, `preciototal`, `fechaexpira`) VALUES
(1, 'ezequiel', '2019-11-05', '23140.00', '2019-11-15'),
(2, 'polilla', '2019-11-10', '74880.00', '2019-11-25'),
(3, 'rick', '2019-11-15', '5408.00', '2019-11-30'),
(4, 'ezequiel', '2019-11-20', '74100.00', '2019-12-05');

-- --------------------------------------------------------


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vidrios`
--

CREATE TABLE `vidrios` (
  `idvidrios` int(11) NOT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `kgvidrios` decimal(8,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `vidrios`
--

INSERT INTO `vidrios` (`idvidrios`, `tipo`, `kgvidrios`) VALUES
(1, 'dvh1', '1.00'),
(2, 'dvh2', '2.00'),
(3, 'dvh3', '3.00'),
(4, 'dvh4', '4.00'),
(5, 'merilado', '1.00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aberturas`
--
ALTER TABLE `aberturas`
  ADD PRIMARY KEY (`idaberturas`),
  ADD KEY `fk_aberturas_perfiles_idx` (`idperfiles`),
  ADD KEY `fk_aberturas_vidrios1_idx` (`idvidrios`),
  ADD KEY `fk_aberturas_presupuestos1_idx` (`idpresupuestos`);

--
-- Indices de la tabla `accesorios`
--
ALTER TABLE `accesorios`
  ADD PRIMARY KEY (`idaccesorios`);

--
-- Indices de la tabla `accesorios_de_aberturas`
--
ALTER TABLE `accesorios_de_aberturas`
  ADD PRIMARY KEY (`idaccesorios`,`idaberturas`),
  ADD KEY `fk_accesorios_has_aberturas_aberturas1_idx` (`idaberturas`),
  ADD KEY `fk_accesorios_has_aberturas_accesorios1_idx` (`idaccesorios`);

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`idperfiles`);

--
-- Indices de la tabla `personas`
--
  

--
-- Indices de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  ADD PRIMARY KEY (`idpresupuestos`);

--
-- Indices de la tabla `usuarios`
--
  

--
-- Indices de la tabla `vidrios`
--
ALTER TABLE `vidrios`
  ADD PRIMARY KEY (`idvidrios`);

--
-- AUTO_INCREMENT de las tablas volcadas
--
--
-- AUTO_INCREMENT de la tabla `usuarios`
--


--
-- AUTO_INCREMENT de la tabla `personas`
--


--
-- AUTO_INCREMENT de la tabla `aberturas`
--
ALTER TABLE `aberturas`
  MODIFY `idaberturas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `accesorios`
--
ALTER TABLE `accesorios`
  MODIFY `idaccesorios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `idperfiles` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  MODIFY `idpresupuestos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `vidrios`
--
ALTER TABLE `vidrios`
  MODIFY `idvidrios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aberturas`
--
ALTER TABLE `aberturas`
  ADD CONSTRAINT `fk_aberturas_perfiles` FOREIGN KEY (`idperfiles`) REFERENCES `perfiles` (`idperfiles`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_aberturas_presupuestos1` FOREIGN KEY (`idpresupuestos`) REFERENCES `presupuestos` (`idpresupuestos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_aberturas_vidrios1` FOREIGN KEY (`idvidrios`) REFERENCES `vidrios` (`idvidrios`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `accesorios_de_aberturas`
--
ALTER TABLE `accesorios_de_aberturas`
  ADD CONSTRAINT `fk_accesorios_has_aberturas_aberturas1` FOREIGN KEY (`idaberturas`) REFERENCES `aberturas` (`idaberturas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_accesorios_has_aberturas_accesorios1` FOREIGN KEY (`idaccesorios`) REFERENCES `accesorios` (`idaccesorios`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `personas` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
