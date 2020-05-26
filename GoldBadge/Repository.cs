using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public class Repository
    {
        private List<Menu> _menuList = new List<Menu>();

        //Create
        public void AddItemsToMenu(Menu menu)
        {
            _menuList.Add(menu);
        }

        //Read
        public List<Menu> GetMenu()
        {
            return _menuList;
        }

        //Update
        public bool UpdateMenu(int MenuNumber, Menu newItem)
        {
            //Find menu item
            Menu oldItem = GetItemByNumber(MenuNumber);

            //Update Menu
            if(oldItem != null)
            {
                oldItem.MenuNumber = newItem.MenuNumber;
                oldItem.Description = newItem.Description;
                oldItem.Ingredients = newItem.Ingredients;
                oldItem.Name = newItem.Name;
                oldItem.Price = newItem.Price;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveItemFromMenu(int MenuNumber)
        {
            Menu item = GetItemByNumber(MenuNumber);

            if (item == null)
            {
                return false;
            }

            int initialCount = _menuList.Count;
            _menuList.Remove(item);

            if(initialCount > _menuList.Count)
            {
                return true;
            }
            else{
                return false;
            }
        }




        //Helper Method
        public Menu GetItemByNumber(int menuNumber)
        {
            foreach(Menu item in _menuList)
            {
                if(item.MenuNumber == menuNumber)
                {
                    return item;
                }
            }

            return null;
        }

        
    }
}
