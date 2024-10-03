using Hydac_projekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt 
{
    public class Employee
    {
        public static List<Employee> employees = new List<Employee>();

        public int EmployeeNumber { get; set; }

        public string EmployeeName { get; set; }
        public string Team {  get; set; }
        public string Password { get; set; }

        private bool isOkay;

        public void Login()
        {
            do 
            {
                Console.WriteLine("Log på med Navn og adgangskode");
                Console.Write("Navn: ");
                string inputName = Console.ReadLine();

                Console.Write("adgangskode: ");
                string inputPassword = Console.ReadLine();

                Employee? employee = employees.FirstOrDefault(employee => employee.EmployeeName == inputName && employee.Password == inputPassword);

                if (employee != null)
                {
                    do
                    {
                        Console.WriteLine("---Menu---");
                        Console.WriteLine("1: Færdiggør checkin");
                        Console.WriteLine("2: få liste over gæster");

                        switch (Console.ReadLine())
                        { 
                            case "1":
                                // UpdateCheckIn();
                                isOkay = true;
                                break;
                            case "2":
                                //kør ShowAllGust
                                isOkay = true;
                                break;
                            default:
                                Console.WriteLine("Fejl forkert valg prøv igen");
                                isOkay = true;
                                break;
                        }
                    } while (!isOkay);
                }
                else
                {
                    Console.WriteLine("Forkert input");
                    Console.ReadKey();
                    Console.Clear();
                    isOkay = false;
                }
            } while (isOkay == false);


            /*public int EmployeeLogin(int employeeNumber)
            {
                string input;

                Console.Clear();
                Console.WriteLine("---Medarbejder login---");
                Console.WriteLine();
                Console.Write("Indtast medarbejdernummer: ");
                input = Console.ReadLine();

                foreach (Guest guest in guests)
                {
                    if (guest.companyName == input)
                    {
                        Booking booking = new Booking();
                        booking.CreateBooking(input,booking);
                    }
                }
                Console.WriteLine($"Firmanavnet \"{input}\" eksisterer ikke i systemet. Kontakt en administrator.");
                */
        }
    }
}
