using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLogic;

namespace Ex03.ConsoleUI
{
    class UserInterface
    {
        private Garage m_Garage;
        private List<string> m_MainMenu;
        private List<string> m_SupportedVehicles;
        public UserInterface()
        {
            m_Garage = new Garage();
            //m_SupportedVehicle = m_Garage.SupportedVehicles;
        }

        public void Start()
        {
            Console.WriteLine("Welcome To Our Garage");
            string usreInput = "";
            while (!usreInput.Equals('q'))
            {
                usreInput = getUserInput("Please Add Your Vehicle to our Garage\nTo Quit Please enter 'q'");

            }
        }

        private string getUserInput(string i_Output="")
        {
            string userInput = "";
            if (i_Output != "")
            {
                Console.WriteLine(i_Output);
            }

            userInput = Console.ReadLine();
            return userInput;
        }

        private void showMenu()
        {
            if (m_SupportedVehicles != null)
            {
                for (int i = 0; i < m_SupportedVehicles.Count; i++)
                {
                    Console.WriteLine("Press {0} To Add {1}", i+1, m_SupportedVehicles[i]);
                }
            }
        }

        

    }
}
