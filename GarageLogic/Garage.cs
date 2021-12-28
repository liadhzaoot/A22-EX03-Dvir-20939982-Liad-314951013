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
        public Garage(List<VehicleInGarage> i_Vehicles)
        {
            this.m_VehiclesInGarage = i_Vehicles;
        }
        public Garage()
        {
            m_VehiclesInGarage = new List<VehicleInGarage>();
        }

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
            try
            {
                GetVehicleInGarageByLicenseNumber(i_LicenseNumber).CarStatus = i_NewStatus;
            }
            catch 
            {
                throw new NullReferenceException("car does not exist");
            }
        }
        private VehicleInGarage GetVehicleInGarageByLicenseNumber(string i_LiceseNumber)
        {
            VehicleInGarage vehicle = null;
            foreach (VehicleInGarage vehicleInGarage in m_VehiclesInGarage)
            {
                if(vehicleInGarage.Vehicle.LicenseNumber.Equals(i_LiceseNumber))
                {
                    vehicle = vehicleInGarage;
                }
            }
            return vehicle;
        }

        public void FillMaxAir(string i_LiceseNumber)
        {
            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);
            foreach(Wheel wheel in vehicleInGarage.Vehicle.WheelsList)
            {
                wheel.CurrentAirPressure = wheel.MaxAirPressure;
            }
        }

        public void RefuelGasVehicle(string i_LiceseNumber, EnumClass.eFuelType i_FuelType, float i_GasAmountToAdd)
        {

            // ---------------------- watch out that we have 2 addFuel methods --------------------------------
            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);

            RegularBike regularBike = vehicleInGarage.Vehicle as RegularBike;
            if(regularBike != null)
            {
                regularBike.AddFuel(i_GasAmountToAdd, i_FuelType);
            }
            else
            {
                RegularCar regularCar = vehicleInGarage.Vehicle as RegularCar;
                if (regularCar != null)
                {
                    regularCar.AddFuel(i_GasAmountToAdd, i_FuelType);
                }
            }
             
        }
        public void RechargeElectricVehicle(string i_LiceseNumber, float i_GasAmountToAdd)
        {

            // ---------------------- watch out that we have 2 addFuel methods --------------------------------
            VehicleInGarage vehicleInGarage = GetVehicleInGarageByLicenseNumber(i_LiceseNumber);

            ElectricBike regularBike = vehicleInGarage.Vehicle as ElectricBike;
            if (regularBike != null)
            {
                regularBike.ChargeBattery(i_GasAmountToAdd);
            }
            else
            {
                ElectricCar regularCar = vehicleInGarage.Vehicle as ElectricCar;
                if (regularCar != null)
                {
                    regularCar.ChargeBattery(i_GasAmountToAdd);
                }
            }

        }

    }
}
