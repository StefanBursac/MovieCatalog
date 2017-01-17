using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    public class Store
    {
        private string imeProdavnice = null;
        private string lokacijaProdavnice = null;


        public string DodajProdavnicu(string ime, string ulica, int broj)
        {
            imeProdavnice = ime;
            lokacijaProdavnice = ulica +","+ broj;

            return imeProdavnice +","+lokacijaProdavnice;
        }

        public void IspisiProdavnicu()
        {
            Console.WriteLine(imeProdavnice+","+lokacijaProdavnice);
        }
    }
}
