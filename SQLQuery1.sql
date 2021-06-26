create Database DbCV 
use DbCV  

create table TblHakkimda (
Id int primary key,
Ad varchar(30),
Soyad varchar(30),
Telefon varchar(20),
mailbir varchar(50),
mailiki varchar(50),
aciklama varchar (Max),
resim varchar(100),
);

Create TAble TblDeneyimler(
ID int primary key,
Baslık varchar(100),
AltBaslık varchar(100),
Aciklama varchar(max),
tarih varchar(100),
 

);

Create TAble TblEgitim(
ID int primary key,
resim varchar(100),
Baslık varchar(100),
AltBaslık varchar(100),
GNO varchar(10),
Aciklama varchar(max),
Tarih varchar(100),

);

Create TAble TblYetenekler(
Id int primary key ,
yetenek_ismi varchar(50),
);

create table iletisim(
id int primary key,
AdSoyad varchar(100),
Mail Varchar(100),
Konu varchar(100),
Mesaj varchar(1000),
Tarih date,
);

create TAble TblLogin(
İd int primary key,
KullaniciAdi varchar (30),
Sifre varchar (30),
)