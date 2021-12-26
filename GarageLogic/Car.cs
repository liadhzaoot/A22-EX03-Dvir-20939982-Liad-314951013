using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    abstract class Car : Vehicle
    {
        public enum eColor
        {
            Red,
            White,
            Black,
            Blue
        }
        public enum eNumberOfDoors
        {
            Two,
            Three,
            Four,
            Five
        }

        eColor m_CarColor;
        eNumberOfDoors m_NumberOfDoors;

        public eColor CarColor
        {
            get
            {
                return m_CarColor;
            }
            set
            {
                m_CarColor = value;
            }
        }

        public eNumberOfDoors NumberOfDoors
        {
            get
            {
                return m_NumberOfDoors;
            }
            set
            {
                m_NumberOfDoors = value;
            }
        }

    }
}
