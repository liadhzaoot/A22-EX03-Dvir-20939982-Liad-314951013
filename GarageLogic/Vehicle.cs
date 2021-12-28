﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_EnergyPrecentage;
        private List<Wheel> m_WheelsList;

        public Vehicle(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenseNumber;
            m_WheelsList = new List<Wheel>(i_WheelsNumber);
        }
        public Vehicle(int i_WheelsNumber, float i_MaxAirPressure)
        {
            m_WheelsList = new List<Wheel>(i_WheelsNumber);
            for(int i = 0; i< i_WheelsNumber; i++)
            {
                Wheel wheel = new Wheel(i_MaxAirPressure);
                m_WheelsList.Add(wheel);
            }
        }
        public string ModelName 
        {
            get
            {
                return m_ModelName;
            }
            set
            {
                m_ModelName = value;
            }
        }
        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
            set
            {
                m_LicenseNumber = value;
            }
        }
        public float EnergyPrecentage
        {
            get
            {
                return m_EnergyPrecentage;
            }
            set
            {
                m_EnergyPrecentage = value;
            }
        }
        public List<Wheel> WheelsList
        {
            get
            {
                return m_WheelsList;
            }
            set
            {
                m_WheelsList = value;
            }
        }
        //public abstract void AddGas(float i_GasAmountToAdd, EnumClass.eFuelType i_GasType);

    }
}
