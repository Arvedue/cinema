-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 28, 2023 at 05:35 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cinema`
--

-- --------------------------------------------------------

--
-- Table structure for table `filmroom`
--

CREATE TABLE `filmroom` (
  `filmRoomId` int(11) NOT NULL,
  `type` varchar(15) NOT NULL,
  `numberOfSeats` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `filmroom`
--

INSERT INTO `filmroom` (`filmRoomId`, `type`, `numberOfSeats`) VALUES
(1, 'standart', 20),
(2, 'standart', 20),
(3, 'vip', 10);

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `movieId` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `year` int(4) DEFAULT NULL,
  `producer` varchar(20) DEFAULT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `country` varchar(20) DEFAULT NULL,
  `description` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`movieId`, `name`, `year`, `producer`, `genre`, `country`, `description`) VALUES
(1, 'Стражи Галактики. Часть 3', 2023, 'Джеймс Ганн', 'фантастика, боевик, комедия, приключения', 'США', 'Питер Квилл никак не может смириться с потерей Гаморы и теперь вместе со Стражами Галактики вынужден отправиться на очередную миссию по защите Вселенной.'),
(2, 'Черный лотос.', 2023, 'Тодор Чапканов', 'боевик, триллер', 'США, Нидерланды', 'Офицер спецназа Маттео Доннер пытается справиться с чувством вины после гибели лучшего друга в ходе совместного задания. После скитаний по миру он возвращается в Амстердам, где его вовлекают в противостояние городских банд. Доннер должен спасти похищенную дочь своего погибшего товарища.'),
(3, 'Особняк ', 2023, 'Радик Эшимов', 'комедия', 'Кыргызстан', 'Родители невесты перед встречей своих сватов, берут в аренду особняк на несколько часов, чтобы казаться богаче чем они есть на самом деле, но встреча выходит из-под контроля потому, что кудалар решили посидеть подольше.'),
(4, 'Спирит ', 2023, 'Диде инт Вельд', 'приключения', 'Нидерланды', 'Эсми гостит у бабушки и все, о чем она грезит — это занятия конным спортом. Однако, бабушка боится этого увлечения и не разрешает. Однажды утром девочка обнаруживает у себя во дворе лошадь, которая спаслась из пожара в конюшне на соседнем ранчо. Так начинается настоящая дружба и приключения.'),
(5, 'Мой монстр', 2023, 'Хуан Хэ', 'фантастика, боевик', 'Китай', 'Команде строителей в подземных тоннелях предстоит столкнуться с необъяснимым кошмаром. Отрезанные от остального мира рабочие вступают в схватку с инопланетной тварью колоссальных размеров.'),
(6, 'Кунг-Фу жеребец', 2023, 'Ларри Ян', 'комедия', 'Китай', 'Знаменитый мастер боевых искусств и его верный скакун врываются в мир, где любая уличная драка заслуживает тиктока. Круто разделавшись с бандой коллекторов, они тотчас становятся супергероями в сети. Но вместе с любовью фанатов их находят и могущественные враги.'),
(7, 'Судзумэ, закрывающая двери', 2023, 'Макото Синкай', 'аниме, мультфильм, фэнтези', 'Япония', '17-летняя Судзумэ живёт в тихом городке на острове Кюсю. Однажды она встречает молодого путешественника, который ищет некую дверь. Вместе они находят старую дверь в горах посреди руин, и заворожённая Судзумэ открывает её');

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE `purchase` (
  `purchaseId` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `sessionId` int(11) NOT NULL,
  `seat` int(2) NOT NULL,
  `date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`purchaseId`, `userId`, `sessionId`, `seat`, `date`) VALUES
(1, 2, 1, 1, '2023-05-13 10:51:19'),
(2, 3, 6, 1, '2023-05-13 11:25:06'),
(3, 3, 4, 10, '2023-05-13 11:25:51'),
(4, 1, 1, 10, '2023-05-13 12:32:36');

-- --------------------------------------------------------

--
-- Table structure for table `session`
--

CREATE TABLE `session` (
  `sessionId` int(11) NOT NULL,
  `movieId` int(11) NOT NULL,
  `filmRoomId` int(11) DEFAULT NULL,
  `time` varchar(8) DEFAULT NULL,
  `price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `session`
--

INSERT INTO `session` (`sessionId`, `movieId`, `filmRoomId`, `time`, `price`) VALUES
(1, 1, 1, '10:00:00', 250),
(2, 2, 1, '12:00:00', 250),
(3, 3, 2, '08:00:00', 250),
(4, 4, 2, '14:00:00', 250),
(5, 5, 3, '15:00:00', 500),
(6, 1, 3, '17:00:00', 500);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userId` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(64) DEFAULT NULL,
  `role` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userId`, `name`, `username`, `password`, `role`) VALUES
(1, 'Anais Rose', 'admin', 'admin', 'admin'),
(2, 'John Smith', 'john', 'user', 'customer'),
(3, 'Robin Good', 'robin', 'user', 'customer');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `filmroom`
--
ALTER TABLE `filmroom`
  ADD PRIMARY KEY (`filmRoomId`);

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`movieId`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`purchaseId`),
  ADD KEY `fk_user` (`userId`),
  ADD KEY `fk_session` (`sessionId`);

--
-- Indexes for table `session`
--
ALTER TABLE `session`
  ADD PRIMARY KEY (`sessionId`),
  ADD KEY `fk_movie` (`movieId`),
  ADD KEY `fk_filmRood` (`filmRoomId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
