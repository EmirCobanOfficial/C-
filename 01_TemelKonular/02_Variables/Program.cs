using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değiskenler
            //double number;
            //number = 9.5;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Lisesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---- Şeftali Birim Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma - " + "BirimFiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + "₺");

            //Console.WriteLine("Alınan Ürün: Portakal - " + "BirimFiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + "₺");

            //Console.WriteLine("Alınan Ürün: Çilek - " + "BirimFiyat: " + strawberryPrice + " - Gramaj: " + strawGram + " - Toplam Tutar: " + strawberryTotalPrice + "₺");

            //Console.WriteLine("Alınan Ürün: Patates - " + "BirimFiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + "₺");

            //Console.WriteLine("Alınan Ürün: Domates - " + "BirimFiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + "₺");

            //double shoppingTotalPrice = appleTotalPrice + tomatoTotalPrice + strawberryTotalPrice + orangeTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine(" Toplam Fiyat: " + shoppingTotalPrice + "₺");
            #endregion

            #region Char Değiskenler

            //ABCDEFGH

            //Char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri String Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 15000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice =  shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice+ tvPrice*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, exam4, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz.");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz.");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz.");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 4. Sınav notunu giriniz");
            //exam4 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3 + exam4) / 4;
            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen ciniyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Şeçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}