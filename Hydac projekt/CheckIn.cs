using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt
{
    public class CheckIn
    {
        private int CheckId = 0;
        private int guestCount;
        private string startTime;
        private DateTime endTime;
        private bool safetyCheck;
        public string contactPerson;
        public string chosenEmployee;

        public static List<CheckIn> checkIns = new List<CheckIn>();

        public void CreateCheckIn(string companyName,CheckIn checkIns)
        {
            bool isOkay;
            CheckId++;
            checkIns.CheckId = CheckId;
            checkIns.startTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");

            Console.WriteLine("---Check In---");
            Console.WriteLine();
            Console.WriteLine($"Velkommen {companyName}");

            Console.Write("Vælg din kontakt person: ");
            contactPerson = Console.ReadLine();

            Console.Write("Hvor mange er i ankommet?: ");
            string input = Console.ReadLine();

            do
            {
                if (input.All(char.IsDigit))
                {
                    guestCount = int.Parse(input);
                    isOkay = true;
                }
                else
                {
                    Console.WriteLine("Indtastet værdi må kun være tal");
                    isOkay = false;
                }
            } while (isOkay);

            // TODO
            //fix output på chooseEmployee 

        }
    }

}
