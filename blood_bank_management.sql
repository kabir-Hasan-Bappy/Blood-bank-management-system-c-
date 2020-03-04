-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 04, 2018 at 07:41 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `blood_bank_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `contact` int(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `name`, `adress`, `contact`, `username`, `password`) VALUES
('01', 'Adnan bappy', 'uttara', 1687713808, 'bappy', '12345'),
('02', 'Kabir Hasan bapppa', 'Sirajgonj', 123, 'kabir', '1245'),
('03', 'TONY', 'mirpur', 123445, 'tony', '3'),
('04', 'Fatema Zaman', 'Tangail', 77777, 'fatema', 'fatema'),
('05', 'Adnan Bappy', 'Sirajgonj', 1687713808, 'adnan', '123');

-- --------------------------------------------------------

--
-- Table structure for table `bloodbag_info`
--

CREATE TABLE `bloodbag_info` (
  `blood_id` varchar(50) NOT NULL,
  `b_type` varchar(50) NOT NULL,
  `quantity` int(50) NOT NULL,
  `entry_date` varchar(50) NOT NULL,
  `expire_date` varchar(50) NOT NULL,
  `seller_id` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bloodbag_info`
--

INSERT INTO `bloodbag_info` (`blood_id`, `b_type`, `quantity`, `entry_date`, `expire_date`, `seller_id`) VALUES
('B11', 'B-', 2, 'Wednesday, April 4, 2018', '20-Apr-18 12:13:30 AM', '12'),
('B14', 'B-', 1, 'Thursday, March 29, 2018', '2018-04-05', '18'),
('B9', 'A-', 1, 'Thursday, March 29, 2018', '2018-04-26', '16');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `contact` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_id`, `name`, `adress`, `contact`) VALUES
('C1', 'Badhan', 'Mymansingh', 12345),
('C2', 'Kabir_Hasan', 'Dhaka', 987);

-- --------------------------------------------------------

--
-- Table structure for table `donor`
--

CREATE TABLE `donor` (
  `donor_id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `contact` int(50) NOT NULL,
  `entry_date` varchar(50) NOT NULL,
  `last_donate_date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `donor`
--

INSERT INTO `donor` (`donor_id`, `name`, `adress`, `contact`, `entry_date`, `last_donate_date`) VALUES
('D1', 'Sultan', 'Jasimuddin', 1456, 'Wednesday, March 21, 2018', 'Monday, February 26, 2018'),
('D2', 'Sharif', 'Jasimuddin', 1444, 'Wednesday, March 21, 2018', 'Wednesday, March 21, 2018'),
('D3', 'Jasmine', 'mirpur', 1234, 'Wednesday, March 21, 2018', 'Thursday, April 21, 2011'),
('D6', 'Keya', 'Uttara', 123, 'Thursday, March 29, 2018', 'Sunday, January 7, 2018');

-- --------------------------------------------------------

--
-- Table structure for table `dstorage`
--

CREATE TABLE `dstorage` (
  `Dblood_id` varchar(50) NOT NULL,
  `donor_id` varchar(50) NOT NULL,
  `b_type` varchar(50) NOT NULL,
  `qty` int(50) NOT NULL,
  `entry_date` varchar(50) NOT NULL,
  `expire_date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dstorage`
--

INSERT INTO `dstorage` (`Dblood_id`, `donor_id`, `b_type`, `qty`, `entry_date`, `expire_date`) VALUES
('DD3', 'D6', 'AB-', 1, 'Thursday, March 29, 2018', 'Saturday, March 31, 2018'),
('DD4', 'D2', 'B+', 1, 'Thursday, March 29, 2018', 'Wednesday, April 18, 2018'),
('DD5', 'D3', 'O+', 1, 'Thursday, March 29, 2018', 'Saturday, April 28, 2018'),
('DD6', 'D6', 'O-', 1, 'Thursday, March 29, 2018', 'Thursday, April 26, 2018'),
('DD7', 'D3', 'A+', 1, 'Tuesday, April 3, 2018', 'Tuesday, April 3, 2018');

-- --------------------------------------------------------

--
-- Table structure for table `free_give`
--

CREATE TABLE `free_give` (
  `fg_id` varchar(50) NOT NULL,
  `entry_date` varchar(50) NOT NULL,
  `Dblood_id` varchar(50) NOT NULL,
  `b_type` varchar(50) NOT NULL,
  `qty` int(50) NOT NULL,
  `expire_date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `free_give`
