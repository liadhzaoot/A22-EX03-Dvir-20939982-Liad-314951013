using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class EnumClass
    {
        public enum eGasType
        {
            Octan98,
            Octan96,
        }

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

        public enum eLicenseType
        {
            A,
            A2,
            AA,
            B
        }
        public enum eCarStatus
        {
            InRepair,
            FixedCar,
            Paid
        }
    }
}
