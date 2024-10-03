namespace Hydac_projekt
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string input;
            bool isRunning = true;
            
            Employee.employees.Add(new Employee() { EmployeeName = "Kasper", EmployeeNumber = 1, Team = "Montage", Password = "and" });
            Employee.employees.Add(new Employee() { EmployeeName = "Daniel", EmployeeNumber = 2, Team = "Salg", Password = "spand" });
            Employee.employees.Add(new Employee() { EmployeeName = "Jesper", EmployeeNumber = 3, Team = "Leder", Password = "fugl" });
            Employee.employees.Add(new Employee() { EmployeeName = "Daniel", EmployeeNumber = 4, Team = "Leder", Password = "cat" });


            // Mainmenu
            do
            {
                Console.Clear();
                Console.WriteLine("Velkommen til Hydac");
                Console.WriteLine();
                Console.WriteLine("1. Tjek ind");
                Console.WriteLine("2. Tjek ud");
                Console.WriteLine("3. Log ind som ansat");
                Console.WriteLine("4. Afslut");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckIn checkIn = new CheckIn();
                        checkIn.CreateCheckIn(checkIn);
                        break;

                    case "2":
                        break;

                    case "3":
                        Employee employee = new Employee();
                        employee.Login();
                        break;

                    case "4":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Forkert input. Prøv igen");
                        break;

                }
            } while (isRunning);
        }
        public void CreateCheckIn(CheckIn checkIn)
        {
            CheckId++;
            Console.WriteLine("---Check In---");
            Console.WriteLine();

            Console.Write("Indtast firmanavn: ");
            input = Console.ReadLine() ?? "";
            checkIn.CompanyName = input;

            Console.Write("Indtast Kontakt person: ");
            input = Console.ReadLine() ?? "";
            checkIn.ContactPerson = input;

            Console.Write("Indtast telefonnummer: ");
            input = Console.ReadLine() ?? "";
            checkIn.PhoneNumber = input;

            do
            {
                Console.WriteLine("hvor mange er i?");
                input = Console.ReadLine();
                try
                {
                    checkIn.GuestCount = int.Parse(input);
                    isOkay = true;
                }
                catch
                {
                    Console.Write("Fejl må kun indeholde tal: ");
                    Console.ReadKey();
                    Console.Clear();
                    isOkay = false;
                }
            } while (isOkay == false);

            checkIn.StartTime = DateTime.Now;

            do
            {
                if (checkIn.GuestCount > 1)
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
                        checkIn.SafetyCheck = true;
                        isOkay = true;
                        break;
                    case "2":
                        checkIn.SafetyCheck = false;
                        isOkay = true;
                        break;
                    default:
                        Console.WriteLine("Tast 1 eller 2: ");
                        Console.ReadKey();
                        Console.Clear();
                        isOkay = false;
                        break;


                }
            } while (isOkay == false);

            Guest guest = new Guest(checkIn.CompanyName, checkIn.ContactPerson, checkIn.PhoneNumber);

            checkIns.Add(new CheckIn());

            Console.WriteLine($"{companyName}, {contactPerson}, {phoneNumber}, {guestCount}, {safetyCheck}");
            Console.ReadKey();

        }
    }
}
