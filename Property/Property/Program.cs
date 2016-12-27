using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {

            MYProperties moje = new MYProperties();

            moje.Ime = "Stefan";

            Console.WriteLine(moje.Ime);

            moje.godine = 31;

            moje.godina = 1985;

            Console.WriteLine(moje.godine);

            Console.WriteLine(moje.godina);

            moje.Izvrti();

            Moje2 moje2 = new Moje2();

            moje2.Izvrti(); 



            Console.ReadKey();





        }
    }
}
