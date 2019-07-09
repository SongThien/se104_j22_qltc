CREATE DATABASE QuanLyTiecCuoi
USE QuanLyTiecCuoi

CREATE TABLE KHACH_HANG
(
    MA_KHACH_HANG char(10) NOT NULL,
	TEN_CHU_RE nvarchar(30)	NOT NULL,
	TEN_CO_DAU nvarchar(30) NOT NULL,
	SDT char(20),
	PRIMARY KEY (MA_KHACH_HANG)
)

CREATE TABLE MON_AN
(
    MA_MON_AN char(10) NOT NULL,
	TEN_MON_AN nvarchar(30) NOT NULL,
	DON_GIA INT NOT NULL,
	PRIMARY KEY (MA_MON_AN)
)

CREATE TABLE DICH_VU
(
    MA_DICH_VU char(10) NOT NULL,
	TEN_DICH_VU nvarchar(30) NOT NULL,
	DON_GIA INT NOT NULL,
	PRIMARY KEY (MA_DICH_VU)
)

CREATE TABLE LOAI_SANH
(
    MA_LOAI_SANH char(10) NOT NULL,
	TEN_LOAI_SANH nvarchar(30) NOT NULL,
	DON_GIA_TOI_THIEU INT NOT NULL,
	PRIMARY KEY (MA_LOAI_SANH)
)

CREATE TABLE SANH
(
    MA_SANH char(10) NOT NULL,
	TEN_SANH nvarchar(30) NOT NULL,
	MA_LOAI_SANH char(10) NOT NULL,
	SO_LUONG_BAN INT NOT NULL,
	GHI_CHU nvarchar(100),
	PRIMARY KEY (MA_SANH)
)

CREATE TABLE CA
(
	MA_CA CHAR(10) NOT NULL,
	TG_BAT_DAU char(10) NOT NULL,
	TG_KET_THUC char(10) NOT NULL,
	PRIMARY KEY (MA_CA)
)

CREATE TABLE TIEC_CUOI
(
	MA_TIEC_CUOI CHAR(10) NOT NULL,
	MA_KHACH_HANG CHAR(10) NOT NULL,
	MA_SANH CHAR(10) NOT NULL,
	NGAY_TO_CHUC DATE NOT NULL,
	MA_CA CHAR(10) NOT NULL,
	TIEN_DAT_COC INT NOT NULL,
	SL_BAN INT NOT NULL,
	SL_BAN_DU_TRU INT NOT NULL,
	PRIMARY KEY(MA_TIEC_CUOI)
)

CREATE TABLE DAT_MON_AN
(
	MA_TIEC_CUOI CHAR(10) NOT NULL,
	MA_MON_AN CHAR(10) NOT NULL,
	GHI_CHU NVARCHAR(100),
	PRIMARY KEY (MA_TIEC_CUOI, MA_MON_AN)
)

CREATE TABLE DAT_DICH_VU
(
	MA_TIEC_CUOI CHAR(10) NOT NULL,
	MA_DICH_VU CHAR(10) NOT NULL,
	SO_LUONG INT,
	PRIMARY KEY(MA_TIEC_CUOI, MA_DICH_VU)
)

CREATE TABLE HOA_DON_THANH_TOAN
(
	MA_HOA_DON CHAR(10) NOT NULL,
	MA_TIEC_CUOI CHAR(10) NOT NULL,
	NGAY_THANH_TOAN DATE NOT NULL,
	TONG_TIEN_BAN INT NOT NULL,
	TONG_TIEN_DICH_VU INT NOT NULL,
	TONG_TIEN_HOA_DON INT NOT NULL,
	PRIMARY KEY (MA_HOA_DON)
)

CREATE TABLE BAO_CAO_DOANH_SO
(
	MA_BAO_CAO CHAR(10) NOT NULL,
	THANG VARCHAR(10) NOT NULL,
	TONG_DOANH_THU INT NOT NULL,
	PRIMARY KEY (MA_BAO_CAO)
)

CREATE TABLE CHI_TIET_BAO_CAO
(
	MA_BAO_CAO CHAR(10) NOT NULL,
	NGAY DATE NOT NULL,
	SO_LUONG INT NOT NULL,
	DOANH_THU INT NOT NULL,
	TI_LE FLOAT,
	PRIMARY KEY (MA_BAO_CAO, NGAY)
)



ALTER TABLE SANH ADD CONSTRAINT S_LS_MLS FOREIGN KEY (MA_LOAI_SANH) REFERENCES LOAI_SANH (MA_LOAI_SANH)
ALTER TABLE TIEC_CUOI ADD CONSTRAINT TC_KH_MKH FOREIGN KEY (MA_KHACH_HANG) REFERENCES KHACH_HANG (MA_KHACH_HANG)
ALTER TABLE TIEC_CUOI ADD CONSTRAINT TC_S_MS FOREIGN KEY (MA_SANH) REFERENCES SANH (MA_SANH)
ALTER TABLE TIEC_CUOI ADD CONSTRAINT TC_C_MS FOREIGN KEY (MA_CA) REFERENCES CA (MA_CA)
ALTER TABLE DAT_MON_AN ADD CONSTRAINT DMA_TC_MTC FOREIGN KEY (MA_TIEC_CUOI) REFERENCES TIEC_CUOI(MA_TIEC_CUOI)
ALTER TABLE DAT_MON_AN ADD CONSTRAINT DMA_MA_MMA FOREIGN KEY (MA_MON_AN) REFERENCES MON_AN (MA_MON_AN)
ALTER TABLE DAT_DICH_VU ADD CONSTRAINT DDV_TC_MTC FOREIGN KEY (MA_TIEC_CUOI) REFERENCES TIEC_CUOI (MA_TIEC_CUOI)
ALTER TABLE DAT_DICH_VU ADD CONSTRAINT DDV_DV_MDV FOREIGN KEY (MA_DICH_VU) REFERENCES DICH_VU (MA_DICH_VU)
ALTER TABLE HOA_DON_THANH_TOAN ADD CONSTRAINT HDTT_TC_MTC FOREIGN KEY (MA_TIEC_CUOI) REFERENCES TIEC_CUOI (MA_TIEC_CUOI)
ALTER TABLE	CHI_TIET_BAO_CAO ADD CONSTRAINT CTBC_BCDS_MBC FOREIGN KEY (MA_BAO_CAO) REFERENCES BAO_CAO_DOANH_SO (MA_BAO_CAO)
