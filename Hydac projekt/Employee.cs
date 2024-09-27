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
        public string activity;
        

        public static Employee[] employees = new Employee[4];

        // Constructor
        static Employee()
        {
            employees[0] = new Employee { employeeName = "Kasper", employeeNumber = 1, team = "Montage", activity = "Møde" };
            employees[1] = new Employee { employeeName = "Daniel", employeeNumber = 2, team = "Salg", activity = "Ledig" };
            employees[2] = new Employee { employeeName = "Jesper", employeeNumber = 3, team = "Leder", activity = "Ledig" };
            employees[3] = new Employee { employeeName = "Daniel", employeeNumber = 4, team = "Leder", activity = "Ledig" };
        }



        public string ChooseEmployee()
        {
            Employee[] filteredEmployees = new Employee[employees.Length];
            int index = 0;
            int displayIndex = 1;

            foreach (Employee employee in employees)
            {
                
                if (employee.activity == "Ledig")

                filteredEmployees[index] = employee; 

                Console.WriteLine($"{displayIndex}. {employee.employeeName} ");

                index++;
                displayIndex++;
            }

            index = 1;

            Console.WriteLine("Skriv tallet på den ansatte");
            
            int input = int.Parse(Console.ReadLine());
            Employee selectedEmployee = filteredEmployees[index - 1];

            booking.chosenEmployee = selectedEmployee.employeeName;

            return booking.chosenEmployee;
        }

    }
}
