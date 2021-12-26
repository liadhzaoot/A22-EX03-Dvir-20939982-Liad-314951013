using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class RegularBike : Bike, IGasVehicle
    {
        private float m_CurrentLiterGasCapacity;
        private float m_MaxLiterGasCapacity;  
        private EnumClass.eGasType m_GasType;
        public RegularBike(float i_CurrentLiterGasCapacity, float i_MaxLiterGasCapacity, EnumClass.eGasType i_GasType)
        { 
            this.m_CurrentLiterGasCapacity = i_CurrentLiterGasCapacity;
            this.m_MaxLiterGasCapacity = i_MaxLiterGasCapacity;   
            this.m_GasType = i_GasType;
        }
        public EnumClass.eGasType GasType 
        { 
            get { return this.m_GasType; } 
            set { this.m_GasType = value; } 
        }
        public float CurrentLiterGasCapacity 
        {
            get { return this.m_CurrentLiterGasCapacity; }
            set { this.m_CurrentLiterGasCapacity = value; }
        }
        public float MaxLiterGasCapacity 
        {
            get { return this.m_MaxLiterGasCapacity; }
            set { this.m_MaxLiterGasCapacity = value; }
        }

        public void AddGas(float i_GasAmountToAdd, EnumClass.eGasType i_GasType)
        {
            if (this.CurrentLiterGasCapacity + i_GasAmountToAdd <= this.MaxLiterGasCapacity && this.GasType == i_GasType)
            {
                this.CurrentLiterGasCapacity += i_GasAmountToAdd;
            }
        }
    }
}
