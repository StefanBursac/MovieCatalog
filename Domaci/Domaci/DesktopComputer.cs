using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{ 
    public class DesktopComputer : Computer 
    {

        public string Monitor; 
        public string tower;
        public string mouse;
        public string keyboard;
        public string webCamera; 

        public void PrikazivanjeSlikeNaEkran() { }

        public void SnimaKamerom() { }

         public void UpravljanjeMisom() { }

        public void Unostastaturom() { }

        public override void ShowConfiguration()
        {
            base.ShowConfiguration();
            Console.WriteLine();
            Console.Write("Monitor:{0} \nTower:{1} \nMouse:{2} \nKeyboard:{3} \nWebCamera:{4}",Monitor,tower,mouse,keyboard,webCamera);
            Console.WriteLine();
        }                             
    }
}
