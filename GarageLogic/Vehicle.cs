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
                m_ModelName = value;
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
        public void CheckUserInput(string i_UserInput,int requiredIndex)
        {
            switch (requiredIndex)
            {
                case 0:
                    {
                        
                    }
            }

        }
        public EnergySupply EnergySupply { get; set; }
        //public abstract void AddGas(float i_GasAmountToAdd, EnumClass.eFuelType i_GasType);
    }
}
