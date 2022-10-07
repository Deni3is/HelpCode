-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: hotel
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `posechenie`
--

DROP TABLE IF EXISTS `posechenie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posechenie` (
  `Ключ` int NOT NULL AUTO_INCREMENT,
  `Номер_карточки` int DEFAULT NULL,
  `Явка` int DEFAULT NULL,
  `Дата` date DEFAULT NULL,
  `Состояние` varchar(100) DEFAULT NULL,
  `Лечение` varchar(100) DEFAULT NULL,
  `Исход` varchar(45) DEFAULT NULL,
  `След_посещение` date DEFAULT NULL,
  `МКБ` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Ключ`),
  UNIQUE KEY `Ключ_UNIQUE` (`Ключ`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posechenie`
--

LOCK TABLES `posechenie` WRITE;
/*!40000 ALTER TABLE `posechenie` DISABLE KEYS */;
INSERT INTO `posechenie` VALUES (6,2,0,'2022-07-01','','','Госпитализирован. Легкая степень. ','2022-07-01',''),(7,2,0,'2022-07-01','','','Госпитализирован. Легкая степень. ','2022-07-01',''),(8,2,0,'2022-07-01','','','Госпитализирован. Легкая степень. ','2022-07-01','');
/*!40000 ALTER TABLE `posechenie` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-01 19:06:08
