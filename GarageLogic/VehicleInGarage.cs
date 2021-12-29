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
        

    }
}
