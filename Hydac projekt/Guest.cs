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
        private string companyName


        public static Guest[] guests = new Guest[4];

        // Constructor
        static Guest()
        {
            guests[0] = new Guest { companyName = "Micro Technic", guestNumber = 1 };
            guests[1] = new Guest { companyName = "Tietgen", guestNumber = 2 };
            guests[2] = new Guest { companyName = "Caverion", guestNumber = 3 };
            guests[3] = new Guest { companyName = "ITforum", guestNumber = 4 };
        }

        public void GuestLogin()
        {
            string input;

            Console.Clear();
            Console.WriteLine("---Gæstelogin---");
            Console.WriteLine();
            Console.Write("Indtast firmanavn: ");
            input = Console.ReadLine();

            foreach (Guest guest in guests)
            {
                if (guest.companyName == input)
                {
                    Booking.CreateBooking(input);
                }
            }
            Console.WriteLine($"Firmanavnet \"{input}\" eksisterer ikke i systemet. Kontakt en administrator.");

        }
    }
}
