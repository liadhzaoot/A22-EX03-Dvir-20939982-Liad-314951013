using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class Battery : EnergySupply
    {
        //private float m_BatteryHourRemaning;
        //private float m_MaxHourBattery;

        public Battery(float i_BatteryHourRemaning, float i_MaxHourBattery) : base(i_BatteryHourRemaning,i_MaxHourBattery)
        {
            //m_BatteryHourRemaning = i_BatteryHourRemaning;
            //m_MaxHourBattery = i_MaxHourBattery;
        }
        public Battery( float i_MaxHourBattery):base(i_MaxHourBattery)
        {
            
        }
      

        //public float BatteryHourRemaning
        //{
        //    get { return m_BatteryHourRemaning; }
        //    set { m_BatteryHourRemaning = value; }
        //}

        //public float MaxHourBattery
        //{
        //    get { return m_MaxHourBattery; }
        //    set { m_MaxHourBattery = value; }
        //}

        public void ChargeBattery(float i_AddElectricity)
        {
            this.addEnergy(i_AddElectricity);
        }

        public override StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info = this.GetEnergySupplyInfo();
            return info;
        }
    }
}
