using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class VehicleInGarage
    {
        private Vehicle m_VehicleInGarage;
        private string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private EnumClass.eVehicleStatus m_CarStatus;
         
        public VehicleInGarage(Vehicle i_VehicleInGarage, 
            string i_OwnerName, 
            string i_OwnerPhoneNumber)
        {
            this.m_CarStatus = EnumClass.eVehicleStatus.InRepair; // default InRepair
            this.m_VehicleInGarage = i_VehicleInGarage;
            this.m_OwnerName = i_OwnerName;
            this.m_OwnerPhoneNumber = i_OwnerPhoneNumber;
        }

        public VehicleInGarage()
        {

        }


        public EnumClass.eVehicleStatus CarStatus
        {
            get
            {
                return m_CarStatus;
            }
            set
            {
                m_CarStatus = value;
            }
        }

        public void CheckUserInputVehicle(string i_UserInput, int i_RequiredIndex)
        {
            bool resultTryParse;
            if (i_RequiredIndex < 6)
            {
                Vehicle.CheckUserInput(i_UserInput, i_RequiredIndex);
            }

            switch (i_RequiredIndex)
            {
                case 6:
                    this.OwnerName = i_UserInput;
                    break;
                case 7:
                    this.OwnerPhoneNumber = i_UserInput;
                    break;
            }

        }

        public virtual List<string> RequiredInfoForVehicleInGarage()
        {
            List<string> requiredInfo;
            requiredInfo = this.Vehicle.RequiredInfo();
            requiredInfo.Add("Please enter owner name:");
            requiredInfo.Add("Please enter owner phone number:");
            return requiredInfo;
        }

        public string OwnerName
        {
            get
            {
                return m_OwnerName;
            }
            set
            {
                m_OwnerName = value;
            }
        }

        

        public string OwnerPhoneNumber
        {
            get
            {
                return m_OwnerPhoneNumber;
            }
            set
            {
                m_OwnerPhoneNumber = value;
            }
        }
        public Vehicle Vehicle
        {
            get
            {
                return m_VehicleInGarage;
            }
            set
            {
                m_VehicleInGarage = value;
            }
        }

        public StringBuilder GetInfo()
        {
            StringBuilder info = new StringBuilder();
            info = this.Vehicle.GetInfo();
            info.Append("Owner Name = " + this.OwnerName + "\n");
            info.Append("Car Status = " + this.CarStatus.ToString() + "\n");
            return info;

        }

    }
}
