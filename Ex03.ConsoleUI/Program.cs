using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLogic;

namespace Ex03.ConsoleUI
{
    class Program
    {
       public static void Main()
        {
            UserInterface userInterface = new UserInterface();
            //Console.WriteLine((EnumClass.eVehicleStatus)(2 - 1));
            userInterface.Start();

        }
    }
}