--

INSERT INTO `free_give` (`fg_id`, `entry_date`, `Dblood_id`, `b_type`, `qty`, `expire_date`) VALUES
('3', '31-Mar-18', 'DD1', 'A+', 1, 'Thursday, April 19, 2018');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `invoice_no` varchar(50) NOT NULL,
  `customer_id` varchar(50) NOT NULL,
  `b_type` varchar(50) NOT NULL,
  `quantity` int(50) NOT NULL,
  `total_amount` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`invoice_no`, `customer_id`, `b_type`, `quantity`, `total_amount`) VALUES
('11', '114', 'O+', 2, 400),
('111', 'C1', 'B+', 3, 900),
('12', '111', 'A+', 2, 500),
('23', '111', 'AB-', 1, 500),
('233', '111', 'AB+', 1, 300),
('235', '104', 'O+', 2, 400),
('I1', '104', 'AB+', 5, 1505),
('S01', '104', 'A+', 1, 250);

-- --------------------------------------------------------

--
-- Table structure for table `price`
--

CREATE TABLE `price` (
  `b_type` varchar(50) NOT NULL,
  `price` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `price`
--

INSERT INTO `price` (`b_type`, `price`) VALUES
('A+', 250),
('A-', 600),
('AB+', 300),
('AB-', 500),
('B+', 300),
('B-', 450),
('O+', 200),
('O-', 550);

-- --------------------------------------------------------

--
-- Table structure for table `seller`
--

CREATE TABLE `seller` (
  `seller_id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `contact` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `seller`
--

INSERT INTO `seller` (`seller_id`, `name`, `adress`, `contact`) VALUES
('01', 'BAPPY', 'FFFF', 2147483647),
('02', 'Fatema', 'Madhupur', 12333),
('12', 'Tony', 'Uttara', 1677789),
('14', 'Kabir', 'Narayanganj', 1234),
('16', 'Sohani', 'Noakhali', 1678867),
('17', 'Hasan', 'Mirpur', 167886745),
('18', 'Gaffar', 'Mirpur10', 167886775),
('19', 'Singh', '?india', 12333),
('20', 'Mithu', 'uu', 11),
('21', 'Dev', 'sds', 333);

-- --------------------------------------------------------

--
-- Table structure for table `sell_information`
--

CREATE TABLE `sell_information` (
  `selling_id` varchar(50) NOT NULL,
  `blood_id` varchar(50) NOT NULL,
  `customer_id` varchar(50) NOT NULL,
  `quantity` int(50) NOT NULL,
  `price` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `bloodbag_info`
--
ALTER TABLE `bloodbag_info`
  ADD PRIMARY KEY (`blood_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `donor`
--
ALTER TABLE `donor`
  ADD PRIMARY KEY (`donor_id`);

--
-- Indexes for table `dstorage`
--
ALTER TABLE `dstorage`
  ADD PRIMARY KEY (`Dblood_id`);

--
-- Indexes for table `free_give`
--
ALTER TABLE `free_give`
  ADD PRIMARY KEY (`fg_id`(15));

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`invoice_no`);

--
-- Indexes for table `price`
--
ALTER TABLE `price`
  ADD PRIMARY KEY (`b_type`);

--
-- Indexes for table `seller`
--
ALTER TABLE `seller`
  ADD PRIMARY KEY (`seller_id`);

--
-- Indexes for table `sell_information`
--
ALTER TABLE `sell_information`
  ADD PRIMARY KEY (`selling_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
