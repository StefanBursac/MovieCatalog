using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    public class GamingDesktopComputer : DesktopComputer
    {
       public string brand;
       public string model;
       public bool waterCoolingSystem;
       public string gamepad;

        public void upravljanjeGamepadom()
        {

        }

        public void NasledjeneFunkcije()
        {
            VrsiComputaciju();
            UcitavaOperativniSistem();
            UpisujeUHardDisk();
            PrikazivanjeSlikeNaEkran();
        }

        public override void ShowConfiguration()
        {
            base.ShowConfiguration();
            Console.WriteLine();
            Console.Write("Monitor:{0} \nTower:{1} \nMouse:{2} \nKeyboard:{3} \nWebCamera:{4} \nBrand:{5} \nmodel:{6} \ngamepad:{7}", Monitor, tower, mouse, keyboard, webCamera,brand,model,gamepad);
            if (waterCoolingSystem) { Console.WriteLine("Has Water cooling Sytstem"); }
            Console.WriteLine();
        }

    }
}

