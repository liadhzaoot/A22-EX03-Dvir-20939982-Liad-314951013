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
        private MainMenu m_MainMenu;
        private List<string> m_SupportedVehicles;
        private static bool s_ExitProgram = false;

        public UserInterface()
        {
            m_Garage = new Garage();
            m_MainMenu = new MainMenu();
            //m_SupportedVehicle = m_Garage.SupportedVehicles;
        }

        public void Start()
        {
            Console.WriteLine("Welcome To Our Garage");
            int intUserInput = 0;
            while (s_ExitProgram == false)
            {
                intUserInput = m_MainMenu.ValidateMenuChoice();
                userSelectionOnManu(intUserInput);

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

        public void userSelectionOnManu(int i_userSelection)
        {
            Console.Clear();
            switch (i_userSelection)
            {
                case 1:
                    addNewVehicleToGarage();
                    break;
                case 2:
                    showLicenseNumbersInStatus();
                    Thread.Sleep(3000);
                    break;
                case 3:
                    changeVehicleStatuses();
                    break;
                case 4:
                    filVehicleWheelsAirToMax();
                    break;
                case 5:
                    refuelVehicle();
                    break;
                case 6:
                    chargeElectricVehicle();
                    break;
                case 7:
                    showFullInfo();
                    Thread.Sleep(5000);
                    break;
                case 8:
                    s_ExitProgram = true;
                    break;
                default:
                    throw new ValueOutOfRangeException(8, 1);
            }
        }

        private void addNewVehicleToGarage()
        {
            List<string> infoRequired;
            string licenseNumber, vehicleTypeNumber, ownerName, phoneNumber;
            int userVehicleChoice = 0;

            licenseNumber = getLicenseNumber();
            if (m_Garage.GetVehicleInGarageByLicenseNumber(licenseNumber) == null)
            {
                showSupportedVehicleInGarage();
                userVehicleChoice = getUserVehicleChoice();
                m_Garage.

            }
        }

        private int getUserVehicleChoice()
        {
            int supportedTypeCount = Enum.GetNames(typeof(EnumClass.eVehicleType)).Length;
            int intUserInput = 0;
            string userInput = "";
            bool validChoice = false;

            while (validChoice == false)
            {
                userInput = getUserInput(string.Format("Please enter your chioce (1-{0}", supportedTypeCount));
                validChoice = int.TryParse(userInput, out intUserInput);
                if (validChoice == true && intUserInput >= 1 && intUserInput <= supportedTypeCount )
                {
                    validChoice = true;
                }
            }

            return intUserInput;
        }

        private void showSupportedVehicleInGarage()
        {
            Console.Clear();
            Console.WriteLine(EnumClass.GetEnumOptions(typeof(EnumClass.eVehicleType)));
        }

        private static string getLicenseNumber()
        {
            Console.Clear();
            bool valid = false;
            string licenseNumber = "";
            do
            {
                Console.Write("Please enter license number: ");
                licenseNumber = Console.ReadLine();
                if (licenseNumber != "")
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    Console.Clear();
                }
            }
            while (valid == false);

            return licenseNumber;
        }

        private void showLicenseNumbersInStatus()
        {

        }

        private void changeVehicleStatuses()
        {

        }

        private void filVehicleWheelsAirToMax()
        {

        }

        private void refuelVehicle()
        {

        }

        private void chargeElectricVehicle()
        {

        }

        private void showFullInfo()
        {

        }
    }
}
