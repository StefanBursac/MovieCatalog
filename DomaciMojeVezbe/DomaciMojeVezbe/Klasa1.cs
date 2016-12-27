using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciMojeVezbe
{
    public class Klasa1
    {
        public int KolikoKaraktera(string unesenSring)
        {
            int kolikoUkupnoKaraktera = 0;

            for (int i = 0; i < unesenSring.Length; i++)
            {
                kolikoUkupnoKaraktera = i;
            }

            return kolikoUkupnoKaraktera;
        }

        public void FarenhajtToCelzijus(double farenhajt)
        {
            double celizijus = (farenhajt - 32) * 5 / 9;

            Console.WriteLine("Ima Ukupno {0} stepeni",celizijus);
        }

        public virtual void NapisiIme()
        {
            Console.WriteLine("Stefan");
        }

    }
}
