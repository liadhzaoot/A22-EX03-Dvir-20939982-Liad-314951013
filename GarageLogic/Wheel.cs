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
                m_ManufactureName = value;
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
                m_CurrentAirPressure = value;
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
        public StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Air Pressure = " + this.MaxAirPressure);
            info.Append("Manufacture Name = " + this.ManufactureName);
            return info;
        }
    }
}
