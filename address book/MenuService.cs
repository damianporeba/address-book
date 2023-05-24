using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace address_book
{
    public class MenuService
    {

        private List<Menu> menu;
        public MenuService()
        {
            menu = new List<Menu>();
        }

        public void AddNewAction(int menuId, string menuName, string menuType)
        {
            Menu menuAction = new Menu(menuName, menuId) {MenuType = menuType};
            menu.Add(menuAction);
        }

        public List<Menu> GetMenuActionsByMenuType(string menuType)
        {
            List<Menu> result = new List<Menu>();
            foreach (var menuAction in menu)
            {
                if (menuAction.MenuType == menuType)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

        
    }
}
        

