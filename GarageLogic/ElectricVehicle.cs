using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    interface IElectricVehicle
    {
        float BatteryHourRemaning 
        {
            get;
            set;
        }

        float MaxHourBattery
        {
            get;
            set;
        }
        EnumClass.GasTypeEnum GasType
        {
            get;
            set;
        }

        void ChargeBattery(float i_AddElectricity);
    }
}
