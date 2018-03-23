-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 21, 2018 at 07:57 AM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lswsn`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `id` int(11) NOT NULL,
  `accessionNo` int(11) NOT NULL,
  `isbn` int(11) NOT NULL,
  `category` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `edition` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL DEFAULT 'Available',
  `dateEntry` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`id`, `accessionNo`, `isbn`, `category`, `title`, `author`, `edition`, `status`, `dateEntry`, `isActive`) VALUES
(1, 213, 11102012, 'Language', 'Title 1', 'Author 1', '2018', 'Available', '2018-03-10 23:26:55', 1),
(2, 24124, 23942135, 'Computer Science, Information & General Works', 'Chemistry', 'Ruth Syra', '2016', 'Unavailable', '2018-03-11 18:02:24', 1),
(3, 15312, 2314123, 'Religion', 'Religion Title', 'Religion Author', '2017', 'Available', '2018-03-12 14:33:15', 1);

-- --------------------------------------------------------

--
-- Table structure for table `bookcategory`
--

CREATE TABLE `bookcategory` (
  `id` int(11) NOT NULL,
  `classes` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `dateEntry` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bookcategory`
--

INSERT INTO `bookcategory` (`id`, `classes`, `description`, `dateEntry`, `isActive`) VALUES
(1, '000 - 099', 'Computer Science, Information & General Works', '2018-03-10 22:32:31', 1),
(2, '100 - 199', 'Philosophy and Psychology', '2018-03-10 22:32:31', 1),
(3, '200 - 299', 'Religion', '2018-03-10 22:33:00', 1),
(4, '300 - 399', 'Social sciences', '2018-03-10 22:33:00', 1),
(5, '400 - 499', 'Language', '2018-03-10 22:33:15', 1),
(6, '500 - 599', 'Science', '2018-03-10 22:33:15', 1),
(7, '600 - 699', 'Technology', '2018-03-10 22:33:29', 1),
(8, '700 - 799', 'Arts and Recreation', '2018-03-10 22:33:29', 1),
(9, '800 - 899', 'Literature', '2018-03-10 22:33:44', 1),
(10, '900 - 999', 'History and Geography', '2018-03-10 22:33:44', 1);

-- --------------------------------------------------------

--
-- Table structure for table `borrowbook`
--

