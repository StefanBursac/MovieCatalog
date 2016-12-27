using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci__
{
    public class Klasa1
    {
        public void PomnoziDvaBroja(int prviBroj, int drugiBroj)
        {
            int rezultat = prviBroj* drugiBroj;

            Console.WriteLine("Rezultat je " + rezultat);
        }

        public virtual void izracunajVrednostDvaBoja(int a, int b)
        {
            int rezultat = a + b;
            Console.WriteLine(rezultat);
        }

        


    }
}
