using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class GasEngine
    {
        private float m_CurrentLiterGasCapacity;
        private float m_MaxLiterGasCapacity;
        private EnumClass.eGasType m_GasType;
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
