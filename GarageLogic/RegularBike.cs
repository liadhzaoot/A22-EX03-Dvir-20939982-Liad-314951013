using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class RegularBike : Bike
    { 
        private FuelTank m_FuelTank;
        public RegularBike(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eLicenseType i_LicenseType,
            int i_EngineCapacity, float i_CurrentLiterFuelCapacity,
                float i_MaxLiterFuelCapacity, EnumClass.eFuelType i_FuelType) 
            : base(i_ModelName, i_LicenseNumber, i_WheelsNumber, i_LicenseType, i_EngineCapacity)
        {
            m_FuelTank = new FuelTank(i_CurrentLiterFuelCapacity, i_MaxLiterFuelCapacity, i_FuelType);
        }
        public EnumClass.eFuelType FuelType
        {
            get { return this.m_FuelTank.FuelType; }
            set { this.m_FuelTank.FuelType = value; }
        }
        public float CurrentLiterGasCapacity
        {
            get { return this.m_FuelTank.CurrentLiterFuelCapacity; }
            set { this.m_FuelTank.CurrentLiterFuelCapacity = value; }
        }
        public float MaxLiterGasCapacity
        {
            get { return this.m_FuelTank.MaxLiterFuelCapacity; }
            set { this.m_FuelTank.MaxLiterFuelCapacity = value; }
        }

        public void AddFuel(float i_GasAmountToAdd, EnumClass.eFuelType i_GasType)
        {
            this.m_FuelTank.AddFuel(i_GasAmountToAdd, i_GasType);
        }

        public override List<string> GetStringListOfPrpeties()
        {
            List<string> listOfProperties = new List<string>();
            listOfProperties.Add("model name");
            listOfProperties.Add("license number");
            listOfProperties.Add("license type");
            listOfProperties.Add("engine capacity");
            listOfProperties.Add("current fuel remaining");
            return listOfProperties;
        }
    }
}
