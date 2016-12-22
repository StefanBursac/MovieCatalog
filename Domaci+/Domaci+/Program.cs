using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_
{
    class Program : Functions
    {
        static void Main(string[] args)
        {

            Functions funkcija = new Functions();

            funkcija.NaopisiTolikoPuta("Ja se zovem Stefan", 20);


            Console.WriteLine("--------------------------------");


            double prosek = funkcija.IzracunajProsekDvaBroja(10.5, 20.10);

            Console.WriteLine("Prosek je:" + prosek);


            Console.WriteLine("--------------------------------");

            Program p = new Program();

            p.NaopisiTolikoPuta("Stefan",100);

            Console.ReadKey();

        }


        public override void NaopisiTolikoPuta(string staNapisati, int kolikoPuta)
        {
            base.NaopisiTolikoPuta(staNapisati, kolikoPuta);
            Console.WriteLine("Napisano je: " + kolikoPuta + " puta");

        }




        


        }
    }
