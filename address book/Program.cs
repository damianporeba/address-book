using address_book;
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

            string operation = Console.ReadLine();
        
            Console.WriteLine("You have chosen option number:"+operation);

            int chosenOperation = 0;

            Int32.TryParse(operation, out chosenOperation);
            
            
            
            Console.WriteLine("Please, select item category");
            Console.WriteLine("1. Default");
            Console.WriteLine("2. Family");
            Console.WriteLine("3. Friend");
            Console.WriteLine("4. Other");

            string category = Console.ReadLine();

            ItemType chosenCategory; 

            Int32.TryParse(choice, out choosenOption);
            
        }

    }
}