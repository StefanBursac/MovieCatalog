using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    public class Computer
    {
        public string motherBoard;
        public string cpu;
        public string memory;
        public string hardDrive;
        public string graphicsCard;
        public string soundCard;
        public string operatingSystem;

        public void UpisujeUHardDisk()
        {

        }

        public void VrsiComputaciju()
        {

        }
        
        public void UcitavaOperativniSistem()
        {
            
        }

        public void PromeniCpuModel()
        {

        }

        public void PromeniGraficku()
        {

        }

    
        public virtual void ShowConfiguration()
    {
        Console.Write(
            "MotherBoard:"+motherBoard + "\n"+
            "Cpu:"+ cpu + "\n"+
            "Memory:"+ memory +"\n"+ 
            "Harddrive:"+ hardDrive + "\n"+
            "graphicsCard:" +graphicsCard + "\n"+
            "SoundCard:"+ soundCard + "\n"+
            "OperatingSystem:"+ operatingSystem);        
    }


    }



}
