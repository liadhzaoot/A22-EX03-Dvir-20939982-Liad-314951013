﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLogic;
using System.Threading;

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
                Console.Clear();
                m_MainMenu.ShoeMenu();
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
                    showLicenseNumbersWithStatus();
                    Thread.Sleep(3000);
                    break;
                case 3:
                    changeVehicleStatuses();
                    Thread.Sleep(3000);
                    break;
                case 4:
                    filVehicleWheelsAirToMax();
                    Thread.Sleep(3000);
                    break;
                case 5:
                    refuelVehicle();
                    Thread.Sleep(3000);
                    break;
                case 6:
                    chargeElectricVehicle();
                    Thread.Sleep(3000);
                    break;
                case 7:
                    showFullInfo();
                    Thread.Sleep(5000);
                    break;
                case 8:
                    s_ExitProgram = true;
                    break;
                default:
                    throw new ValueOutOfRangeException(1, 8);
            }
        }

        private void addNewVehicleToGarage()
        {
            List<string> infoRequired;
            string licenseNumber = "";
            string ownerName = "";
            string phoneNumber = "";
            int userVehicleChoice = 0;
            Vehicle vehicleToCreate;
            VehicleInGarage vehicleInGarage = new VehicleInGarage();

            licenseNumber = getLicenseNumber();
            try
            {
                m_Garage.GetVehicleInGarageByLicenseNumber(licenseNumber);
            }

            catch
            {
                showSupportedVehicleInGarage();
                userVehicleChoice = getUserVehicleChoice();
                vehicleToCreate = m_Garage.GetVehicleFromSupportedByIndex(userVehicleChoice - 1);
                vehicleToCreate.LicenseNumber = licenseNumber;
                vehicleInGarage.Vehicle = vehicleToCreate;
                getAllRequiredInfo(vehicleInGarage);
                m_Garage.addVehicleToGarage(vehicleInGarage);
            }
        }

        private void getAllRequiredInfo(VehicleInGarage i_VehicleInGarage)
        {
            int requireIndex = 0;
            string userInput = "";
            bool validInput;
            Console.Clear();            

            foreach (string require in i_VehicleInGarage.RequiredInfoForVehicleInGarage())
            {
                Console.Clear();
                do
                {
                    try
                    {
                        userInput = getUserInput(require);
                        i_VehicleInGarage.CheckUserInputVehicle(userInput, requireIndex);
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
                int.TryParse(userInput, out intUserInput);
                try 
                {
                    validateInputByRange(intUserInput, 1, supportedTypeCount);
                    validChoice = true;
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    showSupportedVehicleInGarage();

                }
            }

            return intUserInput;
        }

        

        private void showSupportedVehicleInGarage()
        {
            Console.WriteLine("Our Garage support these Vehicles");
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
            Console.Clear();
            return licenseNumber;
        }

        public static void validateInputByRange(int i_UserInput, int i_MinValue, int i_MaxValue)
        {
            if (i_UserInput <i_MinValue || i_UserInput >i_MaxValue)
            {
                throw new ValueOutOfRangeException(i_MinValue, i_MaxValue);
            }
        }

        private void  showLicenseNumbersWithStatus()
        {
            int userFilterChice = getInputFromTypeOfEnum(typeof(EnumClass.eVehicleStatus));
            EnumClass.eVehicleStatus eVehicleStatus = (EnumClass.eVehicleStatus)(userFilterChice - 1);
            List<string> licenseNumberByStatuse = m_Garage.GetLicenseNumbersByVehicleStatus(eVehicleStatus);
            Console.Clear();
            Console.WriteLine("The Licenses numbers are:");
            foreach(string licenseNumber in licenseNumberByStatuse)
            {
                Console.WriteLine(licenseNumber);
            }
        }
     
        private void changeVehicleStatuses()
        {
            string licenseNumber = getLicenseNumber();
            int userStatusToChange = getInputFromTypeOfEnum(typeof(EnumClass.eVehicleStatus));
            EnumClass.eVehicleStatus eVehicleStatus = (EnumClass.eVehicleStatus)(userStatusToChange - 1);

            try
            {
                m_Garage.ChangeStatus(licenseNumber, eVehicleStatus);
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        private void filVehicleWheelsAirToMax()
        {
            string licenseNumber = getLicenseNumber();
            try
            {
                m_Garage.FillMaxAir(licenseNumber);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        private void refuelVehicle()
        {
            string licenseNumber = getLicenseNumber();
            int userTypeOfFuel = getInputFromTypeOfEnum(typeof(EnumClass.eFuelType));
            EnumClass.eFuelType eFuelType = (EnumClass.eFuelType)(userTypeOfFuel - 1);
            bool validChoice = false;
            string usreInput = "";
            int intUserInput = 0;
            while (validChoice == false)
            {
                try
                {
                    usreInput = getUserInput("Please enter how many liiters of fuel you want to add");
                    validChoice = int.TryParse(usreInput, out intUserInput);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    validChoice = false;
                    Console.WriteLine(ex.Message);
                }
            }

            try
            {
                m_Garage.RefuelVehicle(licenseNumber, eFuelType, intUserInput);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }

        }

        private int getInputFromTypeOfEnum(Type i_TypeOfEnumClass)
        {
            int sizeOfEnumType = Enum.GetNames(i_TypeOfEnumClass).Length;
            int intUserInput = 0;
            string userInput = "";
            bool validChoice = false;

            while (validChoice == false)
            {
                Console.WriteLine(EnumClass.GetEnumOptions(typeof(EnumClass.eVehicleStatus)));
                userInput = getUserInput(string.Format("Please enter your chioce (1-{0})", sizeOfEnumType));
                int.TryParse(userInput, out intUserInput);
                try
                {
                    validateInputByRange(intUserInput, 1, sizeOfEnumType);
                    validChoice = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            return intUserInput;
        }

       
        private void chargeElectricVehicle()
        {
            string licenseNumber = getLicenseNumber();
            bool validChoice = false;
            string usreInput = "";
            int intUserInput = 0;
            while (validChoice == false)
            {
                try
                {
                    usreInput = getUserInput("Please enter how many minutes of charge you want to add");
                    validChoice = int.TryParse(usreInput, out intUserInput);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    validChoice = false;
                    Console.WriteLine(ex.Message);
                }
            }

            try
            {
                m_Garage.RechargeElectricVehicle(licenseNumber, intUserInput);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        private void showFullInfo()
        {
            string licenseNumber = getLicenseNumber();
            StringBuilder vehicleInfo = m_Garage.VehicleDetailByLicenseNumber(licenseNumber);
            Console.WriteLine("Your Vehicle's Info:");

            Console.WriteLine(vehicleInfo.ToString());

        }
    }
}
