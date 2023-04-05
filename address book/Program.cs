using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to adress book app!");
            Console.WriteLine("Please let me know what do you want do:");
            Console.WriteLine("1. Add a new number");
            Console.WriteLine("2. Remove number");
            Console.WriteLine("3. Check a number");
            Console.WriteLine("Check 1, 2 or 3...");

            string choice = Console.ReadLine();
        
            Console.WriteLine("You have chosen option number:"+choice);
        }

    }
}