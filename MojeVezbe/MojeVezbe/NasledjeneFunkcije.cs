using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeVezbe
{
    class NasledjeneFunkcije : Funkcije
    {

        public override void IspisiNesto(string Nesto, int kolikoPuta)
        {
            base.IspisiNesto(Nesto, kolikoPuta);
            //base.IspisiNesto("Stefan",1); ;
            if (Nesto == "Stefan")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(Nesto + " je " + kolikoPuta + " Puta");
            }
             




        }
    }
}
