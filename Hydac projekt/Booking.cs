using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class Booking
    {
        private int bookingId = 0;
        private int guestCount;
        private string startTime;
        private DateTime endTime;
        private bool safetyCheck;
        public string contactPerson;

        public static Booking[] bookings = new Booking[4];

        public void CreateBooking(string companyName)
        {
            Booking booking = new Booking();

            bookingId++;
            Console.WriteLine("---Booking---");
            Console.WriteLine();
            Console.WriteLine($"Velkommen {companyName}");
            startTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            Console.WriteLine(startTime);

            // TODO
            // Gemme oplysningerne i array
            // addet starttime
            // addet guestcount
        }
    }

}
