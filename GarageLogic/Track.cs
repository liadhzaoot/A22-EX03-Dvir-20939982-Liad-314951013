﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Track : Vehicle
    {
        private bool m_IsDrivesRefrigeratedContents;
        private float m_CargoVolume;

        public Track(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, 
            bool i_IsDrivesRefrigeratedContents, float i_CargoVolume) : 
            base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_CargoVolume = i_CargoVolume;
            m_IsDrivesRefrigeratedContents = i_IsDrivesRefrigeratedContents;
        }
        public Track(int i_WheelsNumber, float i_MaxAirPressure) :
            base(i_WheelsNumber, i_MaxAirPressure)
        {
        }
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

        public override List<string> GetStringListOfPrpeties()
        {
            List<string> listOfProperties = new List<string>();
            listOfProperties.Add("model name");
            listOfProperties.Add("license number");
            listOfProperties.Add("is drives refrigerated contents");
            listOfProperties.Add("cargo volume");
            return listOfProperties;
        }
    }
}
