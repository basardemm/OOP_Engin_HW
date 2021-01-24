using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engin_Odev_Gun5
{
    class Program
    {
        static void Main(string[] args)
        {

            Dogrulama dogrulama = new Dogrulama()
            {
                TCKimlik = "22233344455",
                Ad = "Şeyhmuz",
                Soyad = "Dingak",
                DogumYili = "1975",
            };

            MusteriBilgileri musteriBilgileri = new MusteriBilgileri(dogrulama);

            if (musteriBilgileri.ifade == true)
            {
                OyunSatis oyunSatis = new OyunSatis();
                oyunSatis.KampanyaGir();
            }

            Console.ReadKey(true);
        }
    }
}
