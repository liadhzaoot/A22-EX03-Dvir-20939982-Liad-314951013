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
