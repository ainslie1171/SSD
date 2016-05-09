using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleTourManagment
{
    class Customer
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string Age;
        public string Email;
        public string Phone;
        public string BikeRegNumber;
        
        public string GetInfo()
        {
            return FirstName + "','" + LastName + "','" + Address + "','" + Age + "','" + Email + "','" + Phone + "','" + BikeRegNumber;
        }
    }
}
