using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class EnumClass
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
        public enum eFuelType
        {
            Octan95,
            Octan96,
            Octan98,
            Soler
        }

    }
}
