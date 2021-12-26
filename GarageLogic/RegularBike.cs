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
            get { throw new NotImplementedException(); } 
            set { throw new NotImplementedException(); } 
        }
        public float CurrentLiterGasCapacity 
        { 
            get { throw new NotImplementedException(); } 
            set { throw new NotImplementedException(); }
        }
        public float MaxLiterGasCapacity 
        {
            get { throw new NotImplementedException(); } 
            set { throw new NotImplementedException(); } 
        }

        public void AddGas(float i_GasAmountToAdd, EnumClass.eGasType i_GasType)
        {
            throw new NotImplementedException();
        }
    }
}
