using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            MyConstructor constructor = new MyConstructor("Hello World");

            MyConstructor constructor2 = new MyConstructor(1);

            Console.ReadKey();






        }
    }
}
