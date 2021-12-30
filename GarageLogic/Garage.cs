using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class Garage
    {
        private List<VehicleInGarage> m_VehiclesInGarage;
        private List<Vehicle> m_SupportedVehiclesList;

        public Garage(List<VehicleInGarage> i_Vehicles)
        {
            initSupportedVehicles();
            this.m_VehiclesInGarage = i_Vehicles;
        }
        public Garage()
        {
            initSupportedVehicles();
            m_VehiclesInGarage = new List<VehicleInGarage>();
        }

        private void initSupportedVehicles()
        {
            m_SupportedVehiclesList.Add(new Bike(2, 30, EnumClass.eFuelType.Octan98, 5.8f));
            m_SupportedVehiclesList.Add(new Bike(2, 30, 2.3f));
            m_SupportedVehiclesList.Add(new Car(4, 29, EnumClass.eFuelType.Octan95, 48));
            m_SupportedVehiclesList.Add(new Car(4, 29, 2.6f));
            m_SupportedVehiclesList.Add(new Truck(16, 25, EnumClass.eFuelType.Soler, 130));

        }
        private Vehicle getFromSupportedVehicles(int i)
        {
            return m_SupportedVehiclesList[i];
           
        }
        public List<Vehicle> SupportedVehiclesList { get;}

        public void addVehicleToGarage(Vehicle i_Vehicle,string i_OwnerName, string i_OwnerPhoneNumber)
        {
            VehicleInGarage vehicleToAdd = GetVehicleInGarage(i_Vehicle);
            if (vehicleToAdd == null)
            {
                VehicleInGarage vehicleInGarage = new VehicleInGarage(i_Vehicle, i_OwnerName, i_OwnerPhoneNumber);
                m_VehiclesInGarage.Add(vehicleInGarage);
            }
            else
            {
                vehicleToAdd.CarStatus = EnumClass.eVehicleStatus.InRepair;
            }
            
        }

        private VehicleInGarage GetVehicleInGarage(Vehicle i_Vehicle)
        {
            VehicleInGarage vehicleExist = null;
            if(m_VehiclesInGarage.Count > 0 && m_VehiclesInGarage != null)
            {
                vehicleExist = GetVehicleInGarageByLicenseNumber(i_Vehicle.LicenseNumber);
            }
            return vehicleExist;
        }


        public List<string> GetLicenseNumbersByVehicleStatus(EnumClass.eVehicleStatus i_FilterVehicleStatus = EnumClass.eVehicleStatus.NoStatus)
        {
            List<string> licenseNumberList = new List<string>();
            foreach (VehicleInGarage vehicleInGarage in m_VehiclesInGarage)
            {
                if (i_FilterVehicleStatus == EnumClass.eVehicleStatus.NoStatus)
                {
                    licenseNumberList.Add(vehicleInGarage.Vehicle.LicenseNumber);
                }
                else if (i_FilterVehicleStatus == vehicleInGarage.CarStatus)
                {
                    licenseNumberList.Add(vehicleInGarage.Vehicle.LicenseNumber);
                }
            }
            return licenseNumberList;
        }

        public void ChangeStatus(string i_LicenseNumber, EnumClass.eVehicleStatus i_NewStatus)
        {
            GetVehicleInGarageByLicenseNumber(i_LicenseNumber).CarStatus = i_NewStatus;

        }
        private VehicleInGarage GetVehicleInGarageByLicenseNumber(string i_LiceseNumber)
        {
            VehicleInGarage vehicle = null;
            foreach (VehicleInGarage vehicleInGarage in m_VehiclesInGarage)
            {
                if (vehicleInGarage.Vehicle.LicenseNumber.Equals(i_LiceseNumber))
                {
                    vehicle = vehicleInGarage;
                }
            }
            if (vehicle != null)
            {
                return vehicle;
            }
            else
            {
                throw new ArgumentException("car does not exist");
            }
        }

        //public List<string> GetInformationRequiredForThisTypeOfVehicle(string i_LicenseNumber)
        //{
        //    List<string> requiredInfo;
        //    Vehicle vehicle = GetVehicleInGarageByLicenseNumber(i_LicenseNumber);
        //    requiredInfo = Vehicle.RequiredInfoForCreation();
        //    return requiredInfo;
        //}

        public void FillMaxAir(string i_LiceseNumber)
        {
            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);
            foreach(Wheel wheel in vehicleInGarage.Vehicle.WheelsList)
            {
                wheel.CurrentAirPressure = wheel.MaxAirPressure;
            }
        }

        public void RefuelVehicle(string i_LiceseNumber, EnumClass.eFuelType i_FuelType, float i_GasAmountToAdd)
        {

            // ---------------------- watch out that we have 2 addFuel methods --------------------------------
            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);
            FuelTank fuelTank = vehicleInGarage.Vehicle.EnergySupply as FuelTank;
            if (fuelTank != null)
            {
                fuelTank.AddFuel(i_GasAmountToAdd, i_FuelType);
            }
            else
            {
                throw new ArgumentException("Picked vehicle is not Fuel powered");
            }
        }
        public void RechargeElectricVehicle(string i_LiceseNumber, float i_GasAmountToAdd)
        {

            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);

            Battery battery = vehicleInGarage.Vehicle.EnergySupply as Battery;
            if(battery != null)
            {
                battery.ChargeBattery(i_GasAmountToAdd);
            }
            else
            {
                throw new ArgumentException("Picked vehicle is not electric powered");
            }
        }

        public StringBuilder VehicleDetailByLiceseNumber(string i_LiceseNumber)
        {
            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);
            StringBuilder detail = new StringBuilder();
            detail = vehicleInGarage.GetInfo();
            return detail;
        }

    }
}
