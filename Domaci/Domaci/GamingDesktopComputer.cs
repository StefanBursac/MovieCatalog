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

        public override string Configuration()
        {
            string gamingConfiguration = "\n" + brand + "\n"+model + "\n"+gamepad;
            string wcs = "";
            if (waterCoolingSystem) { wcs = "Has Water Cooling"; }

            return base.Configuration()+gamingConfiguration+"\n"+wcs;;
            
        }






    }


}

