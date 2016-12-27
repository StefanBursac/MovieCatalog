using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeVezbe
{
    class Program
    {
        static void Main(string[] args)
        {

            NasledjeneFunkcije funkcija = new NasledjeneFunkcije();

            funkcija.IspisiNesto("Stefan",100);

            funkcija.IspisiMojeIme("Stefan");

            funkcija.IspisiNesto("Hello World",1000);

            Console.ReadLine();
        }
    }
}
