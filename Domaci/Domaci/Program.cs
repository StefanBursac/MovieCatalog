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
            desk.graphicsCard = " AtiRadeon";
            desk.keyboard = " Logitech";
            desk.webCamera = " LogitscWebCam";
            desk.operatingSystem = " Windows 10";
            desk.hardDrive = " Seagate 1TB";
            desk.soundCard = " Realtek";

            desk.ShowConfiguration();


            DesktopComputer deskKomp = new DesktopComputer();
            deskKomp.VrsiComputaciju();
            deskKomp.UcitavaOperativniSistem();
            deskKomp.UpisujeUHardDisk();

            Console.WriteLine("------------------------------");


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

            Console.WriteLine();
            Console.WriteLine();

            GamingDesktopComputer razer = new GamingDesktopComputer();

            razer.VrsiComputaciju();
            razer.upravljanjeGamepadom();
            razer.UpravljanjeMisom();

            Console.WriteLine("---------------------------------------");

            


            Store prodavnica1 = new Store();

            prodavnica1.DodajProdavnicu("Positive", "Danila Kisa",5);
            
            prodavnica1.IspisiProdavnicu();

            Store prodavnica2 = new Store();

            prodavnica2.DodajProdavnicu("Gigatron","TC Bazar",10);

            prodavnica2.IspisiProdavnicu();

            Console.ReadKey();
        }
    }
}
