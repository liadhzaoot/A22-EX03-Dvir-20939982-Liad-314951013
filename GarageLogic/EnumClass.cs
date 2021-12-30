﻿using System;
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
        public enum eVehicleStatus
        {
            InRepair,
            FixedCar,
            Paid,
            NoStatus
        }
        public enum eFuelType
        {
            Octan95,
            Octan96,
            Octan98,
            Soler
        }

        public enum eVehicleType
        {
            Regular_Bike,
            Electric_Bike,
            Regular_Car,
            Electric_Car,
            Truck
        }

        public static string GetEnumOptions(Type i_EnumType)
        {
            if (!typeof(Enum).IsAssignableFrom(i_EnumType))
            {
                throw new ArgumentException("Value must be enum type");
            }

            string optionsForPick = string.Empty;
            int optionNumber = 1;
            foreach (string type in Enum.GetNames(i_EnumType))
            {
                optionsForPick += "(" + optionNumber.ToString() + ")" + type + " ";
                optionNumber++;
            }

            return optionsForPick;
        }



    }
}
