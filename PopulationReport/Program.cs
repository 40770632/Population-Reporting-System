using System;

class Program
{
    static void Main(string[] args)
    {
        DatabaseClass dbHelper = new DatabaseClass();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" Population Reporting System");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. View Countries by Population");
            Console.WriteLine("2. View Top Cities in a Continent");
            Console.WriteLine("3. View Language Speaker Statistics");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
           

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
