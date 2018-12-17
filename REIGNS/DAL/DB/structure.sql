-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  ven. 14 déc. 2018 à 13:30
-- Version du serveur :  10.1.31-MariaDB
-- Version de PHP :  5.6.35
drop table if exists carte;
drop table if exists effet;
drop table if exists evenement;
drop table if exists fait;
drop table if exists mort;
drop table if exists objet;
drop table if exists personnage;
drop table if exists reponse;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `reignsensc`
--

-- --------------------------------------------------------

--
-- Structure de la table `carte`
--

CREATE TABLE `carte` (
  `Id` int(11) NOT NULL,
  `Texte` text COLLATE utf8_unicode_ci NOT NULL,
  `ObjetPossible` int(11) NOT NULL,
  `NumEvent` int(11) NOT NULL,
  `Personnage` int(11) NOT NULL,
  `Rep1` int(11) NOT NULL,
  `Rep2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `effet`
--

CREATE TABLE `effet` (
  `Id` int(11) NOT NULL,
  `Nom` text COLLATE utf8_unicode_ci NOT NULL,
  `EffetScolaire` int(11) NOT NULL,
  `EffetSous` int(11) NOT NULL,
  `EffetSante` int(11) NOT NULL,
  `EffetSocial` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

CREATE TABLE `evenement` (
  `Id` int(11) NOT NULL,
  `Nom` text COLLATE utf8_unicode_ci NOT NULL,
  `JourHappen` date NOT NULL,
  `NbCarteTirer` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `fait`
--

CREATE TABLE `fait` (
  `Id` int(11) NOT NULL,
  `Nom` text COLLATE utf8_unicode_ci NOT NULL,
  `Description` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `mort`
--

CREATE TABLE `mort` (
  `Id` int(11) NOT NULL,
  `Nom` text COLLATE utf8_unicode_ci NOT NULL,
  `Image` text COLLATE utf8_unicode_ci NOT NULL,
  `Actif` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `objet`
--

CREATE TABLE `objet` (
  `Id` int(11) NOT NULL,
  `Nom` text NOT NULL,
  `Image` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `personnage`
--

CREATE TABLE `personnage` (
  `Id` int(11) NOT NULL,
  `Nom` text NOT NULL,
  `Image` text NOT NULL,
  `Annee` int(11) NOT NULL,
  `Couleur` text,
  `Bureau` text,
  `etreParrain` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `reponse`
--

CREATE TABLE `reponse` (
  `Id` int(11) NOT NULL,
  `Texte` text NOT NULL,
  `effetSante` int(11) NOT NULL,
  `effetSous` int(11) NOT NULL,
  `effetScolaire` int(11) NOT NULL,
  `effetSocial` int(11) NOT NULL,
  `CarteSuivante` int(11) DEFAULT NULL,
  `ChgtObjet` int(11) DEFAULT NULL,
  `ChgtEffet` int(11) DEFAULT NULL,
  `FaitId` int(11) DEFAULT NULL,
  `MortId` int(11) DEFAULT NULL,
  `CarteAVenir` int(11) DEFAULT NULL,
  `Cycle` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `carte`
--
ALTER TABLE `carte`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Personnage` (`Personnage`),
  ADD KEY `Rep1` (`Rep1`),
  ADD KEY `Rep2` (`Rep2`);

--
-- Index pour la table `effet`
--
ALTER TABLE `effet`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `fait`
--
ALTER TABLE `fait`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `mort`
--
ALTER TABLE `mort`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `objet`
--
ALTER TABLE `objet`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `personnage`
--
ALTER TABLE `personnage`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `reponse`
--
ALTER TABLE `reponse`
  ADD PRIMARY KEY (`Id`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `carte`
--
ALTER TABLE `carte`
  ADD CONSTRAINT `carte_ibfk_2` FOREIGN KEY (`Personnage`) REFERENCES `personnage` (`Id`),
  ADD CONSTRAINT `carte_ibfk_3` FOREIGN KEY (`Rep1`) REFERENCES `reponse` (`Id`),
  ADD CONSTRAINT `carte_ibfk_4` FOREIGN KEY (`Rep2`) REFERENCES `reponse` (`Id`);

COMMIT;

ALTER TABLE `mort` CHANGE `Actif` `Actif` TINYINT(1) NOT NULL DEFAULT '0';
ALTER TABLE `mort` CHANGE `Image` `Image` TEXT CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;