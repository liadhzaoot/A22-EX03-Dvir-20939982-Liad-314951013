using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class Battery
    {
        private float m_BatteryHourRemaning;
        private float m_MaxHourBattery;

        public Battery(float i_BatteryHourRemaning, float i_MaxHourBattery)
        {
            m_BatteryHourRemaning = i_BatteryHourRemaning;
            m_MaxHourBattery = i_MaxHourBattery;
        }

        public float BatteryHourRemaning
        {
            get { return m_BatteryHourRemaning; }
            set { m_BatteryHourRemaning = value; }
        }

        public float MaxHourBattery
        {
            get { return m_MaxHourBattery; }
            set { m_MaxHourBattery = value; }
        }

        public void ChargeBattery(float i_AddElectricity)
        {
            if (this.BatteryHourRemaning + i_AddElectricity <= this.MaxHourBattery)
            {
                this.BatteryHourRemaning += i_AddElectricity;
            }
        }
    }
}
