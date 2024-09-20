namespace Hydac_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            do
            {
                Console.Clear();
                Console.WriteLine("Velkommen til tjek-ind system");
                Console.Write("Indtast medarbejdernummer: ");

            }
            */
            int input;
            bool isRunning = true;

            Console.Write("Indtast mængden af ansatte du vil oprette: ");
            input = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[input];

            for (int i = 0; i < input; i++)
            {
                employees[i] = new Employee().InitializeEmployee();
            }

            Console.Clear();
            Console.WriteLine($"Du har oprettet {input} ansatte i systemet:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($" - Navn: {employee.employeeName}, ID: {employee.employeeNumber}, Aktivitet: {employee.employeeActivity}");
            }

            Console.ReadKey();
            
            do
            {
                Console.Clear();
                Console.WriteLine("Hent information på medarbejder");
                Console.Write("Indtast ID på den medarbejder du leder efter: ");
                input = int.Parse(Console.ReadLine());
                input = input - 1;

                Console.WriteLine();
                Console.WriteLine($"Medarbejder {input + 1}:");
                Console.WriteLine($"Navn: {employees[input].employeeName}, ID: {employees[input].employeeNumber}, Aktivitet: {employees[input].employeeActivity}");

                Console.WriteLine();
                Console.WriteLine("Tryk for at gå tilbage");
                Console.ReadKey();


            } while (isRunning);


        }
    }
}
