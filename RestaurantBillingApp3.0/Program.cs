using System;
using System.Collections.Generic;

namespace RestaurantBillingApp3._0
{
    public class Program
    {
        public static Menu objMenu = new Menu();

        public static void BasicMenu()
        {
            // if basic hard coded menu can be entered into the list
            objMenu.MenuItems = new List<MenuItem>()
            {
                new MenuItem() {_itemId = 1, _typeForD = "Food", _typeVegNon = "Veg", _itemName = "Poha", _quantity=1, _rate= 45},
                new MenuItem() {_itemId = 2, _typeForD = "Food", _typeVegNon = "Veg", _itemName = "Noodles", _quantity=1, _rate= 55},
                new MenuItem() {_itemId = 3, _typeForD = "Food", _typeVegNon = "NonVeg", _itemName = "ChikenCurry", _quantity=1, _rate= 150},
                new MenuItem() {_itemId = 4, _typeForD = "Food", _typeVegNon = "NonVeg", _itemName = "MuttonCurry", _quantity=1, _rate= 245},
                new MenuItem() {_itemId = 5, _typeForD = "Food", _typeVegNon = "NonVeg", _itemName = "MuttonKorma", _quantity=1, _rate= 200},
                new MenuItem() {_itemId = 6, _typeForD = "Drink", _typeVegNon = "MockTail", _itemName = "Tea", _quantity=1, _rate= 15},
                new MenuItem() {_itemId = 7, _typeForD = "Drink", _typeVegNon = "MockTail", _itemName = "Pena-co-lada", _quantity=1, _rate= 50},
                new MenuItem() {_itemId = 8, _typeForD = "Drink", _typeVegNon = "Cocktail", _itemName = "Martini", _quantity=1, _rate= 550},
                new MenuItem() {_itemId = 9, _typeForD = "Drink", _typeVegNon = "Cocktail", _itemName = "RumNCoke", _quantity=1, _rate= 240},
                new MenuItem() {_itemId = 10, _typeForD = "Drink", _typeVegNon = "Cocktail", _itemName = "JackNCoke", _quantity=1, _rate= 590},
            };
        }

        public static bool AdminValidation()
        {
            Console.Write("Enter your Username:- ");
            string name = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (name == "admin" && password == "admin@#123")
            {
                Console.WriteLine("Admin credentials validated");
                return true;
            }
            else
            {
                Console.WriteLine("Admin entry denied. Please try again.");
                return false;
            }
        }

        public static void AdminScreen(AdminModel AdmObj)
        {
            Console.WriteLine();
            
            Console.WriteLine("Hello Admin {0}!",AdmObj.UserName);
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Here are your options.");
            Console.WriteLine("1. You want to add. ");
            Console.WriteLine("2. You want to remove. ");
            Console.WriteLine("3. You want to view. ");
            Console.WriteLine("4. You want to go back to Homescreen. ");
            Console.Write("Enter your choice:- ");
            switch (Console.ReadLine())
            {
                case "1":
                    // Console.WriteLine("add");
                    AdmObj.AdminMenuAdd(objMenu);
                    Console.ReadKey();
                    AdminScreen(AdmObj);
                    break;
                case "2":
                    // Console.WriteLine("remove");
                    Console.Write("Give the Id of item what would you like to remove? ");
                    AdmObj.DisplayMenu();
                    AdmObj.AdminMenuRemove(Convert.ToInt32(Console.ReadLine()), objMenu);
                    Console.ReadKey();
                    AdminScreen(AdmObj);
                    break;
                case "3":
                    // Console.WriteLine("View the Menu");
                    AdmObj.AdminMenuDisplay(objMenu);
                    Console.ReadKey();
                    AdminScreen(AdmObj);
                    break;
                case "4":
                    // Console.WriteLine("return back to Homescreen");
                    Program.HomeScreen();
                    break;
                default:
                    Console.WriteLine("Bad choice. Please try again.");
                    AdminScreen(AdmObj);
                    break;
            }
        }

        public static void CustomerScreen(CustomerModel CstObj, string username)
        {
            Console.WriteLine();
            Console.WriteLine("Hello {0}!", CstObj.UserNameAssign(username));
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Here are your options.");
            Console.WriteLine("1. You want to Order. ");
            Console.WriteLine("2. You want to go back to Homescreen. ");
            Console.Write("Enter your choice:- ");
            switch (Console.ReadLine())
            {
                case "1":
                    // Console.WriteLine("Order");
                    CstObj.CustomerOrder(objMenu);
                    break;
                case "2":
                    // Console.WriteLine("return back to Homescreen");
                    Program.HomeScreen();
                    break;
                default:
                    Console.WriteLine("Bad choice. Please try again.");
                    CustomerScreen(CstObj, username);
                    break;
            }
        }

        public static void GetAppInfo()
        {
            string appName = "GS_RestaurantBillingApp";
            string appVersion = "1.0.0";
            string appAuthor = "Nitish Kumar Pal";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void HomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Who are you ?");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Logout");
            Console.Write("Enter your choice:- ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        if (AdminValidation())
                        {
                            AdminModel AdmObj = new AdminModel();
                            Console.Write("Please state your name: ");
                            string username = Console.ReadLine();
                            AdmObj.UserNameAssign(username);
                            AdminScreen(AdmObj);
                        }
                        else HomeScreen();
                        Console.ReadKey();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Hello Ma'am/Sir whats your name: ");
                        string username = Console.ReadLine();
                        CustomerModel CstObj = new CustomerModel(objMenu);
                        CustomerScreen(CstObj, username);
                        Console.ReadKey();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You have successfully logged out");
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Bad choice. Please try again.");
                    HomeScreen();
                    break;
            }
        }

        static void Main()
        {
            // Add basic things to show-up something on menu card.
            Program.BasicMenu();

            //Main first time Homescreen viewing
            GetAppInfo();
            HomeScreen();
            Console.WriteLine("Lets see if it ends here.");
        }
    }
}
