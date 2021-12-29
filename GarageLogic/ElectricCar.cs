using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class ElectricCar : Car
    {
        private Battery m_Battery;

        public ElectricCar(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eColor i_CarColor,
            EnumClass.eNumberOfDoors i_NumberOfDoors, float i_BatteryHourRemaning, float i_MaxHourBattery)
            : base(i_ModelName, i_LicenseNumber, i_WheelsNumber, i_CarColor, i_NumberOfDoors)

        {
            m_Battery = new Battery(i_BatteryHourRemaning, i_MaxHourBattery);
        }
        public ElectricCar(int i_WheelsNumber, float i_MaxAirPressure, float i_MaxHourBattery) :
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

        public override List<string> GetStringListOfPrpeties()
        {
            List<string> listOfProperties = new List<string>();
            listOfProperties.Add("model name");
            listOfProperties.Add("license number");
            listOfProperties.Add("color");
            listOfProperties.Add("number of doors");
            listOfProperties.Add("battary hour remaining");
            return listOfProperties;
        }
    }
}

