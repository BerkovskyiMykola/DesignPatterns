using DesignPatterns.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    internal class DinerMenu
    {
        const int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT",
            "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day",
            "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese",
            false, 3.05);
            // a couple of other Diner Menu items added here
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can’t add item to menu");
            }
            else
            {
                menuItems[_numberOfItems] = new MenuItem(name, description, vegetarian, price);
                _numberOfItems = _numberOfItems + 1;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
