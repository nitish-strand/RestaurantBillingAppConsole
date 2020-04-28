using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBillingApp3._0
{
    public class BillModel
    {
        public readonly double gstpercent;
        public readonly double servicepercent;
        public readonly string[] itemsList;
        double subtotal;

        public List<MenuItem> CstMenu;

        public BillModel(string[] ChoicesArray, Menu objMenu)
        {
            gstpercent = 0.15;
            servicepercent = 0.18;
            itemsList = ChoicesArray;
            CstMenu = objMenu.MenuItems;
            subtotal = 0.0;
        }

        public void Calculate()
        {
            Console.WriteLine("=================***INVOICE***=================");
            foreach (string item in itemsList)
            {
                int itemInt = Convert.ToInt32(item);

                foreach (MenuItem obj in CstMenu)
                {
                    if (itemInt == obj._itemId)
                    {
                        subtotal += obj._rate;
                        Console.WriteLine("ID: {0}       Item: {1}        Cost: {2}", obj._itemId, obj._itemName, obj._rate);
                    }
                }
            }
            Console.WriteLine("Subtotal =>  {0}", Math.Round(subtotal, 2));
            Console.WriteLine("GST => {0}", Math.Round(gstpercent * subtotal, 2));
            Console.WriteLine("Service => {0}", Math.Round(servicepercent * subtotal, 2));
            Console.WriteLine("Total => {0}", Math.Round(subtotal + (gstpercent * subtotal) + (servicepercent * subtotal), 2));
            Console.WriteLine();
            Console.WriteLine("Press any key to restart.");
            Console.ReadKey();
        }
    }
}
