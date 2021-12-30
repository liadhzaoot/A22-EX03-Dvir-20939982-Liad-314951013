using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLogic;


namespace Ex03.ConsoleUI
{
    public class MainMenu
    {
        private List<string> m_Options;

        public MainMenu()
        {
            createOptions();
        }

        private void createOptions()
        {
            m_Options = new List<string>();
            m_Options.Add("Press 1 To Add new vehicle To the Garage.");
            m_Options.Add("Press 2 To Display license plate numbers for all vehicles in the garage.");
            m_Options.Add("Press 3 To Modify vehicle's status.");
            m_Options.Add("Press 4 To Inflate vehicle's wheels to maximum.");
            m_Options.Add("Press 5 To Refuel a gasoline-powered vehicle.");
            m_Options.Add("Press 6 To Charge an electric vehicle.");
            m_Options.Add("Press 7 To Display full details of a vehicle.");
            m_Options.Add("Press 8 To Quit.");
        }

        public void ShoeMenu()
        {
            foreach (string option in m_Options)
            {
                Console.WriteLine(option);
            }
        }

        public int ValidateMenuChoice()
        {
            bool validChoice = false;
            string usreInput = "";
            int intUserInput = 0;
            while(validChoice == false)
            {
                try
                {
                    Console.WriteLine("Please enter your chioce (1-{0})", m_Options.Count);
                    usreInput = Console.ReadLine();
                    validChoice = int.TryParse(usreInput, out intUserInput);
                    UserInterface.ValidateInputByRange(intUserInput, 1, m_Options.Count);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    validChoice = false;
                    Console.WriteLine(ex.Message);
                    ShoeMenu();
                }
            }

            return intUserInput;
        }

    }
}
