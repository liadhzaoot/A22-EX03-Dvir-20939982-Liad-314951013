using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class Wheel
    {
        private string m_ManufactureName;
        private float m_CurrentAirPressure;
        private float m_MaxAirPressure;

        public Wheel(string i_ManufactureName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            this.m_ManufactureName = i_ManufactureName;
            this.m_CurrentAirPressure = i_CurrentAirPressure;
            this.m_MaxAirPressure = i_MaxAirPressure;
        }
        public Wheel(float i_MaxAirPressure)
        {
            this.m_MaxAirPressure = i_MaxAirPressure;
        }
        public void AirInflation(float i_AddAir)
        {
            float newAirPressure = i_AddAir + this.m_CurrentAirPressure;
            if (newAirPressure <= this.m_MaxAirPressure)
                m_CurrentAirPressure = newAirPressure;

        }

        public string ManufactureName
        { 
            get 
            {
                return m_ManufactureName;
            }
            set 
            {
                if (value != string.Empty && !value.StartsWith(" "))
                {
                    m_ManufactureName = value.Trim();
                }
                else
                {
                    throw new ArgumentException("Manufacture name entered is not valid");
                }
            }
        }
        public float CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }
            set
            {
                if (value > this.MaxAirPressure || value < 0)
                {
                    throw new ValueOutOfRangeException(0,this.MaxAirPressure);
                }
                else
                {
                    m_CurrentAirPressure = value;
                }
            }
        }
        public float MaxAirPressure
        {
            get
            {
                return m_MaxAirPressure;
            }
            set
            {
                m_MaxAirPressure = value;
            }
        }

        public  List<string> RequiredInfo()
        {
            List<string> requiredInfo = new List<string>();

            requiredInfo.Add("Please enter the manifacture name of the wheels:");
            requiredInfo.Add(string.Format("Please enter current air pressure of the wheels (maximum: {0}):", m_MaxAirPressure));

            return requiredInfo;
        }
        public StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Air Pressure = " + this.MaxAirPressure + "\n");
            info.Append("Manufacture Name = " + this.ManufactureName + "\n");
            return info;
        }
    }
}
