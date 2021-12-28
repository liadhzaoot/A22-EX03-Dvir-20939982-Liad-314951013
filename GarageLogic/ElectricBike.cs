using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class ElectricBike : Bike
    {
        private Battery m_Battery;

        public ElectricBike(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eLicenseType i_LicenseType,
            int i_EngineCapacity, float i_BatteryHourRemaning, float i_MaxHourBattery)
            : base(i_ModelName, i_LicenseNumber, i_WheelsNumber, i_LicenseType, i_EngineCapacity)

        {
            m_Battery = new Battery(i_BatteryHourRemaning, i_MaxHourBattery);
        }
        public ElectricBike(int i_WheelsNumber, float i_MaxAirPressure, float i_MaxHourBattery) :
            base(i_WheelsNumber, i_MaxAirPressure)
        {
            m_Battery = new Battery(i_MaxHourBattery);

        }

        public float BatteryHourRemaning
        {
            get
            {
                return m_Battery.BatteryHourRemaning;
            }
            set
            {
                m_Battery.BatteryHourRemaning = value;
            }
        }
        public float MaxHourBattery
        {
            get
            {
                return m_Battery.MaxHourBattery;
            }
            set
            {
                m_Battery.MaxHourBattery = value;
            }
        }

        public void ChargeBattery(float i_AddElectricity)
        {
            m_Battery.ChargeBattery(i_AddElectricity);
        }
    }
}
