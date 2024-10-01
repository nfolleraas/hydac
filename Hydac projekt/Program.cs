﻿namespace Hydac_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isRunning = true;
            
            // Mainmenu
            do
            {
                Console.Clear();
                Console.WriteLine("Velkommen til Hydac");
                Console.WriteLine();
                Console.WriteLine("1. Log ind som ansat");
                Console.WriteLine("2. Log ind som gæst");
                Console.WriteLine("3. Afslut");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateGuest();
                        break;

                    case "2":
                        guest.GuestLogin();
                        break;

                    case "3":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Forkert input. Prøv igen");
                        break;
                        
                }


            } while (isRunning);

            public void CreateGuest()
            {
                int index = 0;
                index++;
                Guest guest = new Guest();
                guest.GuestNumber = index;
                Console.Clear();
                Console.WriteLine("---Opret gæst---");
                Console.WriteLine();
                Console.Write("Indtast firmanavn: ");
                string input = Console.ReadLine() ?? "";
                guest.CompanyName = input;
                Console.Write("Indtast telefonnummer: ");
                input = Console.ReadLine()?? "";
                guest.PhoneNumber = input;
            }
        }
    }
}
