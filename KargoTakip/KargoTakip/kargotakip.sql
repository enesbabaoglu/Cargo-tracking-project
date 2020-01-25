-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 27 Ara 2017, 11:37:56
-- Sunucu sürümü: 5.7.20-log
-- PHP Sürümü: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kargotakip`
--
CREATE DATABASE IF NOT EXISTS `kargotakip` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `kargotakip`;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteribil`
--

DROP TABLE IF EXISTS `musteribil`;
CREATE TABLE IF NOT EXISTS `musteribil` (
  `KargoNo` varchar(11) NOT NULL,
  `Ad` varchar(30) NOT NULL,
  `Soyad` varchar(30) NOT NULL,
  `TCKimlik` varchar(11) NOT NULL,
  `CepTel` varchar(11) NOT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `Adres` varchar(500) NOT NULL,
  `GonderilecekAdres` varchar(300) NOT NULL,
  `Fiyat` double NOT NULL,
  `Durum` varchar(20) NOT NULL,
  PRIMARY KEY (`KargoNo`),
  UNIQUE KEY `KargoNo` (`KargoNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `musteribil`
--

INSERT DELAYED IGNORE INTO `musteribil` (`KargoNo`, `Ad`, `Soyad`, `TCKimlik`, `CepTel`, `Email`, `Adres`, `GonderilecekAdres`, `Fiyat`, `Durum`) VALUES
('', 'Canberk', 'KAYA', '33333333333', '05443434434', 'canberkkaya@gmail.com', 'Üsküdar', 'Eminönü', 15, 'beklemede'),
('00303030303', 'Abdullah', 'BAĞCI', '22222222222', '05353535353', 'abdullahbagcı@gmail.com', 'Sivas', 'Sİvas', 106, 'Dağıtım Aşamasında'),
('12121212212', 'Enes', 'BABAOĞLU', '11111111111', '05555555555', 'enessbabaoglu@gmail.com', 'Erzene mah. 18.sok no:5 d:6 bornova izmir', 'Osmangazi mah. hilal cad mavi sok no:5 d:18 samandıra İstanbul', 25, 'beklemede'),
('34676976907', 'Canberk', 'KAYA', '33333333333', '05443434434', 'canberkkaya@gmail.com', 'Üsküdar', 'Eminönü', 8, 'beklemede'),
('78076875643', 'Abdullah', 'BAĞCI', '22222222222', '05353535353', 'abdullahbagcı@gmail.com', 'Sivas', 'Sİvas', 52, 'beklemede');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
