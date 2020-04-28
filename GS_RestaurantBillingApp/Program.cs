using System;
using System.Collections;
using System.Linq;

namespace GS_RestaurantBillingApp
{
    class Admin
    {
        private double servicePercentage = 0.18;
        private double GSTPercentage = 0.15;

        private string[,] MyMenu = {

            {"1","Food","Veg","Breakfast","Rava-Dosa","70"},
            {"2","Food","Veg","Breakfast","Poha","60"},
            {"3","Food","Veg","Breakfast","Upma","40"},
            {"4","Food","Veg","Breakfast","Sprouts-Jalfrezi","100"},
            {"5","Food","Veg","Breakfast","Steamed-Dhokla","120"},
            {"6","Food","Veg","Breakfast","Aloo-Paratha","40"},
            {"7","Food","Veg","Breakfast","Oats-Idli","30"},
            {"8","Food","Veg","Breakfast","Bread-Poha","50"},
            {"9","Food","Veg","Breakfast","Bajre-ka-Thepla","100"},
            {"10","Food","Veg","Breakfast","Uttapam","80"},
            {"11","Food","Veg","Breakfast","Grilled-Veg-Pesto-Sandwich","90"},
            {"12","Food","NonVeg","Breakfast","Omelate","120"},
            {"13","Food","NonVeg","Breakfast","Bacon","150"},
            {"14","Food","NonVeg","Breakfast","Chicken-Sandwich","140"},
            {"15","Food","NonVeg","Breakfast","Sausages","150"},
            {"16","Food" ,"Veg","Lunch","Masala-Bhindi","200"},
            {"17","Food" ,"Veg","Lunch","Chana-Kulcha","220"},
            {"18","Food","NonVeg","Lunch","Shahi-Egg-Curry","200"},
            {"19","Food" ,"Veg","Lunch","Gujarati-Kadhi","210"},
            {"20","Food" ,"Veg","Lunch","Allahabad-Ki-Tehri","130"},
            {"21","Food","NonVeg","Lunch","Low-Fat-Dahi-Chicken","140"},
            {"22","Food" ,"Veg","Lunch","Kolhapuri-Vegetables","120"},
            {"23","Food" ,"Veg","Lunch","Black-Channa-and-Coconut-Stew","160"},
            {"24","Food" ,"Veg","Lunch","Urlai-Roast","200"},
            {"25","Food" ,"Veg","Lunch","Paneer-Achaari","230"},
            {"26","Food" ,"Veg","Lunch","Dal-Makhani","210"},
            {"27","Food" ,"Veg","Dinner","Makhni-Paneer-Biryani","230"},
            {"28","Food" ,"Veg","Dinner","Hot-Yellow-Curry-with-Vegetables","190"},
            {"29","Food" ,"Veg","Dinner","Pommes-Gratin","250"},
            {"30","Food" ,"Veg","Dinner","Burritos","260"},
            {"31","Food" ,"Veg","Dinner","Nargisi-Kofta","230"},
            {"32","Food" ,"Veg","Dinner","Penne-A-La-Vodka","240"},
            {"33","Food" ,"Veg","Dinner","Dum-Paneer-Kali-Mirch","200"},
            {"34","Food" ,"Veg","Dinner","Khow-Suey","260"},
            {"35","Food" ,"Veg","Dinner","Matar-Ka-Dulma","230"},
            {"36","Food" ,"Veg","Dinner","Satrangi-Biryani","210"},
            {"37","Food" ,"Veg","Dinner","Dal-Makhani","250"},
            {"38","Food" ,"NonVeg","Dinner","Grilled-Chicken-Escalope-with-Fresh-Salsa","210"},
            {"39","Food" ,"NonVeg","Dinner","Mutton-Korma","260"},
            {"40","Food" ,"NonVeg","Dinner","Pina-Colada-Pork-Ribs","290"},
            {"41","Food" ,"NonVeg","Dinner","Tandoori-Lamb-Chops","280"},
            {"42","Food" ,"NonVeg","Dinner","Malabar-Fish-Biryan","300"},
            {"43","Food" ,"NonVeg","Dinner","Keema-Samosa-with-Yoghurt-Dip","310"},
            {"44","Food" ,"NonVeg","Dinner","Curried-Parmesan-Fish-Fingers","200"},
            {"45","Food" ,"NonVeg","Dinner","Chicken-65","230"},
            {"46","Food" ,"NonVeg","Dinner","Goan-Prawn-Curry-With-Raw-Mango","260"},
            {"47","Food" ,"NonVeg","Dinner","Nihari-Gosht","240"},
            {"48","Food" ,"NonVeg","Dinner","Butter-Chicken","200"},
            {"49","Drinks","Mocktail","All-time","Shirley-Ginger","260"},
            {"50","Drinks","Mocktail","All-time","Tahitian-Coffee-","290"},
            {"51","Drinks","Mocktail","All-time","Hot-Apple-Cider","280"},
            {"52","Drinks","Mocktail","All-time","Strawberry-Fields","300"},
            {"53","Drinks","Mocktail","All-time","Citrus-Fizz","310"},
            {"54","Drinks","Mocktail","All-time","Virgin-Watermelon-Margarita","200"},
            {"55","Drinks","Mocktail","All-time","Mango-Mule","230"},
            {"56","Drinks","Cocktail","All-time","Dry-Martini","300"},
            {"57","Drinks","Cocktail","All-time","Manhattan","300"},
            {"58","Drinks","Cocktail","All-time","Old-Fashioned","300"},
            {"59","Drinks","Cocktail","All-time","Mint-Jule","300"},
            {"60","Drinks","Cocktail","All-time","Mojito","300"},
            {"61","Drinks","Cocktail","All-time","Margarita","300"},
            {"62","Drinks","Cocktail","All-time","Daiquiri","300"}
        };

