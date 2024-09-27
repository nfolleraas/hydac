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
        public string chosenEmployee;

        public static Booking[] bookings = new Booking[4];

        public void CreateBooking(string companyName,Booking booking)
        {

            bookingId++;
            booking.bookingId = bookingId;
            booking.startTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");

            Console.WriteLine("---Booking---");
            Console.WriteLine();
            Console.WriteLine($"Velkommen {companyName}");

            Console.Write("Vælg din kontakt person: ");
            contactPerson = Console.ReadLine();

            Employee employee = new Employee();

            employee.ChooseEmployee(Booking booking);
            Console.WriteLine(

            Console.ReadKey();

            // TODO
            //fix output på chooseEmployee 

        }
    }

}
