using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class Guest
    {
        private int guestNumber;
        public int GuestNumber { get; set; }
        private string companyName;
        public string CompanyName { get; set; }
        private string phoneNumber;
        public string PhoneNumber { get; set; }

        public static List<Guest> guests = new List<Guest>();

        public void GuestLogin()
        {
            string inputName;
            string inputPhone;

            Console.Clear();
            Console.WriteLine("---Gæste login---");
            Console.WriteLine();
            Console.Write("Indtast firmanavn: ");
            inputName = Console.ReadLine() ?? "";
            Console.Write("Indtast telefonnummer: ");
            inputPhone = Console.ReadLine() ?? "";

            Guest? guest = guests.FirstOrDefault(guest => guest.companyName == inputName && guest.phoneNumber == inputPhone);

            if (guest != null)
            {

            }
            
        }
        
    }
}
