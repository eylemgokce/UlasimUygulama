using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimUygulama
{
    public class Araba : IArac
    {
        public string isim;
        public int hiz = 0;

        public Araba(string isim)
        {
            this.isim = isim;
        }
        public void Basla()
        {
            Console.WriteLine(isim + " çalıştırıldı");
        }

        public void Dur()
        {
            hiz = 0;
            Console.WriteLine(isim + " durdu");
        }

        public void Hizlan()
        {
            hiz += 60;
            Console.WriteLine(isim + " hızlandı.Şuan ki hızı : " + hiz + "km/s");
        }

        public void Yavasla()
        {
            hiz = (hiz - 10 < 0) ? 0 : hiz - 10;   //bu kod aracın hızını yavaşlatırken hızın negatif bir değere düşmesini engeller.üçlü operatör kullanılarak yapılan bir koşullu işlemdir 
            Console.WriteLine(isim + " yavaşladı.Şuan ki hızı : " + hiz + "km/s");
        }
    }
}
