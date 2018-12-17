-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  lun. 17 déc. 2018 à 22:49
-- Version du serveur :  10.1.37-MariaDB
-- Version de PHP :  7.3.0

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
  `carte_id` int(11) NOT NULL,
  `carte_num_event` int(11) NOT NULL,
  `pers_id` int(11) NOT NULL,
  `carte_txt` text COLLATE utf8_unicode_ci NOT NULL,
  `rep_i1` int(11) NOT NULL,
  `rep_id2` int(11) NOT NULL,
  `carte_obj` varchar(11) COLLATE utf8_unicode_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `effet`
--

CREATE TABLE `effet` (
  `ef_id` int(11) NOT NULL,
  `ef_nom` text COLLATE utf8_unicode_ci NOT NULL,
  `ef_sco` int(11) NOT NULL,
  `ef_sous` int(11) NOT NULL,
  `ef_soc` int(11) NOT NULL,
  `ef_sante` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `evenement`
--

CREATE TABLE `evenement` (
  `event_id` int(11) NOT NULL,
  `event_nom` text COLLATE utf8_unicode_ci NOT NULL,
  `event_jour` int(11) NOT NULL,
  `event_nbjour` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `fait`
--

CREATE TABLE `fait` (
  `f_id` int(11) NOT NULL,
  `f_nom` text COLLATE utf8_unicode_ci NOT NULL,
  `f_desc` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `mort`
--

CREATE TABLE `mort` (
  `mort_id` int(11) NOT NULL,
  `mort_nom` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `mort_image` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `objet`
--

CREATE TABLE `objet` (
  `obj_id` int(11) NOT NULL,
  `obj_nom` text NOT NULL,
  `obj_image` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `personnage`
--

CREATE TABLE `personnage` (
  `pers_id` int(11) NOT NULL,
  `pers_nom` text NOT NULL,
  `pers_image` text NOT NULL,
  `pers_couleur` text,
  `pers_annee` int(11) DEFAULT NULL,
  `pers_bureau` text,
  `pers_parrain` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `reponse`
--

CREATE TABLE `reponse` (
  `rep_id` int(11) NOT NULL,
  `rep_txt` text NOT NULL,
  `rep_sante` int(11) NOT NULL,
  `rep_soc` int(11) NOT NULL,
  `rep_sous` int(11) NOT NULL,
  `rep_sco` int(11) NOT NULL,
  `rep_carte_suivante` int(11) DEFAULT '-1',
  `rep_carte_avenir` int(11) DEFAULT '0',
  `rep_obj` varchar(11) DEFAULT '',
  `rep_effet` varchar(11) DEFAULT '',
  `rep_fait` int(11) DEFAULT '-1',
  `rep_mort` int(11) DEFAULT '0',
  `rep_cycle` varchar(1) NOT NULL DEFAULT '',
  `rep_debutEvent` int(11) DEFAULT '-1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `carte`
--
ALTER TABLE `carte`
  ADD PRIMARY KEY (`carte_id`),
  ADD KEY `Personnage` (`pers_id`),
  ADD KEY `Rep1` (`rep_i1`),
  ADD KEY `Rep2` (`rep_id2`);

--
-- Index pour la table `effet`
--
ALTER TABLE `effet`
  ADD PRIMARY KEY (`ef_id`);

--
-- Index pour la table `evenement`
--
ALTER TABLE `evenement`
  ADD PRIMARY KEY (`event_id`);

--
-- Index pour la table `fait`
--
ALTER TABLE `fait`
  ADD PRIMARY KEY (`f_id`);

--
-- Index pour la table `mort`
--
ALTER TABLE `mort`
  ADD PRIMARY KEY (`mort_id`);

--
-- Index pour la table `objet`
--
ALTER TABLE `objet`
  ADD PRIMARY KEY (`obj_id`);

--
-- Index pour la table `personnage`
--
ALTER TABLE `personnage`
  ADD PRIMARY KEY (`pers_id`);

--
-- Index pour la table `reponse`
--
ALTER TABLE `reponse`
  ADD PRIMARY KEY (`rep_id`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `carte`
--
ALTER TABLE `carte`
  ADD CONSTRAINT `carte_ibfk_2` FOREIGN KEY (`pers_id`) REFERENCES `personnage` (`pers_id`),
  ADD CONSTRAINT `carte_ibfk_3` FOREIGN KEY (`rep_i1`) REFERENCES `reponse` (`rep_id`),
  ADD CONSTRAINT `carte_ibfk_4` FOREIGN KEY (`rep_id2`) REFERENCES `reponse` (`rep_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
