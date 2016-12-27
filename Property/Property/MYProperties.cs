using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class MYProperties
    {

        public string Ime { get; set; }

        public int godine { get; set; }

        public int godina;

        public virtual void Izvrti()
        {
            for (int i = 0; i < 100; i++) { Console.WriteLine(i); }
        }

    }
}
