using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class Laptop : Computer
    {
       public string screenSize;
       public bool touchscreen;
       


        public void CrtanjePoekranu()
        {

        }    

        public void IskljucivanjeSvetlaNaTastaturi()
        {

        }

        public void NasledjeneFunkcije()
        {
            VrsiComputaciju();
            UcitavaOperativniSistem();
            UpisujeUHardDisk();
        
        }

        public override void ShowConfiguration()
        {
            base.ShowConfiguration();
            Console.WriteLine();
            Console.WriteLine("ScreenSize:"+screenSize);
            if (touchscreen) { Console.Write("Has TouchScreen"); }
        }
    }

}

