using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_EnergyPrecentage;
        private List<Wheel> m_WheelsList;
        private EnergySupply m_EnergySupply;
        public Vehicle(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_WheelsList = new List<Wheel>(i_WheelsNumber);
        }
        public Vehicle(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnergySupply i_EnergySupply)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_WheelsList = new List<Wheel>(i_WheelsNumber);
            this.m_EnergySupply = i_EnergySupply;
        }
        public Vehicle(int i_WheelsNumber, float i_MaxAirPressure)
        {
            m_WheelsList = new List<Wheel>(i_WheelsNumber);
            for(int i = 0; i< i_WheelsNumber; i++)
            {
                Wheel wheel = new Wheel(i_MaxAirPressure);
                m_WheelsList.Add(wheel);
            }
        }

        public abstract List<string> RequiredInfo();
        public virtual List<string> RequiredInfoForVehicle()
        {
            List<string> energySupplyInformation = this.EnergySupply.RequiredInfo();
            List<string> wheelsInformation = this.WheelsList[0].RequiredInfo();
            List<string> requiredInfo = new List<string>();
            requiredInfo.Add("Please enter vehicle model name:");
            foreach (string info in energySupplyInformation)
            {
                requiredInfo.Add(info);
            }

            foreach (string info in wheelsInformation)
            {
                requiredInfo.Add(info);
            }

            return requiredInfo;
        }

        public string ModelName 
        {
            get
            {
                return m_ModelName;
            }
            set
            {
                if (value != string.Empty)
                {
                    m_ModelName = value.Trim();
                }
                else
                {
                    throw new ArgumentException("Model name entered is not valid");
                }
            }
        }
        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
            set
            {
                m_LicenseNumber = value;
            }
        }
        public float EnergyPrecentage
        {
            get
            {
                return m_EnergyPrecentage;
            }
            set
            {
                m_EnergyPrecentage = value;
            }
        }
        public List<Wheel> WheelsList
        {
            get
            {
                return m_WheelsList;
            }
            set
            {
                m_WheelsList = value;
            }
        }
        public abstract StringBuilder GetInfo();

        public StringBuilder GetVehicleInfo()
        {
            StringBuilder info = new StringBuilder();
            this.EnergySupply.GetInfo();
            info.Append("License Number = " + this.LicenseNumber);
            info.Append("Model Name = " + this.ModelName);
            return info;

        }
        public abstract void CheckUserInput(string i_UserInput, int requiredIndex);
        public void CheckUserInputVehicle(string i_UserInput, int requiredIndex)
        {
            bool resultTryParse;

            switch (requiredIndex)
            {
                case 0: 
                    this.ModelName = i_UserInput;
                    break;
                case 1: 
                    float currentEnergy;
                    resultTryParse = float.TryParse(i_UserInput, out currentEnergy);
                    if (!resultTryParse)
                    {
                        throw new FormatException("Wrong Type");
                    }
                    else
                    {
                        this.EnergySupply.CurrentEnergy = currentEnergy;
                    }
                    break;
                case 2:
                    SetAllWheelsManufacturerName(i_UserInput);
                    break;
                case 3:
                    float airPressure;
                    resultTryParse = float.TryParse(i_UserInput, out airPressure);
                    if (!resultTryParse)
                    {
                        throw new FormatException("Wrong Type");
                    }
                    else
                    {
                        SetAllWheelsAirPressure(airPressure);
                    }
                    break;

            }

        }
        internal void SetAllWheelsManufacturerName(string i_ManufacturerName)
        {
            foreach (Wheel wheel in this.WheelsList)
            {
                wheel.ManufactureName = i_ManufacturerName;
            }
        }

        internal void SetAllWheelsAirPressure(float i_AirPressure)
        {
            foreach (Wheel wheel in this.WheelsList)
            {
                wheel.CurrentAirPressure = i_AirPressure;
            }
        }
        public EnergySupply EnergySupply { get; set; }
        //public abstract void AddGas(float i_GasAmountToAdd, EnumClass.eFuelType i_GasType);
    }
}
