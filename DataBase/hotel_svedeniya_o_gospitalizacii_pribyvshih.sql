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
-- Table structure for table `svedeniya_o_gospitalizacii_pribyvshih`
--

DROP TABLE IF EXISTS `svedeniya_o_gospitalizacii_pribyvshih`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `svedeniya_o_gospitalizacii_pribyvshih` (
  `Именование_субъекта_РФ` varchar(255) CHARACTER SET cp1251 COLLATE cp1251_general_ci DEFAULT NULL,
  `Наим_мед_организации` varchar(255) CHARACTER SET cp1251 COLLATE cp1251_general_ci DEFAULT NULL,
  `Гос_Вс_Взрослые_Всего` int DEFAULT NULL,
  `Гос_Вс_Взрослые_втч_раненых` int DEFAULT NULL,
  `Гос_Вс_Взрослые_втч_берем_женщин` int DEFAULT NULL,
  `Гос_Вс_Дети_Всего` int DEFAULT NULL,
  `Гос_Вс_Дети_втч_раненых` int DEFAULT NULL,
  `Гос_Вс_Дети_втч_до_1_года` int DEFAULT NULL,
  `Гос_Из_них_край_тяж_Взрос_Всего` int DEFAULT NULL,
  `Гос_Из_них_край_тяж_Взрос_втч_ранен` int DEFAULT NULL,
  `Гос_Из_них_край_тяж_Взрос_втч_берем` int DEFAULT NULL,
  `Гос_Из_них_край_тяж_Дети_Всего` int DEFAULT NULL,
  `Гос_Из_них_край_тяж_Дети_втч_ранен` int DEFAULT NULL,
  `Гос_Из_них_край_тяж_Дети_втч_до_1г` int DEFAULT NULL,
  `Гос_Из_них_тяж_Взрос_Всего` int DEFAULT NULL,
  `Гос_Из_них_тяж_Взрос_втч_раненых` int DEFAULT NULL,
  `Гос_Из_них_тяж_Взрос_втч_берем_жен` int DEFAULT NULL,
  `Гос_Из_них_тяж_Дети_Всего` int DEFAULT NULL,
  `Гос_Из_них_тяж_Дети_втч_раненых` int DEFAULT NULL,
  `Гос_Из_них_тяж_Дети_втч_до_1_года` int DEFAULT NULL,
  `Гос_Из_них_лёгк_Взрос_Всего` int DEFAULT NULL,
  `Гос_Из_них_лёгк_Взрос_втч_ранен` int DEFAULT NULL,
  `Гос_Из_них_лёгк_Взрос_втч_берем_жен` int DEFAULT NULL,
  `Гос_Из_них_лёгк_Дети_Всего` int DEFAULT NULL,
  `Гос_Из_них_лёгк_Дети_втч_раненых` int DEFAULT NULL,
  `Гос_Из_них_лёгк_Дети_втч_до_1_года` int DEFAULT NULL,
  `Дата` date NOT NULL,
  PRIMARY KEY (`Дата`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `svedeniya_o_gospitalizacii_pribyvshih`
--

LOCK TABLES `svedeniya_o_gospitalizacii_pribyvshih` WRITE;
/*!40000 ALTER TABLE `svedeniya_o_gospitalizacii_pribyvshih` DISABLE KEYS */;
INSERT INTO `svedeniya_o_gospitalizacii_pribyvshih` VALUES ('г.Волжский','Больница Им. Фишера',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,'2022-06-29'),('г.Волжский','Больница Им. Фишера',3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,'2022-06-28'),('г.Волжский','Больница Им. Фишера',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,'2022-06-20'),('г.Волжский','Больница Им. Фишера',2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,2,0,0,0,'2022-07-01');
/*!40000 ALTER TABLE `svedeniya_o_gospitalizacii_pribyvshih` ENABLE KEYS */;
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
