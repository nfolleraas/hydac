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

            Employee employee = new Employee();
            employee.InitializeEmployee();
        }
    }
}
