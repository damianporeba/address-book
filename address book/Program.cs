using address_book;
using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuService menuService = new MenuService();
            NumberService numberService = new NumberService();
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

                var operation = Console.ReadKey();

               


                switch (operation.KeyChar)
                {
                    case '1':
                        {
                            var keyInfo = numberService.AddNewNumberMenu(menuService);
                            var id = numberService.AddNewNumber(keyInfo.KeyChar);
                            break;
                        }
                    case '2':
                        { 
                            break;
                        }
                    case '3':
                        {
                            break;
                        }
                    case '4':
                        {
                            break;
                        }
                }







            }

             static MenuService Initialize(MenuService menuService)
            {
                menuService.AddNewAction(1, "Dodaj numer", "Main");
                menuService.AddNewAction(2, "Usuń numer", "Main");
                menuService.AddNewAction(3, "Pokaż szczegóły numeru", "Main");
                menuService.AddNewAction(4, "Lista numerów", "Main");

                menuService.AddNewAction(1, "Ogólny", "NumberMenu");
                menuService.AddNewAction(2, "Rodzina", "NumberMenu");
                menuService.AddNewAction(3, "Praca", "NumberMenu");

                return menuService;
            }
        }
    }
}