        public double servicePercent
        {
            get { return servicePercentage; }
            set { servicePercentage = value; }
        }
        public double GstPercent
        {
            get { return GSTPercentage; }
            set { GSTPercentage = value; }
        }

        public string[,] myMenu
        {
            get { return MyMenu; }
            set { MyMenu = value; }
        }

        public void AdminScreen()
        {
            Console.Clear();
            Console.WriteLine("Hello Admin!");
            // function that displays the complete database currently available
            // Choices of databases avaialble to view
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Here are your options.");
            Console.WriteLine("1. You want to add. ");
            Console.WriteLine("2. You want to view. ");
            Console.WriteLine("3. You want to go back to Homescreen. "); ;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("add");
                    AddMenu();
                    break;
                case "2":
                    Console.WriteLine("view");
                    ViewMenu();
                    AdminScreen();
                    break;
                case "3":
                    Console.WriteLine("return back to Homescreen");
                    Console.Clear();
                    Program.HomeScreen();
                    break;
                default:
                    Console.WriteLine("Bad choice.");
                    Console.Clear();
                    Console.WriteLine("Bad choice. Please try again.");
                    AdminScreen();
                    break;
            }
        }

        public void AddMenu()
        {
            Console.WriteLine("Press any key to see what you already have:- ");
            Console.ReadKey();
            ViewMenu();
            Console.WriteLine("ID\tFood/Drinks\tVeg/NonVeg\tB/L/D/AT\tItem\tPrice");
            Console.WriteLine("Enter the new item you like to add, In format given above:- ");
            string menuInput = Console.ReadLine();

            // making array out of the InputString
            string[] menuInputArray = menuInput.Split(' ');

            // Declaring a new array of the desired size and copy the contents of the original array into the new array.
            //creating temp array
            string[,] newTemp = new string[myMenu.GetLength(0), 6];

            //Save old menu data into new temp array
            for (int i = 0; i < myMenu.GetLength(0); i++)
                for (int j = 0; j < myMenu.GetLength(1); j++)
                    newTemp[i, j] = myMenu[i, j];

            //increase the size +1 (row wise).
            myMenu = new string[newTemp.GetLength(0) + 1, 6];

            //Copy back to original array
            for (int i = 0; i < newTemp.GetLength(0); i++)
                for (int j = 0; j < newTemp.GetLength(1); j++)
                    myMenu[i, j] = newTemp[i, j];

            //Add the new row to the array
            for (int j = 0; j < menuInputArray.Length; j++)
                myMenu[myMenu.GetLength(0) - 1, j] = menuInputArray[j];

            Console.WriteLine("Press any key to return back to Admin menu...");
            Console.ReadKey();
            AdminScreen();
        }

