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
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `Ключ` int NOT NULL AUTO_INCREMENT,
  `Номер_карточки` int DEFAULT NULL,
  `Фамилия` varchar(255) DEFAULT NULL,
  `Имя` varchar(255) DEFAULT NULL,
  `Отчество` varchar(255) DEFAULT NULL,
  `Дата_рождения` date DEFAULT NULL,
  `Пол` int DEFAULT NULL,
  `Дата_поступления_в_ПВР` date DEFAULT NULL,
  `Номер_комнаты` int DEFAULT NULL,
  `Гражданство` varchar(255) DEFAULT NULL,
  `Беженец` int DEFAULT NULL,
  `Беременность` int DEFAULT NULL,
  `Прошли_роды_в_ПВР` int DEFAULT NULL,
  `Дата_родов` date DEFAULT NULL,
  `Родилось_детей_в_ПВР` int DEFAULT NULL,
  `Переболел_covid` int DEFAULT NULL,
  `Дата_постановки_диагноза_covid` date DEFAULT NULL,
  `Вакцинирован_от_covid` int DEFAULT NULL,
  `Дата_вакцинации_от_covid` date DEFAULT NULL,
  `Карантин` int DEFAULT NULL,
  `Дата_начала_карантина` date DEFAULT NULL,
  `ИППП_обследование` int DEFAULT '0',
  `ИППП_болен` int DEFAULT NULL,
  `ИППП_дата` date DEFAULT NULL,
  `ИППП_комментарий` varchar(150) DEFAULT NULL,
  `Туберкулез_обследование` int DEFAULT '0',
  `Туберкулез_болен` int DEFAULT NULL,
  `Туберкулез_дата` date DEFAULT NULL,
  `Туберкулез_комментарий` varchar(150) DEFAULT NULL,
  `Гепатит_B_обследование` int DEFAULT '0',
  `Гепатит_B_болен` int DEFAULT NULL,
  `Гепатит_B_дата` date DEFAULT NULL,
  `Гепатит_В_комментарий` varchar(150) DEFAULT NULL,
  `Гепатит_C_обследование` int DEFAULT '0',
  `Гепатит_C_болен` int DEFAULT NULL,
  `Гепатит_C_дата` date DEFAULT NULL,
  `Гепатит_С_комментарий` varchar(150) DEFAULT NULL,
  `ВИЧ_инфекция_обследование` int DEFAULT '0',
  `ВИЧ_инфекция_болен` int DEFAULT NULL,
  `ВИЧ_инфекция_дата` date DEFAULT NULL,
  `ВИЧ_комментарий` varchar(150) DEFAULT NULL,
  `АРВТ` int DEFAULT '0',
  `Сахарный_диабет_обследование` int DEFAULT '0',
  `Сахарный_диабет_болен` int DEFAULT NULL,
  `Сахарный_диабет_дата` date DEFAULT NULL,
  `Сахар_комментарий` varchar(150) DEFAULT NULL,
  `Психические_расстройства_обследование` int DEFAULT '0',
  `Психические_расстройства_болен` int DEFAULT NULL,
  `Психические_расстройства_дата` date DEFAULT NULL,
  `Псих_комментарий` varchar(150) DEFAULT NULL,
  `Онкологические_заболевания_обследование` int DEFAULT '0',
  `Онкологические_заболевания_болен` int DEFAULT NULL,
  `Онкологические_заболевания_дата` date DEFAULT NULL,
  `Онкология_коммент` varchar(150) DEFAULT NULL,
  `Болезни_системы_кровообращения_обследование` int DEFAULT '0',
  `Болезни_системы_кровообращения_болен` int DEFAULT NULL,
  `Болезни_системы_кровообращения_дата` date DEFAULT NULL,
  `Болезни_крови_коммент` varchar(150) DEFAULT NULL,
  `Прочие_заболевания_обследование` int DEFAULT '0',
  `Прочие_заболевания_болен` int DEFAULT NULL,
  `Прочие_заболевания_дата` date DEFAULT NULL,
  `Какие_прочие_заболевания` varchar(150) DEFAULT NULL,
  `Ограниченные_возможности_болен` int DEFAULT '0',
  `Ограниченные_возможности_дата` date DEFAULT NULL,
  `Ограниченные_возможности_коммент` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`Ключ`),
  UNIQUE KEY `Ключ_UNIQUE` (`Ключ`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (22,1234,'Малышева','Елена','Алексанндровна','1905-05-19',1,'2022-06-20',38699,'Украинское ',1,0,0,'0001-01-01',0,1,'2022-04-04',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01','',1,0,'2012-12-12','Все аккул',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,'0001-01-01',''),(23,2,'Шекян','Арина','Артуровна','2001-09-29',0,'2022-06-20',17,'Российское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,1,'2012-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'2011-01-01',NULL,1,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',1,'2002-01-01','ЗПР'),(24,1,'Багмут','Андрей','Олегович','2001-05-09',1,'2022-06-20',2,'Российское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',1,0,'0001-01-01','',0,0,'0001-01-01','',0,0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,'0001-01-01',''),(25,17,'Левшин','Денис','Витальевич','2001-05-09',1,'2022-06-20',3,'Пакистан',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,1,'1987-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,1,'1835-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'1991-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(26,85,'Фролова ','Анастасия','Евгеньевна','2002-02-19',0,'2022-06-20',6,'Российское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(27,33355,'Ландышева','Оля','Романовна','1789-01-31',0,'2022-06-20',354,'Российское Украинское ',0,0,1,'2022-09-24',5,1,'2153-12-31',0,'0001-01-01',0,'0001-01-01',0,1,'3554-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'4658-01-01',NULL,0,0,'0001-01-01',NULL,0,0,1,'4355-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'5410-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(28,87,'Гаврилин','Игорь','Валидович','2000-03-02',1,'2022-06-20',999,'Российское Украинское ',1,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,1,'7532-01-01',NULL,0,1,'7532-01-01',NULL,0,1,'7532-01-01',NULL,0,1,'3210-01-01',NULL,0,1,'4567-01-01',NULL,1,0,1,'8752-01-01',NULL,0,1,'4596-01-01',NULL,0,1,'4568-01-01',NULL,0,1,'4537-01-01',NULL,0,0,'0001-01-01','',1,'4535-01-01','без ног'),(29,963,'Зонева','Люба','Магамедова','2005-04-06',0,'2022-06-20',1654,'Украинское ',0,1,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'2222-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'2002-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(30,231123,'Первый','Человек','Вкосмосе','1961-04-12',1,'2022-06-20',7,'СССР',0,0,0,'0001-01-01',0,1,'2022-06-20',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(31,14,'Яров','Алевсандр','Евгеньевич','1662-12-13',1,'2022-06-20',54453,'Российское Украинское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'7417-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,1,'7417-01-01',NULL,0,1,'2586-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(32,5,'Парода','Бордер','Колли','2021-01-11',1,'2022-06-20',789,'Собакная',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'2021-01-01','Избыточное слюноотделение',0,'0001-01-01',''),(33,6,'Варнава','Ксения','Витальевна','2020-12-17',0,'2022-06-20',777,'Российское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,1,'0753-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'0114-01-01',NULL,0,1,'0452-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(34,9,'Заленов','Виктор','Витальевич','2003-03-03',1,'2022-06-20',32,'Российское Украинское ',1,0,0,'0001-01-01',0,0,'0001-01-01',1,'2022-02-21',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'6685-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,1,'1235-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',1,'2015-01-01','Носатый'),(35,14,'Леонов','Алексей','Архипович','1934-05-30',1,'2022-06-20',11,'СССР',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,1,'1988-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(36,100,'Терешкова','Валентина','Владимировна','1937-05-06',0,'2022-06-20',9,'Российское ',1,0,1,'2021-06-17',3,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'2021-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(37,80,'Пугачева','Алла','Борисовна','1949-04-15',0,'2022-06-20',359,'Российское ',0,1,0,'0001-01-01',0,0,'0001-01-01',1,'2022-06-15',0,'0001-01-01',0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'2021-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(38,13,'Высокова','Клавдия','Вадимова','1996-06-23',0,'2022-06-20',96,'Украинское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01',NULL,0,1,'1952-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,1,'1220-01-01',NULL,1,0,0,'0001-01-01',NULL,0,1,'2021-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01',NULL,0,0,'0001-01-01','',0,'0001-01-01',''),(39,3785,'Для','Проверки','Болезней','2001-01-01',1,'2022-06-20',1248,'Российское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,1,'1800-01-01',NULL,0,1,'1850-01-01',NULL,0,1,'1900-01-01',NULL,0,1,'2100-01-01',NULL,0,1,'2200-01-01',NULL,0,0,1,'2150-01-01',NULL,0,1,'2000-01-01',NULL,0,1,'2050-01-01',NULL,0,1,'2250-01-01',NULL,0,1,'1750-01-01','а',1,'1950-01-01','л'),(40,231124,'Проверка','Номер','Два','2003-02-01',0,'2022-06-20',6548,'Российское ',0,0,0,'0001-01-01',0,0,'0001-01-01',0,'0001-01-01',0,'0001-01-01',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',0,0,'0001-01-01','',1,'2003-01-01','лд');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
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
