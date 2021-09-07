-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2020 at 11:40 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ims`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `id_client` int(11) NOT NULL,
  `clientname` text NOT NULL,
  `address` text NOT NULL,
  `phone` text NOT NULL,
  `postalcode` text NOT NULL,
  `city` text NOT NULL,
  `country` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`id_client`, `clientname`, `address`, `phone`, `postalcode`, `city`, `country`) VALUES
(2, 'Sekawan Motors', 'Jl.Bantul', '0881223468435', '2423', 'yogyakarta', 'indonesia'),
(6, 'Tama Motors', 'Jl.Godean', '085775523409', '55123', 'Yogyakarta', 'Indonesia'),
(7, 'Nasmoco Bantul', 'Jl.Ringroad Selatan', '081231231245', '55184', 'yogyakarta', 'indonesia'),
(8, 'petra motor', 'jl magelang', '081231232', '55184', 'yogyakarta', 'indonesia'),
(12, 'Auto2000', 'jakarta', '089997764212', '55557', 'Jakarta', 'Indonesia'),
(13, 'INDOAPRIL', 'jl kaliurang', '08123133123', '55184', 'yogyakarta', 'indonesia');

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE `company` (
  `id_company` int(11) NOT NULL,
  `companyname` text NOT NULL,
  `phone` text NOT NULL,
  `address` text NOT NULL,
  `logo` text NOT NULL,
  `city` text NOT NULL,
  `postalcode` text NOT NULL,
  `country` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `company`
--

INSERT INTO `company` (`id_company`, `companyname`, `phone`, `address`, `logo`, `city`, `postalcode`, `country`) VALUES
(1, 'GG Gaming', '081231231381', 'Bantul', 'E:\\Icon\\login_rounded_right_100px.png', 'Yogyakarta', '55184', 'Indonesia');

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

CREATE TABLE `invoices` (
  `id_invoice` int(11) NOT NULL,
  `billto` int(11) NOT NULL,
  `invoicedate` date NOT NULL,
  `total` int(11) NOT NULL,
  `terms` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `invoices`
--

INSERT INTO `invoices` (`id_invoice`, `billto`, `invoicedate`, `total`, `terms`) VALUES
(1, 2, '2019-12-12', 10000, 'pay cash'),
(101, 13, '2019-12-15', 950000, 'transfer bank'),
(104, 2, '2019-12-17', 150000, 'Terms & Conditions : None'),
(111, 6, '2019-12-29', 220000, 'cash');

-- --------------------------------------------------------

--
-- Table structure for table `invoice_items`
--

CREATE TABLE `invoice_items` (
  `id_item` int(11) NOT NULL,
  `invoiceID` int(11) NOT NULL,
  `description` text NOT NULL,
  `quantity` int(11) NOT NULL,
  `unitprice` int(11) NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `invoice_items`
--

INSERT INTO `invoice_items` (`id_item`, `invoiceID`, `description`, `quantity`, `unitprice`, `amount`) VALUES
(1, 1, 'test', 1, 100000, 100000),
(148, 101, 'indomie', 100, 1500, 150000),
(149, 101, 'teh tang', 100, 2500, 250000),
(150, 101, 'coffemix', 100, 500, 50000),
(151, 101, 'ice cream wals', 100, 5000, 500000),
(153, 104, 'lampu mobil', 1, 150000, 150000),
(156, 1, '', 1, 0, 0),
(157, 111, 'gg', 1, 120000, 120000),
(158, 111, 'karburator', 1, 100000, 100000);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `fullname` text NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `email` text NOT NULL,
  `phone` text NOT NULL,
  `admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `fullname`, `username`, `password`, `email`, `phone`, `admin`) VALUES
(1, 'Yedida Harya Olivtian', 'yedida', '123', 'yedida.26@students.amikom.ac.id', '081231231381', 1),
(2, 'Admin ', 'admoon', '123456', 'admin@admin.com', '088888888888', 1),
(31, 'gg', 'gg', '123456', 'gg', '1231323', 0),
(32, 'mas aji', 'aji', '123456', 'ajimasaji@gmai.com', '088888888880', 1),
(43, 'amikom', 'amikom123', '123456', '342342', '1231321232', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id_client`);

--
-- Indexes for table `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`id_company`);

--
-- Indexes for table `invoices`
--
ALTER TABLE `invoices`
  ADD PRIMARY KEY (`id_invoice`),
  ADD KEY `billto` (`billto`);

--
-- Indexes for table `invoice_items`
--
ALTER TABLE `invoice_items`
  ADD PRIMARY KEY (`id_item`),
  ADD KEY `invoiceID` (`invoiceID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `id_client` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `company`
--
ALTER TABLE `company`
  MODIFY `id_company` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `invoices`
--
ALTER TABLE `invoices`
  MODIFY `id_invoice` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=114;

--
-- AUTO_INCREMENT for table `invoice_items`
--
ALTER TABLE `invoice_items`
  MODIFY `id_item` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=161;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `invoices`
--
ALTER TABLE `invoices`
  ADD CONSTRAINT `fk_invoice_client` FOREIGN KEY (`billto`) REFERENCES `clients` (`id_client`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `invoice_items`
--
ALTER TABLE `invoice_items`
  ADD CONSTRAINT `fk_item_invoice` FOREIGN KEY (`invoiceID`) REFERENCES `invoices` (`id_invoice`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
