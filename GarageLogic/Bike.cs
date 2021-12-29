using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{

    public abstract class Bike : Vehicle
    {

        private EnumClass.eLicenseType m_LicenseType;
        private int m_EngineCapacity;

        public Bike(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eLicenseType i_LicenseType, 
            int i_EngineCapacity):base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_LicenseType = i_LicenseType;
            m_EngineCapacity = i_EngineCapacity;    
        }

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
