using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie m = new Movie();
            Console.WriteLine(m.Ubaci("Stefan"));
            Console.WriteLine(m.Ubaci("Bursac"));

            Console.WriteLine(m.Lista);


            Console.ReadKey();



        }
    }
}
