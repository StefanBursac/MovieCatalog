using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeVezbe
{
    class Funkcije
    {


        public virtual void IspisiNesto(string Nesto,int kolikoPuta)
        {
            for (int i = 0; i < kolikoPuta; i++)
            {
                Console.WriteLine(Nesto);
            }
        }

        public void IspisiMojeIme(string Ime)
        {
            Console.WriteLine(Ime);
     
        }







    }
}
