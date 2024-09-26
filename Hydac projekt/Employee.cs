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

        /*
        public static void Show()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Navn: {employee.employeeName} - ID: {employee.employeeNumber} - Team: {employee.team} - Aktivitet: {employee.activity}");
            }
        }
        */
    }
}
