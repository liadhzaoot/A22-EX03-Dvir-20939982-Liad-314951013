using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{

    public class Bike : Vehicle
    {

        private EnumClass.eLicenseType m_LicenseType;
        private int m_EngineCapacity;

        public Bike(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eLicenseType i_LicenseType, 
            int i_EngineCapacity):base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_LicenseType = i_LicenseType;
            m_EngineCapacity = i_EngineCapacity;
        }


        // fuel engine
        public Bike(int i_WheelsNumber, float i_MaxAirPressure, EnumClass.eFuelType i_FuelType, float i_MaxLiterFuelCapacity) :
        base(i_WheelsNumber, i_MaxAirPressure)
        {
            this.EnergySupply = new FuelTank(i_MaxLiterFuelCapacity, i_FuelType);
        }
        // battery engine
        public Bike(int i_WheelsNumber, float i_MaxAirPressure, float i_MaxLiterFuelCapacity) :
        base(i_WheelsNumber, i_MaxAirPressure)
        {
            this.EnergySupply = new Battery(i_MaxLiterFuelCapacity);
        }
        //public Bike(int i_EngineCapacity,
        //            EnumClass.eLicenseTypes i_LicenseTypes,
        //            string i_ModwelName,
        //            string i_LicenseNumber,
        //            float i_EnergyPrecentage,
        //            List<Wheel> i_WheelList)
        //{
        //    this.m_EngineCapacity = i_EngineCapacity;
        //    this.m_LicenseTypes = i_LicenseTypes;
        //}
        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
            set
            {
                if(m_EngineCapacity <= 0)
                {
                    throw new ArgumentException("invalid engine capacity");
                }
                else
                    m_EngineCapacity = value;
            }
        }

        public EnumClass.eLicenseType LicenseType
        {
            get
            {
                return m_LicenseType;
            }
            set
            {
                if (Enum.IsDefined(typeof(EnumClass.eFuelType), value) == false)
                {
                    throw new ArgumentException("License type not valid");
                }
                else
                {
                    m_LicenseType = value;
                }
            }
        }

        public override StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info = this.GetVehicleInfo();
            info.Append(this.EnergySupply.GetInfo());
            info.Append("License Type = " + this.LicenseType.ToString());
            info.Append("Engine Capacity = " + this.EngineCapacity.ToString());
            return info;

        }
       public override List<string> RequiredInfo()
        {
            List<string> requiredInfo = base.RequiredInfoForVehicle();
            requiredInfo.Add("Please choose license type:\n "  + EnumClass.GetEnumOptions(typeof(EnumClass.eLicenseType)));
            requiredInfo.Add("Please enter engine capacity:");

            return requiredInfo;
        }

        public override void CheckUserInput(string i_UserInput, int i_RequiredIndex)
        {
            if(i_RequiredIndex < 4)
            {
                this.CheckUserInputVehicle(i_UserInput, i_RequiredIndex);
            }
            else
            {
                bool resultTryParse;
                switch (i_RequiredIndex)
                {
                    case 4:
                        int licenseType;
                        resultTryParse = int.TryParse(i_UserInput, out licenseType);
                        if (!resultTryParse)
                        {
                            throw new FormatException("Wrong Type");
                        }
                        else
                        {
                            this.LicenseType = (EnumClass.eLicenseType)licenseType;
                        }
                        break;
                    case 5:
                        int engineCapacity;
                        resultTryParse = int.TryParse(i_UserInput, out engineCapacity);
                        if (!resultTryParse)
                        {
                            throw new FormatException("Wrong Type");
                        }
                        else
                        {
                            this.EngineCapacity = engineCapacity;
                        }
                        break;
                }
            }
        }
    }
}
