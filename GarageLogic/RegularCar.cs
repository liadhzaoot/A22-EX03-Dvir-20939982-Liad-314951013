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
        public RegularCar(FuelTank i_FuelTank)
        {
            m_FuelTank = i_FuelTank;
            
        }
        public EnumClass.eGasType GasType
        {
            get { return this.m_FuelTank.GasType; }
            set { this.m_FuelTank.GasType = value; }
        }
        public float CurrentLiterGasCapacity
        {
            get { return this.m_FuelTank.CurrentLiterGasCapacity; }
            set { this.m_FuelTank.CurrentLiterGasCapacity = value; }
        }
        public float MaxLiterGasCapacity
        {
            get { return this.m_FuelTank.MaxLiterGasCapacity; }
            set { this.m_FuelTank.MaxLiterGasCapacity = value; }
        }

        public FuelTank Engine
        {
            get { return this.m_FuelTank; }
            set { this.m_FuelTank = value; }
        }
        public void AddGas(float i_GasAmountToAdd, EnumClass.eGasType i_GasType)
        {
            this.m_FuelTank.AddGas(i_GasAmountToAdd, i_GasType);
        }
    }
}
