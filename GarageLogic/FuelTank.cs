using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class FuelTank : EnergySupply 
    {
        //private float m_CurrentLiterFuelCapacity;
        //private float m_MaxLiterFuelCapacity;
        private EnumClass.eFuelType m_FuelType;

        public FuelTank(float i_CurrentLiterFuelCapacity, float i_MaxLiterFuelCapacity, EnumClass.eFuelType i_FuelType):
            base(i_CurrentLiterFuelCapacity, i_MaxLiterFuelCapacity)
        {
            //m_CurrentLiterFuelCapacity = i_CurrentLiterFuelCapacity;
            //m_MaxLiterFuelCapacity= i_MaxLiterFuelCapacity;    
            m_FuelType = i_FuelType;
        }
        public FuelTank(float i_MaxLiterFuelCapacity, EnumClass.eFuelType i_FuelType) : base(i_MaxLiterFuelCapacity)
        {
            //m_MaxLiterFuelCapacity = i_MaxLiterFuelCapacity;
            m_FuelType = i_FuelType;

        }

        public EnumClass.eFuelType FuelType
        {
            get { return this.m_FuelType; }
            set { this.m_FuelType = value; }
        }
        //public float CurrentLiterFuelCapacity
        //{
        //    get { return this.m_CurrentLiterFuelCapacity; }
        //    set { this.m_CurrentLiterFuelCapacity = value; }
        //}
        //public float MaxLiterFuelCapacity
        //{
        //    get { return this.m_MaxLiterFuelCapacity; }
        //    set { this.m_MaxLiterFuelCapacity = value; }
        //}

        public void AddFuel(float i_FuelAmountToAdd, EnumClass.eFuelType i_FuelType)
        {
            if (this.FuelType != i_FuelType)
            {
                throw new ArgumentException("invalid fuel type");

            }
            this.addEnergy(i_FuelAmountToAdd);
        }
    }
}
