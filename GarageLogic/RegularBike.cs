using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class RegularBike : Bike
    {
        private float m_CurrentLiterGasCapacity;
        private float m_MaxLiterGasCapacity;  
        private FuelTank m_Engine;
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

        public FuelTank Engine
        {
            get { return this.m_Engine; }
            set { this.m_Engine = value; }
        }
        public void AddGas(float i_GasAmountToAdd, EnumClass.eGasType i_GasType)
        {
            this.m_Engine.AddGas(i_GasAmountToAdd, i_GasType);
        }
    }
}
