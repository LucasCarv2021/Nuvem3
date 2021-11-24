CREATE DATABASE lista_cliente;

CREATE TABLE `lista_cliente`.`cliente` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NULL,
  `Telefone` VARCHAR(45) NOT NULL,
  `Categoria` VARCHAR(45) NOT NULL,
  `Ativo` TINYINT NOT NULL,
  PRIMARY KEY (`idCliente`));

