using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    abstract class EnergySupply
    {
        private float m_CurrentEnergy;
        private float m_MaxEnergy;
        public abstract void AddEnergy(float i_Energy);

        public float CurrentEnergy
        {
            get { return this.m_CurrentEnergy; }
            set { this.m_CurrentEnergy = value; }
        }
        public float MaxEnergy
        {
            get { return this.m_MaxEnergy; }
            set { this.m_MaxEnergy = value; }
        }
    }
}
