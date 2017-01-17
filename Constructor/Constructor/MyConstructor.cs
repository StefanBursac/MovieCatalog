using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class MyConstructor
    {

        int i { get; set; }


        public MyConstructor(string upis)
        {
            Console.WriteLine(upis);
        }

        public MyConstructor(int upis)
        {
            Console.WriteLine(upis);
        }



    }
}
