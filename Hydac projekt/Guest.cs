using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class Guest
    {

        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }

        public static List<Guest> guests = new List<Guest>();

        public Guest(string companyName, string contactPerson, string phoneNumber)
        {
            CompanyName = companyName;
            ContactPerson = contactPerson;
            PhoneNumber = phoneNumber;
        }



    }
}
