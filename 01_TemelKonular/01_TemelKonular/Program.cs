using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TemelKonular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");
            //Console.WriteLine("********* Emir Sevdiği Yemekler *********");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorba");
            //Console.WriteLine("2-Patatesli Çorba");


            //Değişkenler
            #endregion

            #region Değişkenler
            //string  
            //değişken türü, değişken adı;
            //string name;
            //name = "Emir";
            //Console.Write(name);
            #endregion

            #region String Değiskenler
            //string customerName, customerSurname, customerEmail, customerPhone, district, city;

            //customerName = "Emir";
            //customerSurname = "Coban";
            //customerEmail = "oguz@gmail.com";
            //customerPhone = "+90 400 300 200 50 10";
            //district = "Kadiköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone + " / " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city );
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerEmail = "customer@gmail.com";
            //district = "Sapancı";
            //city = "Sakarya";
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone + " / " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-------------------------------------------");

            #endregion


            #region Int Değiskenler

            //int 
            //int number = 24;
            //Console.WriteLine(number);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran_Menü Fiyatı ****");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-Hamburger Fiyatı: " + hamburgerPrice + " TL ");
            Console.WriteLine("-Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("-Kola: " + cokePrice + " TL ");
            Console.WriteLine("-Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine("-Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("-Su: " + waterPrice + " TL ");
            Console.WriteLine();

            Console.WriteLine("**** Restoran_Menü Fiyatı ****");
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totallemonadePrice;
            int totalPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalPrice = totalWaterPrice + totalFriesPrice + totalCokePrice + totalHamburgerPrice + totallemonadePrice + totalPizzaPrice;
            

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Kola: " + totalCokePrice + " TL ");
            Console.WriteLine("Su: " + totalWaterPrice + " TL ");
            Console.WriteLine("Kızartma " + totalFriesPrice + " TL ");
            Console.WriteLine("Limonata " + totallemonadePrice + " TL ");
            Console.WriteLine("Pizza: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Toplam Ödenecek Fiyat: " + totalPrice + " TL ");

            #endregion

            Console.ReadLine();
        }
    }
}