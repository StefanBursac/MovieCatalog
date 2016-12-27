using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Moje2 : MYProperties
    {

        public override void Izvrti()
        {
            //base.Izvrti();
            for (int i = 100; i > 0; i--) { Console.WriteLine(i); }
        }
    }
}
