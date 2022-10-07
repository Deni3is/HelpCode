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
-- Table structure for table `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan`
--

DROP TABLE IF EXISTS `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` (
  `Ключ` int NOT NULL AUTO_INCREMENT,
  `Субъект_РФ` varchar(255) CHARACTER SET cp1251 COLLATE cp1251_general_ci DEFAULT NULL,
  `Число_обследованных` int DEFAULT NULL,
  `Вз_Туберкулёз` int DEFAULT NULL,
  `Вз_Вич` int DEFAULT NULL,
  `Вз_ИППП` int DEFAULT NULL,
  `Вз_Сахарный_диабет` int DEFAULT NULL,
  `Вз_Болезни_системы_кровообращения` int DEFAULT NULL,
  `Вз_Гепатит_B_C` int DEFAULT NULL,
  `Вз_Онкологические_заболевания` int DEFAULT NULL,
  `Вз_Психические_растройства` int DEFAULT NULL,
  `Вз_Прочие_заболевания` int DEFAULT NULL,
  `Дата` date DEFAULT NULL,
  PRIMARY KEY (`Ключ`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan`
--

LOCK TABLES `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` WRITE;
/*!40000 ALTER TABLE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` DISABLE KEYS */;
INSERT INTO `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` VALUES (11,'г.Волжский',19,6,5,6,7,7,8,6,8,3,'2022-06-20'),(12,'г.Волжский',0,0,0,0,0,0,0,0,0,0,'2022-06-28'),(13,'г.Волжский',0,0,0,0,0,0,0,0,0,0,'2022-06-29'),(14,'г.Волжский',0,0,0,0,0,0,0,0,0,0,'2022-07-01');
/*!40000 ALTER TABLE `informaciya_o_vyyavlennyh_zabolevaniyah_u_grazhdan` ENABLE KEYS */;
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
