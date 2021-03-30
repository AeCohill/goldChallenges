using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
   public class Menu_Repository
    {

        //Met"Gods" aka. Methods
        private List<Menu> _menuOrders = new List<Menu>();

        //add method
        public void AddItemToMenu(Menu menu)
        {
            _menuOrders.Add(menu);
        }

        //Print current menu
        public List<Menu> GetMenuItems()
        {
            return _menuOrders;
        }
        //delete menu items
        public bool DeleteFromMenu(int itemID)
        {
            Menu item = GetItemID(itemID);
            if (item == null)
            { 
                return false;
            }
            int initialCount = _menuOrders.Count;
            _menuOrders.Remove(item);
            if (initialCount > _menuOrders.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //helper
        //GetItemByID
        public Menu GetItemID(int itemID)
        {
            foreach (Menu item in _menuOrders)
            {
                if (item.MealNum==itemID)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
