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


        public virtual string Configuration()
        {
           string DesktopConfiguration = motherBoard +"\n"+cpu + memory + "\n" + graphicsCard + "\n" + soundCard +"\n" + Monitor +"\n" + tower +"\n" +  mouse +"\n" + keyboard + "\n" + webCamera +"\n" + operatingSystem;

           return DesktopConfiguration;
        } 

        


    }








}
