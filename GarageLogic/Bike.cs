using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{

    abstract class Bike : Vehicle
    {

        private EnumClass.eLicenseType m_LicenseType;
        private int m_EngineCapacity;

        //public Bike(int i_EngineCapacity,
        //            EnumClass.eLicenseTypes i_LicenseTypes,
        //            string i_ModwelName,
        //            string i_LicenseNumber,
        //            float i_EnergyPrecentage,
        //            List<Wheel> i_WheelList)
        //{
        //    this.m_EngineCapacity = i_EngineCapacity;
        //    this.m_LicenseTypes = i_LicenseTypes;
        //}
        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
            set
            {
                m_EngineCapacity = value;
            }
        }

        public EnumClass.eLicenseType LicenseType
        {
            get
            {
                return m_LicenseType;
            }
            set
            {
                m_LicenseType = value;
            }
        }

    }
}
