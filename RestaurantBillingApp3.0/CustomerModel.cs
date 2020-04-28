using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBillingApp3._0
{
    public class CustomerModel : IUsers
    {
        public List<MenuItem> CstMenu;

        public string UserName;
        public string UserNameAssign(string username)
        {
            UserName = username;
            return UserName;
        }
        public CustomerModel(Menu objMenu)
        {
            CstMenu = objMenu.MenuItems;
        }
        public void CustomerOrder(Menu objMenu)
        {
            Console.WriteLine("\n---------------->MENU<----------------------");
            objMenu.DisplayMenu();

            string choicesIDs = CollectID();

            if (choicesIDs != "")
            {
                //calculate() and generate invoice;
                string[] ChoicesArray = choicesIDs.Trim().Split(' ');
                BillModel billObj = new BillModel(ChoicesArray, objMenu);
                billObj.Calculate();
                CustomerModel CstObj = new CustomerModel(objMenu);
                Program.CustomerScreen(CstObj, UserName);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Returning to customer screen");
                CustomerModel CstObj = new CustomerModel(objMenu);
                Program.CustomerScreen(CstObj, UserName);
            }
        }

        public string CollectID(string choicesIDs = "")
        {
            Console.WriteLine("Give the \"ID\" of an item from the above menu, you wouldlike to have:- ");
            string ID = Console.ReadLine();

            if (CheckID(ID))
            {
                choicesIDs += ID + " ";

                Console.WriteLine("Would you like to add more items(Press 1) or proceed to billing(Press any other key)");
                string MoreOrBill = Console.ReadLine();

                if (MoreOrBill == "1") return CollectID(choicesIDs);
                else return choicesIDs;
            }
            Console.WriteLine("You have entered the wrong item. Please press any key to re-start");
            Console.ReadKey();
            choicesIDs = "";
            return choicesIDs;
        }

        public bool CheckID(string ID)
        {
            foreach (MenuItem obj in CstMenu)
            {
                if (Convert.ToString(obj._itemId) == ID) return true;
            }
            return false;
        }
    }
}
