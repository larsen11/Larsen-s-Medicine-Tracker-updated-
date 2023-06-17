using System;

namespace Larsen
{
    class Program
    {
        static DateTime startDate;
        static int numberOfTimes;
        static int gapDays;
        static int count;
        static DateTime currentDate;
        static int medicineCount = 0;
        static int medicineNumber;
        static int numberOfDays;

        static string[] medicineNames =
        {
        "Biogesic",
        "Melatonin",
        "Opthamax",
        "Bioflu",
        "Neozep Forte",
        "Advil",
        "Alaxan",
        "Cherifer",
        "Immunpro",
        "Fern-C"
    };

        static void determineNumberOfMedicines()
        {
            Console.WriteLine();

            Console.WriteLine($"Medicine #{medicineCount + 1}");

            Console.Write("Enter the starting date of your prescribed medicine (dd/MM/yyyy): ");
            startDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("1. Biogesic");
            Console.WriteLine("2. Melatonin");
            Console.WriteLine("3. Opthamax");
            Console.WriteLine("4. Bioflu");
            Console.WriteLine("5. Neozep Forte");
            Console.WriteLine("6. Advil");
            Console.WriteLine("7. Alaxan");
            Console.WriteLine("8. Cherifer");
            Console.WriteLine("9. Immunopro");
            Console.WriteLine("10. Fern-C");
            Console.WriteLine();

            Console.Write("Choose a Medicine: ");
            medicineNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the number of days you need to drink " + medicineNames[medicineNumber - 1] + ": ");
            numberOfDays = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of times you need to drink " + medicineNames[medicineNumber - 1] + " per day: ");
            numberOfTimes = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of days gap between medicine intake: ");
            gapDays = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dates to drink " + medicineNames[medicineNumber - 1] + ":");

            count = 0;
            currentDate = startDate;

            medicineCount++;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Medicine Tracker by Larsen Reyes!");

            Console.Write("Enter the number of medicines you want to track: ");
            int numberOfMedicines = int.Parse(Console.ReadLine());

            for (int x = 0; x < numberOfMedicines; x++)
            {

                determineNumberOfMedicines();

                for (int i = 0; i < numberOfDays; i++)
                {
                    string formattedDate = currentDate.ToString("dd/MM/yyyy");
                    for (int j = 1; j <= numberOfTimes; j++)
                    {
                        Console.WriteLine($"{formattedDate}: Take {medicineNames[medicineNumber - 1]}");
                    }
                    count++;
                    currentDate = currentDate.AddDays(gapDays);
                }

                if (count == 0)
                {
                    Console.WriteLine("No medicine intake days found.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to run the program again or any other key to exit.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}