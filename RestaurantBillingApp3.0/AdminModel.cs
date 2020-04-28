using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBillingApp3._0
{
    public class AdminModel : Menu, IUsers
    {
        public string UserName;
        public string UserNameAssign(string username)
        {
            UserName = username;
            return UserName;
        }
        public void AdminMenuAdd(Menu objMenu)
        {
            Console.Write("Enter the ID (integer) of Menu Item: ");
            int itemId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Food/Drink: ");
            string typeForD = Console.ReadLine();
            Console.Write("Enter Veg/NonVeg: ");
            string typeVegNon = Console.ReadLine();
            Console.Write("Enter ItemName: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter the quantity (integer) : ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rate (double): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            objMenu.AddMenu(itemId, typeForD, typeVegNon, itemName, quantity, rate);
            Console.WriteLine("\n---------------->MENU<----------------------");
            objMenu.DisplayMenu();
            Console.Write("Press any key to continue...");
        }

        public void AdminMenuRemove(int itemId, Menu objMenu)
        {
            objMenu.RemoveMenu(itemId);
            Console.WriteLine("\n---------------->MENU<----------------------");
            objMenu.DisplayMenu();
            Console.Write("Press any key to continue...");
        }

        public void AdminMenuDisplay(Menu objMenu)
        {
            Console.WriteLine("\n---------------->MENU<----------------------");
            objMenu.DisplayMenu();
            Console.Write("Press any key to continue...");
        }
    }
}
