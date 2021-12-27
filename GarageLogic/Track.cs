using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    abstract class Track : Vehicle
    {
        bool m_IsDrivesRefrigeratedContents;
        float m_CargoVolume;

        public Track(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, 
            bool i_IsDrivesRefrigeratedContents, float i_CargoVolume) : 
            base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_CargoVolume = i_CargoVolume;
            m_IsDrivesRefrigeratedContents = i_IsDrivesRefrigeratedContents;
        }
        public bool IsDrivesRefrigeratedContents 
        {
            get
            {
                return m_IsDrivesRefrigeratedContents;
            }
            set 
            {
                m_IsDrivesRefrigeratedContents = value;
            }
        }
        public float CargoVolume
        {
            get
            {
                return m_CargoVolume;
            }
            set
            {
                m_CargoVolume = value;
            }
        }
    }
}
