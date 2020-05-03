-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 29 Jul 2019 pada 14.20
-- Versi Server: 10.1.25-MariaDB
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_uas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `dashboard`
--

CREATE TABLE `dashboard` (
  `satu` varchar(20) NOT NULL,
  `dua` varchar(20) NOT NULL,
  `tiga` varchar(20) NOT NULL,
  `empat` varchar(20) NOT NULL,
  `lima` varchar(20) NOT NULL,
  `enam` varchar(20) NOT NULL,
  `tujuh` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dashboard`
--

INSERT INTO `dashboard` (`satu`, `dua`, `tiga`, `empat`, `lima`, `enam`, `tujuh`) VALUES
('Barang', 'Penjualan', 'Laporan', 'Pembelian', 'Jenis Barang', 'Suplier', 'User');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_brg`
--

CREATE TABLE `tbl_brg` (
  `kd_brg` int(11) NOT NULL,
  `nm_jb` varchar(20) NOT NULL,
  `nm_brg` varchar(30) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_brg`
--

INSERT INTO `tbl_brg` (`kd_brg`, `nm_jb`, `nm_brg`, `harga_jual`, `stok`) VALUES
(1, 'susu kaleng', 'bendera', 12000, 11998),
(2, 'rokok', 'umild', 0, 10),
(3, 'pampers', 'charm', 40000, 50),
(4, 'air minum', 'le mineral', 35000, 8);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detail_brg`
--

CREATE TABLE `tbl_detail_brg` (
  `id_detail_brg` int(11) NOT NULL,
  `kd_brg` int(11) NOT NULL,
  `perubahan_harga_jual` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_detail_brg`
--

INSERT INTO `tbl_detail_brg` (`id_detail_brg`, `kd_brg`, `perubahan_harga_jual`) VALUES
(1, 1, 12000),
(2, 3, 40000),
(3, 4, 35000);

--
-- Trigger `tbl_detail_brg`
--
DELIMITER $$
CREATE TRIGGER `triger_perubahan_harga` AFTER INSERT ON `tbl_detail_brg` FOR EACH ROW BEGIN
UPDATE tbl_brg SET harga_jual = new.perubahan_harga_jual
WHERE kd_brg = new.kd_brg;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detail_pembelian`
--

CREATE TABLE `tbl_detail_pembelian` (
  `id_pembelian` int(11) NOT NULL,
  `no_faktur` varchar(15) NOT NULL,
  `kd_brg` int(11) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `jml_beli` int(11) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_detail_pembelian`
--

INSERT INTO `tbl_detail_pembelian` (`id_pembelian`, `no_faktur`, `kd_brg`, `harga_beli`, `jml_beli`, `total`) VALUES
(1, ' B29071900', 1, 10000, 12000, 120000000),
(2, ' B29071900', 4, 2000, 10, 20000),
(3, ' B29071900', 3, 35000, 50, 1750000),
(4, ' B29071900', 2, 18000, 10, 180000);

--
-- Trigger `tbl_detail_pembelian`
--
DELIMITER $$
CREATE TRIGGER `triger_pembelian` AFTER INSERT ON `tbl_detail_pembelian` FOR EACH ROW BEGIN
UPDATE tbl_brg SET stok=stok + new.jml_beli
WHERE kd_brg = new.kd_brg;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detail_penjualan`
--

CREATE TABLE `tbl_detail_penjualan` (
  `id_penjualan` int(11) NOT NULL,
  `faktur_penjualan` varchar(10) NOT NULL,
  `kd_brg` int(11) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `jml_jual` int(11) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_detail_penjualan`
--

INSERT INTO `tbl_detail_penjualan` (`id_penjualan`, `faktur_penjualan`, `kd_brg`, `harga_jual`, `jml_jual`, `total`) VALUES
(1, 'J290719001', 1, 12000, 2, 24000),
(2, 'J290719001', 4, 35000, 2, 70000);

--
-- Trigger `tbl_detail_penjualan`
--
DELIMITER $$
CREATE TRIGGER `triger_penjualan` AFTER INSERT ON `tbl_detail_penjualan` FOR EACH ROW BEGIN
UPDATE tbl_brg SET stok=stok - new.jml_jual
WHERE kd_brg = new.kd_brg;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jb`
--

CREATE TABLE `tbl_jb` (
  `kd_jb` int(11) NOT NULL,
  `nm_jb` varchar(20) NOT NULL,
  `satuan_jual` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_jb`
--

INSERT INTO `tbl_jb` (`kd_jb`, `nm_jb`, `satuan_jual`) VALUES
(1, 'pampers', 'bungkus'),
(2, 'rokok', 'bungkus'),
(3, 'susu kaleng', 'kalengan'),
(4, 'air minum', 'botol');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pembelian`
--

CREATE TABLE `tbl_pembelian` (
  `no_faktur` varchar(15) NOT NULL,
  `tgl_pembelian` date NOT NULL,
  `total_bayar` int(11) NOT NULL,
  `kd_suplier` int(11) NOT NULL,
  `kd_karyawan` int(11) NOT NULL,
  `tgl_return_brg` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_pembelian`
--

INSERT INTO `tbl_pembelian` (`no_faktur`, `tgl_pembelian`, `total_bayar`, `kd_suplier`, `kd_karyawan`, `tgl_return_brg`) VALUES
(' B29071900', '2019-07-29', 0, 1, 4, '2019-08-29');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_penjualan`
--

CREATE TABLE `tbl_penjualan` (
  `faktur_penjualan` varchar(10) NOT NULL,
  `tgl_penjualan` date NOT NULL,
  `no_kasir` int(11) NOT NULL,
  `total_bayar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_penjualan`
--

INSERT INTO `tbl_penjualan` (`faktur_penjualan`, `tgl_penjualan`, `no_kasir`, `total_bayar`) VALUES
('J290719001', '2019-07-29', 1, 94000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_suplier`
--

CREATE TABLE `tbl_suplier` (
  `kd_suplier` int(11) NOT NULL,
  `nm_suplier` varchar(20) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `nohp` bigint(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_suplier`
--

INSERT INTO `tbl_suplier` (`kd_suplier`, `nm_suplier`, `alamat`, `nohp`) VALUES
(1, 'supriyono', 'bogor', 82222);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL,
  `nm_user` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `nohp` bigint(14) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(50) NOT NULL,
  `lvl_user` enum('admin','kasir','gudang') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `nm_user`, `tgl_lahir`, `alamat`, `nohp`, `username`, `password`, `lvl_user`) VALUES
(1, 'Bayu Pam', '2000-12-30', 'Dk Windurojo Rt 001 Rw 005 Ds Kesesi Kab Pekalongan', 825267065, 'bayu', '123', 'kasir'),
(2, 'Habsyi Ikhlashul A', '2000-11-01', 'Dk Kauman Rt 001 Rw 004 Ds Kesesi Kab Pekalongan', 82324504, 'habsyi', '123', 'admin'),
(3, 'Doni Aja', '2000-07-22', 'Jakarta', 82233456, 'doni', '123', 'kasir'),
(4, 'yui', '2019-07-01', 'bogor', 82345678909, 'yui', '123', 'gudang');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_brg`
--
ALTER TABLE `tbl_brg`
  ADD PRIMARY KEY (`kd_brg`);

--
-- Indexes for table `tbl_detail_brg`
--
ALTER TABLE `tbl_detail_brg`
  ADD PRIMARY KEY (`id_detail_brg`);

--
-- Indexes for table `tbl_detail_pembelian`
--
ALTER TABLE `tbl_detail_pembelian`
  ADD PRIMARY KEY (`id_pembelian`);

--
-- Indexes for table `tbl_detail_penjualan`
--
ALTER TABLE `tbl_detail_penjualan`
  ADD PRIMARY KEY (`id_penjualan`);

--
-- Indexes for table `tbl_jb`
--
ALTER TABLE `tbl_jb`
  ADD PRIMARY KEY (`kd_jb`,`nm_jb`);

--
-- Indexes for table `tbl_pembelian`
--
ALTER TABLE `tbl_pembelian`
  ADD PRIMARY KEY (`no_faktur`);

--
-- Indexes for table `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD PRIMARY KEY (`faktur_penjualan`);

--
-- Indexes for table `tbl_suplier`
--
ALTER TABLE `tbl_suplier`
  ADD PRIMARY KEY (`kd_suplier`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_brg`
--
ALTER TABLE `tbl_brg`
  MODIFY `kd_brg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_detail_brg`
--
ALTER TABLE `tbl_detail_brg`
  MODIFY `id_detail_brg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_detail_pembelian`
--
ALTER TABLE `tbl_detail_pembelian`
  MODIFY `id_pembelian` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_detail_penjualan`
--
ALTER TABLE `tbl_detail_penjualan`
  MODIFY `id_penjualan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_jb`
--
ALTER TABLE `tbl_jb`
  MODIFY `kd_jb` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbl_suplier`
--
ALTER TABLE `tbl_suplier`
  MODIFY `kd_suplier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
