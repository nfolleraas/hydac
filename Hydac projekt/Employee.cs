using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac_projekt {
    internal class Employee
    {
        int employeeNumber;
        string employeeName;
        string employeeActivity;
        
        public void InitializeEmployee()
        {
            string input;
            bool godkendt = true;

            do 
            {
                Console.Clear();
                Console.Write("Indtast medarbejdernummer: ");
                input = Console.ReadLine();
                if (input.Length != 4)
                {
                    Console.WriteLine("Forkert input. Medarbejdernummer skal være 4 cifre langt");
                    godkendt = false;
                    // Exception handling mangler
                }
                for (int i = 0; i < 4; i++)
                {
                    if (!char.IsDigit(input[i]))
                    {
                        Console.WriteLine("Forkert input. Medarbejdernummer indeholder kun tal");
                        godkendt = false;
                        break;
                    }
                    
                }
            } while (godkendt == false);
            employeeNumber = int.Parse(input);

            do
            {
                Console.Clear();
                godkendt = true;
                Console.Write("Indtast navn: ");
                input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!char.IsLetter(input[i]))
                    {
                        Console.WriteLine("Forkert input. Navn indeholder kun bogstaver");
                        godkendt = false;
                    }
                }

            } while (godkendt == false);
            employeeName = input;

            do
            {
                Console.Clear();
                godkendt = false;
                Console.WriteLine("Vælg rundvisning:");
                Console.WriteLine("1. Rundvisning 1");
                Console.WriteLine("2. Rundvisning 2");
                Console.WriteLine("3. Rundvisning 3");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        employeeActivity = "Rundvisning 1";
                        godkendt = true;
                        break;

                    case "2":
                        employeeActivity = "Rundvisning 2";
                        godkendt = true;
                        break;

                    case "3":
                        employeeActivity = "Rundvisning 3";
                        godkendt = true;
                        break;

                    default:
                        Console.WriteLine("Forkert valg. Prøv igen");
                        break;
                        // gå til input
                }
            } while (godkendt == false);

        }
    }
}
