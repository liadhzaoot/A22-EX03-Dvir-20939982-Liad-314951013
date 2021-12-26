using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_EnergyPrecentage;
        List<Wheel> m_WheelsList;

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
    }
}
