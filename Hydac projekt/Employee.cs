using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt {
    public class Employee
    {
        private int employeeNumber;
        private string employeeName;
        private string team;
        public string Password;


        public static List<Employee> employees = new List<Employee>();

        // Constructor
        static Employee()
        {
            employees[0] = new Employee { employeeName = "Kasper", employeeNumber = 1, team = "Montage", Password = "and" };
            employees[1] = new Employee { employeeName = "Daniel", employeeNumber = 2, team = "Salg", Password = "spand" };
            employees[2] = new Employee { employeeName = "Jesper", employeeNumber = 3, team = "Leder", Password = "fugl" };
            employees[3] = new Employee { employeeName = "Daniel", employeeNumber = 4, team = "Leder", Password = "cat" };
        }



        public string Login()
        {
            do 
            {
                Console.WriteLine("Log på med Navn og adgangskode");
                Console.Write("Navn: ");
                string inputName = Console.ReadLine();
                Console.Write("adgangskode: ");
                string inputPassword = Console.ReadLine();
                Employee? employee = employees.FirstOrDefault(employee => employee.employeeName == inputName && employee.Password == inputPassword);
                if (employee != null)
                {
                    do
                    {
                        Console.WriteLine("---Menu---");
                        Console.WriteLine("1: log på Checkin");
                        Console.WriteLine("2: få liste over gæester")
                        bool isOkay;
                  switch (Console.ReadLine())
                        { 
                            case "1":
                                //kør updatecheckin
                                isOkay = true;
                                break;
                            case "2":
                                //kør ShowAllGust
                                isOkay = true;
                                break;
                                case "3":
                               isOkay = false;
                                    break;
                            default:
                                Console.WriteLine("Fejl forkert valg prøv igen");
                                isOkay = true;
                                break;
                        }
                    } while (isOkay);
                  }
                else
                {

                }
            } while (true);
            

        }

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

        }*/

    }
}