CREATE TABLE `borrowbook` (
  `id` int(11) NOT NULL,
  `studentId` varchar(255) NOT NULL,
  `bookId` int(11) NOT NULL,
  `borrowDate` date NOT NULL,
  `returnDate` date NOT NULL,
  `accountName` varchar(255) NOT NULL,
  `transaction` varchar(255) NOT NULL DEFAULT 'Borrow',
  `penalty` decimal(15,2) NOT NULL DEFAULT '0.00',
  `dateEntry` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrowbook`
--

INSERT INTO `borrowbook` (`id`, `studentId`, `bookId`, `borrowDate`, `returnDate`, `accountName`, `transaction`, `penalty`, `dateEntry`, `isActive`) VALUES
(1, '23423523623', 213, '2018-03-12', '2018-03-12', 'admin', 'Borrow', '0.00', '2018-03-12 14:41:37', 0),
(2, '23423523623', 24124, '2018-03-12', '2018-03-15', 'admin', 'Borrow', '0.00', '2018-03-12 14:41:40', 0),
(3, '23423523623', 15312, '2018-03-12', '2018-03-15', 'admin', 'Borrow', '0.00', '2018-03-12 14:41:43', 0),
(7, '23423523623', 213, '2018-03-21', '2018-03-21', 'admin', 'Return', '45.00', '2018-03-21 14:03:39', 0),
(8, '23423523623', 24124, '2018-03-21', '2018-03-21', 'admin', 'Return', '30.00', '2018-03-21 14:03:39', 0),
(9, '23423523623', 15312, '2018-03-21', '2018-03-21', 'admin', 'Return', '30.00', '2018-03-21 14:03:39', 0);

-- --------------------------------------------------------

--
-- Table structure for table `developer`
--

CREATE TABLE `developer` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `isActive` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `developer`
--

INSERT INTO `developer` (`id`, `name`, `isActive`) VALUES
(1, 'Marycris Esparagoza', 1),
(2, 'Jerson Segotier', 1),
(3, 'Joevie Vegafria', 1),
(4, 'Cherrylen Sialsa', 1),
(5, 'Jestoni Nava', 1),
(6, 'Cris John Adrias', 1);

-- --------------------------------------------------------

--
-- Table structure for table `penalty`
--

CREATE TABLE `penalty` (
  `id` int(11) NOT NULL,
  `price` decimal(15,2) NOT NULL,
  `isActive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penalty`
--

INSERT INTO `penalty` (`id`, `price`, `isActive`) VALUES
(1, '5.00', 1);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `studentId` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `levelSection` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `contactNo` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `dateEntry` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `studentId`, `name`, `levelSection`, `gender`, `contactNo`, `address`, `dateEntry`, `isActive`) VALUES
(1, '0012018001', 'Juan Dela Cruz', '2nd year - Molave', 'Male', '09153983345', 'Makati City', '2018-03-10 17:02:01', 1),
(2, '0012018003', 'Mathew Santos', '2nd Year - Apolinario', 'Male', '09164329338', 'Manila', '2018-03-10 18:17:03', 1),
(3, '23423523623', 'RuDee', '1st year - Santos', 'Female', '09236437467', 'PUSO MO', '2018-03-11 16:29:56', 1),
(4, '012018015', 'Mary Fajardo', '3rd year - Rose', 'Female', '09154392289', 'Manila', '2018-03-11 17:57:00', 1);

-- --------------------------------------------------------

--
-- Table structure for table `systems`
--

CREATE TABLE `systems` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `subtitle` varchar(255) NOT NULL,
  `code` varchar(255) NOT NULL,
  `version` varchar(255) NOT NULL,
  `year` varchar(255) NOT NULL,
  `isActive` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `systems`
--

INSERT INTO `systems` (`id`, `title`, `subtitle`, `code`, `version`, `year`, `isActive`) VALUES
(1, 'Library System w/ SMS Notification', 'Belison National School', 'LSWSN', 'v1.0', '2018', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transactiontypes`
--

CREATE TABLE `transactiontypes` (
  `id` int(11) NOT NULL,
  `code` varchar(10) NOT NULL,
  `description` varchar(255) NOT NULL,
  `isActive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transactiontypes`
--

INSERT INTO `transactiontypes` (`id`, `code`, `description`, `isActive`) VALUES
(1, 'ACCO', 'Account', 1),
(2, 'BOR', 'Borrow', 1),
(3, 'RET', 'Return', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `userName` varchar(255) NOT NULL,
  `userPass` varchar(255) NOT NULL,
  `userTypeId` int(11) NOT NULL,
  `clientId` int(11) NOT NULL,
  `dateEntry` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `userName`, `userPass`, `userTypeId`, `clientId`, `dateEntry`, `isActive`) VALUES
(1, 'admin', 'admin', 1, 0, '2018-03-10 14:06:28', 1),
(2, 'librarian', 'librarian', 2, 0, '2018-03-10 14:06:28', 1);

-- --------------------------------------------------------

--
-- Table structure for table `usertype`
--

CREATE TABLE `usertype` (
  `id` int(11) NOT NULL,
  `description` varchar(255) NOT NULL,
  `dateEntry` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isActive` tinyint(4) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usertype`
--

INSERT INTO `usertype` (`id`, `description`, `dateEntry`, `isActive`) VALUES
(1, 'Admin', '2018-02-25 15:08:44', 1),
(2, 'Librarian', '2018-02-25 15:08:44', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bookcategory`
--
ALTER TABLE `bookcategory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `borrowbook`
--
ALTER TABLE `borrowbook`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `developer`
--
ALTER TABLE `developer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penalty`
--
ALTER TABLE `penalty`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `systems`
--
ALTER TABLE `systems`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transactiontypes`
--
ALTER TABLE `transactiontypes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usertype`
--
ALTER TABLE `usertype`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `bookcategory`
--
ALTER TABLE `bookcategory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `borrowbook`
--
ALTER TABLE `borrowbook`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `developer`
--
ALTER TABLE `developer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `penalty`
--
ALTER TABLE `penalty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `systems`
--
ALTER TABLE `systems`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `transactiontypes`
--
ALTER TABLE `transactiontypes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `usertype`
--
ALTER TABLE `usertype`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
