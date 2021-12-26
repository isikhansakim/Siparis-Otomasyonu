# Siparis-Otomasyonu
Cbü Yazılım Mühendisligi 2. sınıf nesneye yönelik programlama dersi proje ödevinde c# ile yaptığımız sipariş otomasyonu
Kodun çalışması için Microsoft SQL Server Management Stuido 18 lazımdır.

SQL Server açıldıktan sonra Proje Donem1 isimli bir database oluşturulmalıdır.
Database'e sağ tıklayıp new query açılmalıdır.
İçine
---------------------------------------------------------------------------
CREATE TABLE Tbl_Sepetim (Musteri_KullaniciAdi varchar(50), Sepet_Urun_id tinyint, Sepet_id smallint  identity (1,1)); 
CREATE TABLE Tbl_Adresler (Musteri_KullaniciAdi varchar(50), SokakNo varchar(50), ApartmanNo varchar(50), DaireNo varchar(50), Il varchar(50), Ilce varchar(50)); 
CREATE TABLE Tbl_Kartlar (Musteri_KullaniciAdi varchar(50), Isim varchar(50), Soyisim varchar(50), KartNo char(19), CVV char(3), SKT smalldatetime); 
CREATE TABLE Tbl_Musteriler (KullaniciAdi varchar(50) PRIMARY KEY, Sifre varchar(50), Ad varchar(50), Soyad varchar(50)); 
CREATE TABLE Tbl_Siparislerim (MusteriKullaniciAdi varchar(50), Siparis_Urun_id tinyint, Siparis_id smallint  identity (1,1), SiparisAdres varchar(50)); 
CREATE TABLE Tbl_TumUrunler (Urun_id tinyint  identity (1,1), Ad varchar(50), Fiyat smallint, Aciklama varchar(50));  
---------------------------------------------------------------------------
kodları yazılıp execute edilmeli ve tablolar oluşturulmalıdır.

Visual Studioda da Sistem.cs in içindeki SQLConnection içindeki bağlantı değiştrilip kendi bağlantı yazılmalıdır.

Bu işlem gerçekleştikten sonra artık kod kullanıma hazırdır.
