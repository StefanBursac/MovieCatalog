using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer comp = new Computer();

            comp.cpu = " Intel";
            comp.motherBoard = " Gigabyte";
            comp.memory = " Kingston 4gb";
            comp.hardDrive = " Seagate";
            comp.graphicsCard = " Nvidia Geforce";
            comp.soundCard = " Realtek";
            comp.operatingSystem = " Windows 10";

            comp.ShowConfiguration();

            Console.WriteLine();
            Console.WriteLine();

            DesktopComputer desk = new DesktopComputer();

            desk.Monitor = " Acer";
            desk.cpu = " Intel";
            desk.motherBoard = " Asus";
            desk.memory = " Kingston";
            desk.mouse = " Logitech";
            desk.tower = " Codegen";
            desk.graphicsCard = "AtiRadeon";
            desk.keyboard = "Logitech";
            desk.webCamera = "LogitscWebCam";
            
            //Console.WriteLine(desk.Configuration());


            DesktopComputer deskKomp = new DesktopComputer();
            deskKomp.VrsiComputaciju();
            deskKomp.UcitavaOperativniSistem();
            deskKomp.UpisujeUHardDisk();

            Laptop lap = new Laptop();
            lap.cpu = " Intel ";
            lap.motherBoard = " Intel ";
            lap.memory = " Kingstone ";
            lap.graphicsCard = " Intel HD400 ";
            lap.operatingSystem =" Windows 10 ";
            lap.hardDrive = " WD ";
            lap.soundCard = " Realtek ";
            lap.screenSize =" 12inch";
            lap.touchscreen = true;
            
            lap.ShowConfiguration();

            lap.CrtanjePoekranu();
            lap.Unostastaturom();
            lap.UpravljanjeMisom();

            Console.WriteLine();
            Console.WriteLine();

            GamingDesktopComputer razer = new GamingDesktopComputer();

            razer.brand = "Razer";
            razer.cpu = "IntelCabyLake";
            razer.memory = "Kingston 8 gigabyte";
            razer.hardDrive = "Seagate 500gb";
            razer.motherBoard = "Intel";
            razer.gamepad = "Xbox One Controller";
            razer.waterCoolingSystem = true;
            razer.operatingSystem = "Windows10";
            razer.model = "Blade";
            razer.Monitor = "Nema";
            razer.graphicsCard = "Amd Radeon RX 480";
            razer.soundCard = "RealTek";

           // Console.WriteLine(razer.Configuration());

            razer.VrsiComputaciju();
            razer.upravljanjeGamepadom();
            razer.UpravljanjeMisom();

           
            Console.ReadKey();

            


        }
    }
}
