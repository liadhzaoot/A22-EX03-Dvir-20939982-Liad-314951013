using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class RegularTrack : Truck
    {
        private FuelTank m_FuelTank;
        public RegularTrack(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber,
            float i_CurrentLiterFuelCapacity, float i_MaxLiterFuelCapacity, EnumClass.eFuelType i_FuelType,
            bool i_IsDrivesRefrigeratedContents, float i_CargoVolume) : 
            base(i_ModelName, i_LicenseNumber, i_WheelsNumber,i_IsDrivesRefrigeratedContents,i_CargoVolume)
        {
            m_FuelTank = new FuelTank(i_CurrentLiterFuelCapacity, i_MaxLiterFuelCapacity, i_FuelType);
        }
        public RegularTrack(int i_WheelsNumber, float i_MaxAirPressure, EnumClass.eFuelType i_FuelType, float i_MaxLiterFuelCapacity) :
        base(i_WheelsNumber, i_MaxAirPressure)

        {
            m_FuelTank = new FuelTank(i_MaxLiterFuelCapacity, i_FuelType);
        }

    }
}
