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
-- Table structure for table `svedeniya_o_vakcinacii_pribyvshih`
--

DROP TABLE IF EXISTS `svedeniya_o_vakcinacii_pribyvshih`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `svedeniya_o_vakcinacii_pribyvshih` (
  `Ключ` int NOT NULL AUTO_INCREMENT,
  `Наименование_субъекта_РФ` varchar(255) CHARACTER SET cp1251 COLLATE cp1251_general_ci DEFAULT NULL,
  `Наименование_муп_субъекта_РФ` varchar(255) CHARACTER SET cp1251 COLLATE cp1251_general_ci DEFAULT NULL,
  `Иммун_Всего` int DEFAULT NULL,
  `Иммун_Детей_Всего` int DEFAULT NULL,
  `Иммун_Детей_до_1_года` int DEFAULT NULL,
  `Иммун_Беременных_женщин` int DEFAULT NULL,
  `Вак_но_от_Covid_Всего` int DEFAULT NULL,
  `Вак_но_от_Covid_Детей_Всего` int DEFAULT NULL,
  `Вак_но_от_Covid_Детей_до_1_года` int DEFAULT NULL,
  `Вак_но_от_Covid_Беременных_женщин` int DEFAULT NULL,
  `Дата` date DEFAULT NULL,
  PRIMARY KEY (`Ключ`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `svedeniya_o_vakcinacii_pribyvshih`
--

LOCK TABLES `svedeniya_o_vakcinacii_pribyvshih` WRITE;
/*!40000 ALTER TABLE `svedeniya_o_vakcinacii_pribyvshih` DISABLE KEYS */;
INSERT INTO `svedeniya_o_vakcinacii_pribyvshih` VALUES (5,'г.Волжский','Больница Им. Фишера',0,0,0,0,0,0,0,0,'2022-06-28'),(4,'г.Волжский','Больница Им. Фишера',5,0,0,1,2,0,0,1,'2022-06-20'),(6,'г.Волжский','Больница Им. Фишера',0,0,0,0,0,0,0,0,'2022-06-29'),(7,'г.Волжский','Больница Им. Фишера',0,0,0,0,0,0,0,0,'2022-07-01');
/*!40000 ALTER TABLE `svedeniya_o_vakcinacii_pribyvshih` ENABLE KEYS */;
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
