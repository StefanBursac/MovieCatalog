using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciMojeVezbe
{
    class Program
    {
        static void Main(string[] args)
        {

            Klasa1 klasa1 = new Klasa1();

            int KolikoKaraktera = klasa1.KolikoKaraktera("Ja se zovem Stefan");

            Console.WriteLine("Ukupno ima {0} karaktera",KolikoKaraktera);

            Console.WriteLine("-------------------------------------------------");

            klasa1.FarenhajtToCelzijus(50);

            Console.WriteLine("-------------------------------------------------");

            klasa1.NapisiIme();

            Klasa2 klasa2 = new Klasa2();

            klasa2.NapisiIme();


            Console.ReadKey();

        }
    }
}
