using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci__
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasa1 klasa1 = new Klasa1();

            klasa1.PomnoziDvaBroja(2,10);

            Klasa1 klasa2 = new Klasa2(); 

            klasa1.izracunajVrednostDvaBoja(20,10);

            klasa2.izracunajVrednostDvaBoja(20,10);

            Console.ReadKey();
        }
    }
}
