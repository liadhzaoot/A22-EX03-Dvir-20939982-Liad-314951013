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
            int intUserInput;
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
                    //Thread.Sleep(3000);
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
                    //Thread.Sleep(5000);
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
            Vehicle vehicleToCreate;

            licenseNumber = getLicenseNumber();
            try
            {
                m_Garage.GetVehicleInGarageByLicenseNumber(licenseNumber);
            }

            catch (Exception e)
            {
                m_Garage.GetVehicleInGarageByLicenseNumber(licenseNumber);
            }
            catch
            {
                showSupportedVehicleInGarage();
                userVehicleChoice = getUserVehicleChoice();
                vehicleToCreate = m_Garage.GetVehicleFromSupportedByIndex(userVehicleChoice - 1);
                getAllRequiredInfo(vehicleToCreate);
            }
            //if (m_Garage.GetVehicleInGarageByLicenseNumber(licenseNumber) == null)
            //{
            //    showSupportedVehicleInGarage();
            //    userVehicleChoice = getUserVehicleChoice();
            //    vehicleToCreate = m_Garage.GetVehicleFromSupportedByIndex(userVehicleChoice-1);
            //    getAllRequiredInfo(vehicleToCreate);
            //}
        }

        private void getAllRequiredInfo(Vehicle i_Vehicle)
        {
            int requireIndex = 0;
            string userInput = "";
            bool validInput;
            Console.Clear();            

            foreach (string require in i_Vehicle.RequiredInfo())
            {
                Console.Clear();
                do
                {
                    try
                    {
                        userInput = getUserInput(require);
                        i_Vehicle.CheckUserInput(userInput, requireIndex);
                        requireIndex++;
                        validInput = true;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        validInput = false;
                        Console.WriteLine(ex.Message);
                    }
                }
                while (validInput == false);
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
                userInput = getUserInput(string.Format("Please enter your chioce (1-{0})", supportedTypeCount));
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
