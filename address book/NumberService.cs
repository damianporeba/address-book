using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace address_book
{
    public class NumberService
    {

         List<Number> numbers {  get; set; }

        public ConsoleKeyInfo AddNewNumberMenu (MenuService menuService)
        {
            var addNewNumberMenu = menuService.GetMenuActionsByMenuType("NumberMenu");
            Console.WriteLine("Proszę wybierz grupę docelową:");
            for (int i = 0; i < addNewNumberMenu.Count; i++)
            {
                Console.WriteLine($"{addNewNumberMenu[i].MenuId}. {addNewNumberMenu[i].MenuName}");
            }

            var operation = Console.ReadKey();
            return operation;
        }

        public string AddNewNumber (char numberType)
        {
            string numberTypeGroup = Convert.ToString(numberType);
            Number number = new Number();
            number.Group = numberTypeGroup;
            Console.WriteLine("Podaj numer:");
            string numberString = Console.ReadLine();
            Console.WriteLine("Podaj kraj pochodzenia numeru:");
            string countryNumber = Console.ReadLine();

            number.PhoneNumber = numberString;
            number.Country = countryNumber;

            numbers.Add(number);


            


            return id;





        }

    }
}
