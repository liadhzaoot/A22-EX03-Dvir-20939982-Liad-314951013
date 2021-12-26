using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{


    interface IGasVehicle
    {
        EnumClass.eGasType GasType { get; set; }
        float CurrentLiterGasCapacity { get; set; }

        float MaxLiterGasCapacity { get; set; }

        void AddGas(float i_GasAmountToAdd, EnumClass.eGasType i_GasType);

    }
}
