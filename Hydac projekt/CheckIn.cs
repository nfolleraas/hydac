using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class CheckIn
    {
        private int CheckId { get; set; } = 0;
        private int GuestCount { get; set; }

        private string CompanyName { get; set; }
        private string ContactPerson { get; set; }
        private string PhoneNumber { get; set; }
        private string input;

        private DateTime StartTime { get; set; }
        private DateTime EndTime {  get; set; }

        private bool SafetyCheck { get; set; }
        private bool isOkay;


        public static List<CheckIn> checkIns = new List<CheckIn>();

        public void UpdateCheckIn()
        {
            Console.WriteLine("Update Checkin");
            Console.WriteLine();
            Console.Write("Indtast navn på den gæst du vil håndtere: ");
            input = Console.ReadLine() ?? "";

            foreach ()
        }
    }

}
