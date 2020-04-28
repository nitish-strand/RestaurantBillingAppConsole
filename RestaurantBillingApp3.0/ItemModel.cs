using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBillingApp3._0
{
    interface IItemModel
    {
        void Item(int itemId, string typeForD, string typeVegNon, string itemName, int quantity, double rate);
    }

    public class MenuItem : IItemModel
    {
        public int _itemId { get; set; }
        public string _typeForD { get; set; }
        public string _typeVegNon { get; set; }
        public string _itemName { get; set; }
        public int _quantity { get; set; }
        public double _rate { get; set; }

        public void Item(int itemId, string typeForD, string typeVegNon, string itemName, int quantity, double rate)
        {
            _itemId = itemId;
            _typeForD = typeForD;
            _typeVegNon = typeVegNon;
            _itemName = itemName;
            _quantity = quantity;
            _rate = rate;
        }
    }

    public class Menu : MenuItem
    {
        public List<MenuItem> MenuItems = new List<MenuItem>();

        // addmenuitem !
        public void AddMenu(int itemId, string typeForD, string typeVegNon, string itemName, int quantity, double rate)
        {
            MenuItem obj = new MenuItem()
            {
                _itemId = itemId,
                _typeForD = typeForD,
                _typeVegNon = typeVegNon,
                _itemName = itemName,
                _quantity = quantity,
                _rate = rate,
            };

            MenuItems.Add(obj);
        }

        // removemenuitem !
        public void RemoveMenu(int itemId)
        {
            foreach (MenuItem obj in MenuItems)
            {
                if (obj._itemId == itemId)
                {
                    MenuItems.Remove(obj);
                    break;
                }
            }
        }

        public void DisplayMenu()
        {
            foreach (MenuItem obj in MenuItems)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", obj._itemId, obj._typeForD, obj._typeVegNon, obj._itemName, obj._quantity, obj._rate);
            }
        }
    }
}