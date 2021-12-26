using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{

    abstract class Bike : Vehicle
    {
        public enum eLicenseTypes
        {
            A,
            A2,
            AA,
            B
        }
        eLicenseTypes m_LicenseTypes;
        int m_EngineCapacity;
        
    }
}
