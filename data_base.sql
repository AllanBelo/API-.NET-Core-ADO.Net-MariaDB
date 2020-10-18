
CREATE DATABASE IF NOT EXISTS `data_base` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `data_base`;

-- Copiando estrutura para tabela data_base.people
CREATE TABLE IF NOT EXISTS `people` (
  `PersonID` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `AGE` int(11) NOT NULL,
  PRIMARY KEY (`PersonID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela data_base.people: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `people` DISABLE KEYS */;
INSERT INTO `people` (`PersonID`, `FirstName`, `LastName`, `AGE`) VALUES
	(1, 'José', 'Antonio', 42);

