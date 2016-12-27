using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            TemperatureConventer temp = new TemperatureConventer();

            double fahrenheight = temp.toFarenheight(5);

            //Console.WriteLine(temp.toFarenheight(5));

            Console.WriteLine(fahrenheight);

            Console.ReadKey();
        }
    }
}
