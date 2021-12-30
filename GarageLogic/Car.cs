using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class Car : Vehicle
    {


        private EnumClass.eColor m_CarColor;
        private EnumClass.eNumberOfDoors m_NumberOfDoors;

        public Car(string i_ModelName, string i_LicenseNumber, int i_WheelsNumber, EnumClass.eColor i_CarColor,
            EnumClass.eNumberOfDoors i_NumberOfDoors) : base(i_ModelName, i_LicenseNumber, i_WheelsNumber)
        {
            m_CarColor = i_CarColor;
            m_NumberOfDoors = i_NumberOfDoors;
        }

        // fuel engine
        public Car(int i_WheelsNumber, float i_MaxAirPressure,EnumClass.eFuelType i_FuelType, float i_MaxLiterFuelCapacity) :
        base(i_WheelsNumber, i_MaxAirPressure)
        {
            this.EnergySupply = new FuelTank(i_MaxLiterFuelCapacity, i_FuelType);
        }
        // battery engine
        public Car(int i_WheelsNumber, float i_MaxAirPressure, float i_MaxLiterFuelCapacity) :
        base(i_WheelsNumber, i_MaxAirPressure)
        {
            this.EnergySupply = new Battery(i_MaxLiterFuelCapacity);
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

        public override StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info = this.GetVehicleInfo();
            info.Append(this.EnergySupply.GetInfo());
            info.Append("Car Color = " + this.CarColor.ToString());
            info.Append("Number Of Doors = " + this.NumberOfDoors.ToString());
            return info;
        }

        public override List<string> GetStringListOfPrpeties()
        {
            throw new NotImplementedException();
        }
    }
}
