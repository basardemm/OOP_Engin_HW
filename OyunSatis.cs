using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engin_Odev_Gun5
{
    public class OyunSatis:IKampanya
    {
        
        public void KampanyaGir()
        {
            Console.WriteLine("%20 indirim uygulanacak");
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Kampanya 1 ay sonra %10 olacak");
        }

        public void KampanyaSil()
        {
            Console.WriteLine("Kampanya silindi");
        }
    }
}
