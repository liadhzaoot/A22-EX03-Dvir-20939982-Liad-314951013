﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Car : Vehicle
    {
 

        EnumClass.eColor m_CarColor;
        EnumClass.eNumberOfDoors m_NumberOfDoors;

        public Car(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eColor i_CarColor,
            EnumClass.eNumberOfDoors i_NumberOfDoors) : base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_CarColor = i_CarColor;
            m_NumberOfDoors = i_NumberOfDoors;
        }
        public Car(int i_WheelsNumber, float i_MaxAirPressure) :
        base(i_WheelsNumber, i_MaxAirPressure)
        {
        }
        public EnumClass.eColor CarColor
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

        public EnumClass.eNumberOfDoors NumberOfDoors
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

        public override List<string> RequiredInfo()
        {
            List<string> requiredInfo = base.RequiredInfoForVehicle();
            requiredInfo.Add("Please choose color:\n" + EnumClass.GetEnumOptions(typeof(EnumClass.eColor)));
            requiredInfo.Add("Please choose amount of doors:\n" + EnumClass.GetEnumOptions(typeof(EnumClass.eNumberOfDoors)));

            return requiredInfo;
        }

    }
}
