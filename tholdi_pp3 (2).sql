-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 28 mars 2022 à 05:17
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `tholdi_pp3`
--

-- --------------------------------------------------------

--
-- Structure de la table `container`
--

DROP TABLE IF EXISTS `container`;
CREATE TABLE IF NOT EXISTS `container` (
  `numContainer` int(6) NOT NULL,
  `dateAchat` date DEFAULT NULL,
  `typeContainer` varchar(40) NOT NULL,
  `dateDerniereInsp` date DEFAULT NULL,
  PRIMARY KEY (`numContainer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `container`
--

INSERT INTO `container` (`numContainer`, `dateAchat`, `typeContainer`, `dateDerniereInsp`) VALUES
(1, '2022-03-03', 'Small Dry Freigh Container', '2022-03-15'),
(2, '2022-03-02', 'Medium Dry Freight Container', '2022-03-03'),
(3, '2022-03-03', 'Hight Cube Dry Freight Container', '2022-03-04'),
(4, '2022-03-05', 'Small Flat Rack Container', '2022-03-06'),
(5, '2022-03-07', 'Medium Flat Rack Container', '2022-03-08'),
(6, '2022-03-09', 'Small Open Top Container', '2022-03-10'),
(7, '2022-03-11', 'Medium Open Top Container', '2022-03-12'),
(8, '2022-03-13', 'Small Reefer Container', '2022-03-14'),
(9, '2022-03-15', 'Medium Reefer Container', '2022-03-16');

-- --------------------------------------------------------

--
-- Structure de la table `decision`
--

DROP TABLE IF EXISTS `decision`;
CREATE TABLE IF NOT EXISTS `decision` (
  `dateEnvoi` date DEFAULT NULL,
  `dateRetour` date DEFAULT NULL,
  `commentaireDecision` varchar(100) DEFAULT NULL,
  `numContainer` int(6) NOT NULL,
  `numInspection` int(3) NOT NULL,
  `codetravaux` char(6) NOT NULL,
  PRIMARY KEY (`numContainer`,`numInspection`,`codetravaux`),
  KEY `fk_Travaux` (`codetravaux`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `declaration`
--

DROP TABLE IF EXISTS `declaration`;
CREATE TABLE IF NOT EXISTS `declaration` (
  `codeDeclaration` int(6) NOT NULL AUTO_INCREMENT,
  `commentaireDeclaration` varchar(100) DEFAULT NULL,
  `dateDecision` date DEFAULT NULL,
  `urgence` tinyint(1) DEFAULT NULL,
  `traite` tinyint(1) DEFAULT NULL,
  `numContainer` int(6) DEFAULT NULL,
  `codeProbleme` char(4) DEFAULT NULL,
  `libelleProbleme` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`codeDeclaration`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `declaration`
--

INSERT INTO `declaration` (`codeDeclaration`, `commentaireDeclaration`, `dateDecision`, `urgence`, `traite`, `numContainer`, `codeProbleme`, `libelleProbleme`) VALUES
(1, 'Marvin le salot', '2001-10-06', 1, 1, 25, 'prob', 'Container Cassée');

-- --------------------------------------------------------

--
-- Structure de la table `inspection`
--

DROP TABLE IF EXISTS `inspection`;
CREATE TABLE IF NOT EXISTS `inspection` (
  `numInspection` int(3) NOT NULL AUTO_INCREMENT,
  `dateInspection` date DEFAULT NULL,
  `commentairePostInspection` varchar(100) DEFAULT NULL,
  `Avis` varchar(20) DEFAULT NULL,
  `numContainer` int(6) NOT NULL,
  `libelleMotif` varchar(40) DEFAULT NULL,
  `libelleEtat` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`numInspection`,`numContainer`),
  KEY `fk_Container` (`numContainer`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `inspection`
--

INSERT INTO `inspection` (`numInspection`, `dateInspection`, `commentairePostInspection`, `Avis`, `numContainer`, `libelleMotif`, `libelleEtat`) VALUES
(1, '2022-10-21', NULL, 'za', 3, 'ez', 'rz'),
(2, '2022-10-21', NULL, 'za', 3, 'ez', 'rz'),
(3, '2022-10-21', NULL, 'za', 3, 'ez', 'rz'),
(4, '2022-03-23', 'zq', 'zz', 1, 'z', 'z'),
(5, '2022-03-23', 'zq', 'zz', 1, 'z', 'z'),
(6, '2022-03-22', 'Blablablda', 'Très mauvais', 2, 'Hehe', 'Médiocre'),
(7, '2022-03-22', 'zq', 'qz', 10, 'zq', 'qz');

-- --------------------------------------------------------

--
-- Structure de la table `travaux`
--

DROP TABLE IF EXISTS `travaux`;
CREATE TABLE IF NOT EXISTS `travaux` (
  `codeTravaux` char(6) NOT NULL,
  `libelleTravaux` varchar(30) NOT NULL,
  `dureeImmobilisation` int(3) NOT NULL,
  PRIMARY KEY (`codeTravaux`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `decision`
--
ALTER TABLE `decision`
  ADD CONSTRAINT `fk_Inspection` FOREIGN KEY (`numContainer`,`numInspection`) REFERENCES `inspection` (`numContainer`, `numInspection`),
  ADD CONSTRAINT `fk_Travaux` FOREIGN KEY (`codetravaux`) REFERENCES `travaux` (`codeTravaux`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
