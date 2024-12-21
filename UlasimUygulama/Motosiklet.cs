using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlasimUygulama
{
    public class Motosiklet : IArac
    {
        public string isim;
        public int hiz = 0;

        public Motosiklet(string isim)
        {
            this.isim = isim;
        }
        public void Basla()
        {
            Console.WriteLine(isim + " çalıştırıldı");
        }

        public void Dur()
        {
            Console.WriteLine(isim + " durdu");
        }

        public void Hizlan()
        {
            hiz += 120;
            Console.WriteLine(isim + " hızlandı.Şuan ki hızı : " + hiz + "km/s");
        }

        public void Yavasla()
        {
            hiz = (hiz - 30 < 0) ? 0 : hiz - 30;
            Console.WriteLine(isim + " yavaşladı.Şuan ki hızı : " + hiz + "km/s");
        }
    }
}
