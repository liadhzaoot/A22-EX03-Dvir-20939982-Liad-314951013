using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{


    interface IGasVehicle
    {
        public enum eGasType
        {
            Octan95,
            Octan96,
            Octan98,
            Soler
        }
        float CurrentLiterGasCapacity { get; set; }

        float MaxLiterGasCapacity { get; set; }

        void AddGas(float i_GasAmountToAdd, );

    }
}