        public void ViewMenu()
        {
            Console.WriteLine("ID\tFood/Drinks\tVeg/NonVeg\tB/L/D/AT\tItem\tPrice");
            for (int i = 0; i < myMenu.GetLength(0); i++)
            {
                for (int j = 0; j < myMenu.GetLength(1); j++)
                {
                    Console.Write(myMenu[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    class Customer
    {

        public void CustomerScreen()
        {
            Console.Clear();
            Console.WriteLine("Hello Customer!");
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Here are your options.");
            Console.WriteLine("1. You want to Order. ");
            Console.WriteLine("2. You want to go back to Homescreen. ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Order");
                    CustomerOrder();
                    break;
                case "2":
                    Console.WriteLine("return back to Homescreen");
                    Console.Clear();
                    Program.HomeScreen();
                    break;
                default:
                    Console.WriteLine("Bad choice.");
                    Console.Clear();
                    Console.WriteLine("Bad choice. Please try again.");
                    CustomerScreen();
                    break;
            }
        }

        public void CustomerOrder()
        {
            Admin objView = new Admin();
            objView.ViewMenu();

            double gst = objView.GstPercent;
            double serv = objView.servicePercent;

            string choicesIDs = CollectID();

            if (choicesIDs != "")
            {
                //calculate() and generate invoice;
                string[] ChoicesArray = choicesIDs.Trim().Split(' ');

                double subtotal = 0.0;

                Console.WriteLine("=================================> INVOICE <=================================");
                foreach (var e in ChoicesArray)
                {
                    Console.Write(GetItem(e) + "...................................................... ");
                    Console.WriteLine(GetPrice(e));
                    subtotal += Convert.ToDouble(GetPrice(e));
                }
                Console.WriteLine("Subtotal_______________________________________________________________" + subtotal);
                Console.WriteLine("GST {0}.............................................................{1}", gst, gst * subtotal);
                Console.WriteLine("Service Charges {0} ................................................{1}", serv, serv * subtotal);
                Console.WriteLine("Your final bill is __________________________________________________{0}", subtotal + (gst * subtotal) + (serv * subtotal));

                Console.ReadKey();
                CustomerScreen();
            }
            else CustomerScreen();
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
            Admin obj = new Admin();
            for (int i = 0; i < obj.myMenu.GetLength(0); i++)
            {
                if (obj.myMenu[i, 0] == ID)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetItem(string itemId)
        {
            Admin obj = new Admin();
            for (int i = 0; i < obj.myMenu.GetLength(0); i++)
            {
                if (obj.myMenu[i, 0] == itemId)
                {
                    return obj.myMenu[i, 4];
                }
            }
            return "Item-missig";

        }

        public string GetPrice(string itemId)
        {
            Admin obj = new Admin();
            for (int i = 0; i < obj.myMenu.GetLength(0); i++)
            {
                if (obj.myMenu[i, 0] == itemId)
                {
                    return obj.myMenu[i, 5];
                }
            }
            return "0";
        }

        /*
        public string GetInfo(string itemId, string item)
        {
            int colmn = 0;
            Admin obj = new Admin();
            if (item == "item") colmn = 4;
            else if (item == "price") colmn = 5;
            else if(item == "check") colmn = 
                for (int i = 0; i < obj.myMenu.GetLength(0); i++)
                {
                    if (obj.myMenu[i, 0] == itemId)
                    {
                        return obj.myMenu[i, colmn];
                    }
                }
        }
        */
    }
    
    class Program
    {
        public static void HomeScreen()
        {
            Customer objCust = new Customer();
            Admin objAdm = new Admin();

            Console.WriteLine("==>Welcome to GS Eatery<==");
            Console.WriteLine();
            Console.WriteLine("Hello, Who are you? ");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Logout");
            Console.Write("Enter your choice:- ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        objAdm.AdminScreen();
                        Console.ReadKey();
                        break;
                    }
                case "2":
                    {
                        objCust.CustomerScreen();
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
                    Console.WriteLine("Bad choice.");
                    Console.Clear();
                    Console.WriteLine("Bad choice. Please try again.");
                    HomeScreen();
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

        public static void Main()
        {
            GetAppInfo();
            HomeScreen();
        }
    }
}