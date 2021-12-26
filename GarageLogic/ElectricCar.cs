using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class ElectricCar : Car, IElectricVehicle
    {
        private float m_BatteryHourRemaning;
        private float m_MaxHourBattery;

        public ElectricCar(float i_BatteryHourRemaning,
                            float i_MaxHourBattery,
                            int i_EngineCapacity,
                            EnumClass.eColor i_CarColor,
                            EnumClass.eNumberOfDoors i_NumberOfDoors,
                            string i_ModwelName,
                            string i_LicenseNumber,
                            float i_EnergyPrecentage,
                            List<Wheel> i_WheelList)

        {
            this.m_BatteryHourRemaning = i_BatteryHourRemaning;
            this.m_MaxHourBattery = i_MaxHourBattery;
            this.CarColor = i_CarColor;
            this.NumberOfDoors = i_NumberOfDoors;
            this.ModelName = i_ModwelName;
            this.LicenseNumber = i_LicenseNumber;
            this.EnergyPrecentage = i_EnergyPrecentage;
            this.WheelsList = i_WheelList;
        }

        public float BatteryHourRemaning
        {
            get
            {
                return m_BatteryHourRemaning;
            }
            set
            {
                m_BatteryHourRemaning = value;
            }
        }
        public float MaxHourBattery
        {
            get
            {
                return m_MaxHourBattery;
            }
            set
            {
                m_MaxHourBattery = value;
            }
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

