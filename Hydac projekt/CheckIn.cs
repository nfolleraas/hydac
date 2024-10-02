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
        private DateTime startTime;
        private DateTime endTime;
        private bool safetyCheck;
        public string contactPerson;
        public string chosenEmployee;

        public static List<CheckIn> checkIns = new List<CheckIn>();

        public void CreateCheckIn()
        {
            CheckId++;
            Console.WriteLine("---Check In---");
            Console.WriteLine();
            Console.Write("Indtast firmanavn: ");
            string input = Console.ReadLine() ?? "";
            string companyName = input;
            Console.Write("Indtast Kontakt person: ");
            input = Console.ReadLine() ?? "";
            contactPerson = input;
            Console.Write("Indtast telefonnummer: ");
            input = Console.ReadLine() ?? "";
            string phoneNumber = input;
            bool isokay;
            do
            {

               
                Console.WriteLine("hvor mange er i?");
                input = Console.ReadLine();
                try
                {
                    guestCount = int.Parse(input);
                    isokay = true;
                }
                catch
                {
                    Console.Write("Fejl må kun indeholde tal: ");
                    isokay = false;
                }
            } while(!isokay);
            
            startTime = DateTime.Now;
            do
            {
                if (guestCount > 1)
                {
                    Console.WriteLine("Har i læst sikkerhedsfolderen?: ");
                }
                else
                {
                    Console.WriteLine("Har du læst sikkerhedsfolderen?: ");
                }
                Console.WriteLine("1:Ja ");
                Console.WriteLine("2:Nej ");
                switch (Console.ReadLine())
                {
                    case "1":
                        safetyCheck = true;
                        isokay = true;
                        break;
                    case "2":
                        safetyCheck = false;
                        isokay = true;
                        break;
                    default:
                        Console.WriteLine("Tast 1 eller 2: ");
                        isokay = false;
                        break;


                }
            } while (!isokay);

            Guest guest = new Guest(companyName, contactPerson, phoneNumber);
            // TODO
            //fix output på chooseEmployee 

        }
    }

}
