-- MariaDB dump 10.17  Distrib 10.4.8-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: onlinegamedistributionservice
-- ------------------------------------------------------
-- Server version	10.4.8-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `games`
--

DROP TABLE IF EXISTS `games`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `games` (
  `GameID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(255) NOT NULL,
  `Price$` decimal(10,2) NOT NULL DEFAULT 0.00,
  `Type` int(11) NOT NULL,
  `Publisher` int(11) NOT NULL,
  PRIMARY KEY (`GameID`),
  UNIQUE KEY `Title` (`Title`),
  KEY `Type` (`Type`),
  KEY `Publisher` (`Publisher`),
  CONSTRAINT `games_ibfk_1` FOREIGN KEY (`Type`) REFERENCES `genres` (`GenreID`),
  CONSTRAINT `games_ibfk_2` FOREIGN KEY (`Publisher`) REFERENCES `publishers` (`PublisherID`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `games`
--

LOCK TABLES `games` WRITE;
/*!40000 ALTER TABLE `games` DISABLE KEYS */;
INSERT INTO `games` VALUES (100,'DOTA 2',0.00,34,1902),(101,'Hearthstone',0.00,49,3648),(102,'Minecraft',26.95,7,7777),(103,'Overwatch',19.99,3,3648),(104,'Witcher 3',49.99,20,8969),(105,'CS:GO',0.00,3,1902);
/*!40000 ALTER TABLE `games` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genres`
--

DROP TABLE IF EXISTS `genres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genres` (
  `GenreID` int(11) NOT NULL AUTO_INCREMENT,
  `Genre` varchar(255) NOT NULL,
  PRIMARY KEY (`GenreID`),
  UNIQUE KEY `Genre` (`Genre`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genres`
--

LOCK TABLES `genres` WRITE;
/*!40000 ALTER TABLE `genres` DISABLE KEYS */;
INSERT INTO `genres` VALUES (31,'4x'),(1,'Action'),(10,'Action Adventure'),(13,'Adventure'),(20,'ARPG'),(32,'Artillery'),(33,'Autochess'),(8,'Battle Royale'),(5,'Beat\'em up'),(48,'Board Card game'),(43,'Casual'),(46,'Competetive'),(27,'Construction and management sim'),(49,'DCCG'),(4,'Fighting'),(25,'First Person Party Based RPG'),(41,'Grand Strategy Wargame'),(15,'Graphic adventure'),(17,'Interactive movie'),(28,'Life simulation'),(44,'Logic'),(12,'Metroidvania'),(50,'MMO'),(21,'MMORPG'),(34,'MOBA'),(2,'Platformer'),(45,'Racing'),(9,'Rhythm'),(19,'Roleplaying'),(22,'Rougelike'),(18,'RT 3-D adventure'),(35,'RTS'),(36,'RTT'),(24,'SandboxRPG'),(3,'Shooter'),(26,'Simulation'),(42,'Sports'),(47,'Sports-based fighting'),(6,'Stealth'),(30,'Strategy'),(7,'Survival'),(11,'Survival Horror'),(23,'TaticalRPG'),(38,'TBS'),(39,'TBT'),(37,'TD'),(14,'Text Adventure'),(29,'Vehicle simulation'),(16,'Visual novels'),(40,'Wargame');
/*!40000 ALTER TABLE `genres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderedgames`
--

DROP TABLE IF EXISTS `orderedgames`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderedgames` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `Purchase` int(11) NOT NULL,
  `Game` int(11) NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `Purchase` (`Purchase`),
  KEY `Game` (`Game`),
  CONSTRAINT `orderedgames_ibfk_1` FOREIGN KEY (`Purchase`) REFERENCES `purchases` (`PurchaseID`),
  CONSTRAINT `orderedgames_ibfk_2` FOREIGN KEY (`Game`) REFERENCES `games` (`GameID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderedgames`
--

LOCK TABLES `orderedgames` WRITE;
/*!40000 ALTER TABLE `orderedgames` DISABLE KEYS */;
INSERT INTO `orderedgames` VALUES (1,194001,100),(2,194002,101),(3,194003,102),(4,194004,103),(5,194005,103);
/*!40000 ALTER TABLE `orderedgames` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publishers`
--

DROP TABLE IF EXISTS `publishers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `publishers` (
  `PublisherID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Website` varchar(255) NOT NULL,
  PRIMARY KEY (`PublisherID`),
  UNIQUE KEY `Name` (`Name`),
  UNIQUE KEY `Website` (`Website`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publishers`
--

LOCK TABLES `publishers` WRITE;
/*!40000 ALTER TABLE `publishers` DISABLE KEYS */;
INSERT INTO `publishers` VALUES (1222,'Riot Games','riotgames.com'),(1902,'Valve','valvesoftware.com'),(3648,'Blizzard Entertainment','blizzard.com'),(7777,'Mojang','mojang.com'),(8969,'CD Projekt','cdprojekt.com');
/*!40000 ALTER TABLE `publishers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchases`
--

DROP TABLE IF EXISTS `purchases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchases` (
  `PurchaseID` int(11) NOT NULL AUTO_INCREMENT,
  `PurchaseDate` date NOT NULL,
  `User` int(11) NOT NULL,
  PRIMARY KEY (`PurchaseID`),
  KEY `User` (`User`),
  CONSTRAINT `purchases_ibfk_1` FOREIGN KEY (`User`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=194006 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchases`
--

LOCK TABLES `purchases` WRITE;
/*!40000 ALTER TABLE `purchases` DISABLE KEYS */;
INSERT INTO `purchases` VALUES (194001,'2019-12-09',1000),(194002,'2019-12-09',1001),(194003,'2019-12-10',1002),(194004,'2019-12-10',1002),(194005,'2019-12-10',1003);
/*!40000 ALTER TABLE `purchases` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Email` varchar(255) NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=1005 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1000,'Reigen','reigen@mail.com'),(1001,'Mob','mob@mail.com'),(1002,'Saitama','saitama@mail.com'),(1003,'Genos','genos@mail.com'),(1004,'Dimple','dimple@mail.com');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-20  9:00:13
