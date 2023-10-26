-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 18-Out-2023 às 00:57
-- Versão do servidor: 8.0.31
-- versão do PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `hotelx`
--
CREATE DATABASE IF NOT EXISTS `hotelx` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `hotelx`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `hospedes`
--

DROP TABLE IF EXISTS `hospedes`;
CREATE TABLE IF NOT EXISTS `hospedes` (
  `nomeh` varchar(50) NOT NULL,
  `emailh` varchar(50) NOT NULL,
  `telefoneh` varchar(20) NOT NULL,
  `cpfh` varchar(12) NOT NULL,
  `fotoh` text NOT NULL,
  `idh` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idh`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `hospedes`
--

INSERT INTO `hospedes` (`nomeh`, `emailh`, `telefoneh`, `cpfh`, `fotoh`, `idh`) VALUES
('teste3', 'teste3@teste,com', '4197962525', '366.016.460', '', 3),
('teste4', 'teste4@teste,com', '4197962525', '907.011.050-', '', 4),
('teste2', 'teste@teste,com', '4197962525', '366.016.460-', '', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `perfil`
--

DROP TABLE IF EXISTS `perfil`;
CREATE TABLE IF NOT EXISTS `perfil` (
  `id_perfil` int NOT NULL AUTO_INCREMENT,
  `perfil` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `perfil`) VALUES
(1, 'Usuario'),
(2, 'Administrador');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `cod_prod` int NOT NULL AUTO_INCREMENT,
  `desc_prod` varchar(60) DEFAULT NULL,
  `preco_prod` decimal(7,2) DEFAULT NULL,
  `qtde_prod` int DEFAULT NULL,
  `perecivel` tinyint(1) DEFAULT NULL,
  `dat_validade` date DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cod_prod`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`cod_prod`, `desc_prod`, `preco_prod`, `qtde_prod`, `perecivel`, `dat_validade`, `foto`) VALUES
(1, 'Coca cola 500 ml', '6.70', 200, 0, '2023-08-14', 'E:\\C#\\coca.png'),
(3, 'Necal radical', '6.00', 150, 0, '2027-08-18', 'E:\\C#\\nescalradical.png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `quartos`
--

DROP TABLE IF EXISTS `quartos`;
CREATE TABLE IF NOT EXISTS `quartos` (
  `nomeq` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `capacidadeq` int NOT NULL,
  `preçoq` float NOT NULL,
  `status_id` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `idq` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idq`),
  KEY `status_id_fk` (`status_id`(15))
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `quartos`
--

INSERT INTO `quartos` (`nomeq`, `capacidadeq`, `preçoq`, `status_id`, `idq`) VALUES
('Quarto 01', 2, 120, '1', 1),
('Quarto 02', 2, 120, '2', 2),
('Quarto02', 3, 150, '1', 3),
('Quarto03', 4, 200, '3', 4),
('Quarto04', 3, 150, '4', 5),
('Quarto05', 2, 120, '5', 6),
('Quarto 06', 4, 200, '2', 7),
('Quarto 07', 1, 90, '1', 8);

-- --------------------------------------------------------

--
-- Estrutura da tabela `reservas`
--

DROP TABLE IF EXISTS `reservas`;
CREATE TABLE IF NOT EXISTS `reservas` (
  `idh` int NOT NULL,
  `idq` int NOT NULL,
  `datainr` datetime NOT NULL,
  `dataoutr` datetime NOT NULL,
  `preçor` float NOT NULL,
  `nhospedesr` int NOT NULL,
  `statusr` text NOT NULL,
  `idr` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idr`),
  KEY `idh_fk` (`idh`),
  KEY `idq_fk` (`idq`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `reservas`
--

INSERT INTO `reservas` (`idh`, `idq`, `datainr`, `dataoutr`, `preçor`, `nhospedesr`, `statusr`, `idr`) VALUES
(4, 3, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 0, 1, 'Reservado', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `status`
--

DROP TABLE IF EXISTS `status`;
CREATE TABLE IF NOT EXISTS `status` (
  `idstatus` int NOT NULL AUTO_INCREMENT,
  `status` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`idstatus`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `status`
--

INSERT INTO `status` (`idstatus`, `status`) VALUES
(1, 'Disponível'),
(2, 'Reservado'),
(3, 'Ocupado'),
(4, 'Entrega Hoje'),
(5, 'Manutenção');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `nome` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `senha` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `idperfil` int NOT NULL,
  `idusuario` int NOT NULL AUTO_INCREMENT,
  `email` varchar(75) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `fotousu` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idusuario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`nome`, `senha`, `idperfil`, `idusuario`, `email`, `fotousu`) VALUES
('pedro', 'aula123', 2, 1, 'pemaia92@outlook.com', 'E:\\C#\\Hotel\\icon\\funcionariosfts\\Funcionario01'),
('noah', 'aluno123', 2, 2, '', NULL),
('Saitama', 'f97c5d29941bfb1b2fdab0874906ab82', 0, 3, 'Saitama@gmail.com', NULL),
('pedro2', '202cb962ac59075b964b07152d234b70', 1, 4, 'email.com', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
