using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book
{
    public class Menu
    {
        public string MenuName { get; set; }
        public int MenuId { get; set; }
        public string MenuType { get; set; }



        public Menu (int menuId)
        {
            MenuId = menuId;
        }

        public Menu (string menuName, int menuId)
        {
            MenuName = menuName;
            MenuId = menuId;
        }
    }
}
