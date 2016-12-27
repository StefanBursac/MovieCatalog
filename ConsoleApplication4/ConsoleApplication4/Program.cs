using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Klasa k = new Klasa();

            k.firstName = "Stefan";
            k.lastName = "Bursac";

            Console.WriteLine(k.firstName+" "+k.lastName);




            Console.ReadKey();



        }
    }
}
