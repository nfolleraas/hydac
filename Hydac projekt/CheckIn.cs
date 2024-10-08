using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class CheckIn
    {
        public string CheckInEmployee { get; set; }
        public int CheckId { get; set; } = 0;
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public int GuestCount { get; set; }
        public string PhoneNumber { get; set; }

        public string input;

        public DateTime StartTime { get; set; }
        public DateTime EndTime {  get; set; }

        public bool SafetyCheck { get; set; }
        public static List<CheckIn> checkIns = new List<CheckIn>();
        
        
        public void UpdateCheckIn(CheckIn CheckIn, Employee employee)
        {
            bool IsOkay = true;
            do
            {
                Console.WriteLine("Update Checkin");
                Console.WriteLine();
                Console.Write("Indtast navn på den gæst du vil håndtere: ");
                input = Console.ReadLine() ?? "";

                CheckIn? valgCheckIn = checkIns.FirstOrDefault(checkin => checkin.CompanyName == input);

                if (valgCheckIn != null)
                {
                    CheckIn.CheckInEmployee = employee.EmployeeName;
                    IsOkay = true;
                }
                else
                {
                    Console.WriteLine("Forkert indput, ingen gæst med dette navn");
                    IsOkay = false;
                }
            } while (IsOkay);
        } 
    }

}
