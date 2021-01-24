using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engin_Odev_Gun5
{
    public class MusteriBilgileri : Dogrulama
    {
       public bool ifade;

        //Constructor
        public MusteriBilgileri(Dogrulama dogrulama)
        {
            Console.WriteLine("TC Kimlik Giriniz");
            TCKimlik = Console.ReadLine();

            if (dogrulama.TCKimlik == TCKimlik)
            {
                ifade = true;
                Console.WriteLine("Hoşgeldiniz!!" + dogrulama.Ad + " " + dogrulama.Soyad);
            }

            else
            {
                ifade = false;
                Console.WriteLine("Başarısız");
            }
        }




    }
}
