using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_IsDrivesRefrigeratedContents;
        private float m_CargoVolume;

        public Truck(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, 
            bool i_IsDrivesRefrigeratedContents, float i_CargoVolume) : 
            base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_CargoVolume = i_CargoVolume;
            m_IsDrivesRefrigeratedContents = i_IsDrivesRefrigeratedContents;
        }
        public Truck(int i_WheelsNumber, float i_MaxAirPressure) :
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


        public override List<string> RequiredInfo()
        {
            List<string> requiredInfo = base.RequiredInfoForVehicle();
            requiredInfo.Add("Is the truck carrying refrigerated contents?\n" +  "yes or no :");
            requiredInfo.Add("Please enter truck's cargo volume:");
            return requiredInfo;
        }

        public override StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info = this.GetVehicleInfo();
            info.Append("Is drives refrigerated contents = " + this.IsDrivesRefrigeratedContents);
            info.Append("Cargo Volume = " + this.CargoVolume);
            return info;
        }

    }
}
