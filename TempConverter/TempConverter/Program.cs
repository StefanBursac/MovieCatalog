using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempconvert tempC = new Tempconvert();

            double fahrenhajt = tempC.CelsiusToFahrehajt(2);

            Console.WriteLine(fahrenhajt);

            Console.ReadLine();
        }
    }
}
