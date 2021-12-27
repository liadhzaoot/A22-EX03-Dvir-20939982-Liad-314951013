using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class RegularCar: Car
    {
        private FuelTank m_FuelTank;
        public RegularCar(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eColor i_CarColor,
            EnumClass.eNumberOfDoors i_NumberOfDoors, float i_CurrentLiterFuelCapacity, 
            float i_MaxLiterFuelCapacity, EnumClass.eFuelType i_FuelType)
            : base(i_ModelName, i_LicenseNumber, i_WheelsNumber, i_CarColor, i_NumberOfDoors)
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
    }
}
