using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Enum ve interface konularını içeren örnek uygulama
            */

            /*
              Senaryo:

              Bir ulaşım şirketi, farklı araç türleriyle (araba, motosiklet, otobüs) yolculuk yapmaktadır.
              Bu araçların her biri belirli özelliklere sahiptir ve bir arayüz üzerinden farklı işlemler
              yapılabilmektedir. Uygulama, her aracın hızını artırma, hızını azaltma ve aracı durdurma gibi 
              işlemleri gerçekleştiren bir sistem üzerinden çalışacak.
             */

            /*
             Kullanılacak Yapılar:

              1-Enum: Farklı araç türlerini tanımlamak için kullanılacak.
              2-Interface: IVehicle adında bir arayüz oluşturulacak, araçlar bu arayüzü implement edecek.
              3-Temel Sınıflar: Her araç türü (Araba, Motosiklet, Otobüs) IArac arayüzünü implement edecek.
             */

            /*
             *Adımlar:

            1-Enum Tanımlaması: Araç türlerini belirleyeceğiz (Araba, Motosiklet, Otobüs).
            2-Interface Tanımlaması: Tüm araçların sahip olması gereken işlemleri tanımlayacağız
             (Basla(), Dur(), Hızlan() ve Yavasla()).
            3-Class Implementasyonu: Her araç türü bu işlemleri kendine uygun şekilde gerçekleştirecek.
             */

            /*
             Açıklamalar:

             1-Enum (VehicleType): Araç türlerini belirliyoruz. Bu, ileride yeni araç türleri eklerken bize yardımcı olacaktır.

             2-Interface (IArac): IArac arayüzü, her aracın implement etmesi gereken metotları (başlatma, durdurma, hızlanma, yavaşlama) tanımlar.

             3-sınıflar: Her bir araç (Araba, Motosiklet, Otobüs), IArac arayüzünü implement eder ve bu metotları kendi içlerinde uygun şekilde gerçekleştirir.

             4-Program.cs: Main fonksiyonu içinde, araçları başlatıyoruz, hızlandırıyoruz, yavaşlatıyoruz ve durduruyoruz. Bu işlemler, her araç türüne özgü özellikleri gösterir.
             */







            //Araçları yaratıyoruz
            IArac araba = new Araba("BMW");
            IArac motosiklet = new Motosiklet("Yamaha");
            IArac otobus = new Otobus("Mercedes");


            //Araçları başlatıyoruz
            araba.Basla();
            motosiklet.Basla();
            otobus.Basla();
            Console.WriteLine();


            //Araçları hızlandırıyoruz
            araba.Hizlan();
            motosiklet.Hizlan();
            otobus.Hizlan();
            Console.WriteLine();


            //Araçları yavaşlatıyoruz
            araba.Yavasla();
            motosiklet.Yavasla();
            otobus.Yavasla();
            Console.WriteLine();


            //Araçları durduruyoruz
            araba.Dur();
            motosiklet.Dur();
            otobus.Dur();


            Console.ReadKey();



        }
    }
}
