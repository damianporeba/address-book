using address_book;
using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuService menuService = new MenuService();
            menuService = Initialize(menuService);

            Console.WriteLine("Witaj w aplikacji AdressBook!");
           

            while (true)
            {
                Console.WriteLine("Wybierz numer akcji którą chcesz wykonać:");
                var mainMenu = menuService.GetMenuActionsByMenuType("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].MenuId}. {mainMenu[i].MenuName}");
                }

            string choice = Console.ReadLine();
        
            Console.WriteLine("You have chosen option number:"+choice);
        }

        private static MenuService Initialize(MenuService menuService)
        {
            menuService.AddNewAction(1, "Dodaj numer", "Main");
            menuService.AddNewAction(2, "Usuń numer", "Main");
            menuService.AddNewAction(3, "Pokaż szczegóły numeru", "Main");
            menuService.AddNewAction(4, "Lista numerów", "Main");
            return menuService;
        }
    }
}