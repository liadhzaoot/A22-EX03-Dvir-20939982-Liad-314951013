using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class Garage
    {
        private string m_OwnerName;
        private string m_OwnerPhoneNumber;
        private EnumClass.eCarStatus m_CarStatus;
        public EnumClass.eCarStatus CarStatus
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
    }
}
