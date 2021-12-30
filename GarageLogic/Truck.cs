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


        public Truck(int i_WheelsNumber, float i_MaxAirPressure, EnumClass.eFuelType i_FuelType, float i_MaxLiterFuelCapacity) :
       base(i_WheelsNumber, i_MaxAirPressure)
        {
            this.EnergySupply = new FuelTank(i_MaxLiterFuelCapacity, i_FuelType);
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
                if (value < 0)
                {
                    throw new ArgumentException("invalid Cargo Vloume");
                }
                else
                {
                    m_CargoVolume = value;
                }
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

        public override void CheckUserInput(string i_UserInput, int i_RequiredIndex)
        {
            bool resultTryParse;
            if (i_RequiredIndex < 4)
            {
                this.CheckUserInputVehicle(i_UserInput, i_RequiredIndex);
            }
            switch (i_RequiredIndex)
            {
                case 4:
                    if (i_UserInput.ToLower() == "yes")
                    {
                        m_IsDrivesRefrigeratedContents = true;
                    }
                    else if (i_UserInput.ToLower() == "no")
                    {
                        m_IsDrivesRefrigeratedContents = false;
                    }
                    else
                    {
                        throw new ArgumentException("Wrong answer entered");
                    }
                    break;
                case 5:
                    float CargoVolume;
                    resultTryParse = float.TryParse(i_UserInput, out CargoVolume);
                    if (!resultTryParse)
                    {
                        throw new FormatException("Wrong Type");
                    }
                    else
                    {
                        this.CargoVolume = CargoVolume;
                    }
                    break;
            }
        }
    }
}
