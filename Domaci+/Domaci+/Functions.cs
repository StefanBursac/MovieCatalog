using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_
{
    public class Functions
    {

        public virtual void NaopisiTolikoPuta(string staNapisati, int kolikoPuta)
        {
            for (int i = 0; i < kolikoPuta; i++)
            {
                Console.WriteLine(staNapisati);
            }
        }

        public double IzracunajProsekDvaBroja(double a, double b)
        {
            double sum = a + b;

            double prosek = sum / 2;

            return prosek;
        }

     


        }

}

