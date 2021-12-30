using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class EnergySupply
    {
        private float m_CurrentEnergy;
        private float m_MaxEnergy;

        public EnergySupply(float i_CurrentEnergy, float i_MaxEnergy)
        {
            this.m_CurrentEnergy = i_CurrentEnergy;
            this.m_MaxEnergy = i_MaxEnergy;
        }
        public EnergySupply(float i_MaxEnergy)
        {
            this.m_MaxEnergy = i_MaxEnergy;
        }

        public float CurrentEnergy
        {
            get 
            {
                return this.m_CurrentEnergy; 
            }
            set 
            {
                if (value > this.MaxEnergy || value < 0)
                {
                    throw new ValueOutOfRangeException(0, this.MaxEnergy);
                }
                else
                {
                    this.m_CurrentEnergy = value;
                }
            }
        }
        public float MaxEnergy
        {
            get { return this.m_MaxEnergy; }
            set { this.m_MaxEnergy = value; }
        }

        public void addEnergy(float i_EnergyToAdd)
        {
            if (this.m_CurrentEnergy + i_EnergyToAdd > this.m_MaxEnergy)
            {
                throw new ValueOutOfRangeException(0, this.m_MaxEnergy);
            }
            this.m_CurrentEnergy += i_EnergyToAdd;
        }
        public abstract StringBuilder GetInfo();
        public StringBuilder GetEnergySupplyInfo()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Current Energy = " + this.CurrentEnergy + "\n");
            return info;
        }

        public abstract List<string> RequiredInfo();
        public virtual List<string> RequiredInfoForVehicle()
        {
            List<string> requiredInfo = new List<string>();
            requiredInfo.Add(string.Format("Please enter  current energy left (max: {0}): ", this.MaxEnergy));

            return requiredInfo;
        }


    }
}
