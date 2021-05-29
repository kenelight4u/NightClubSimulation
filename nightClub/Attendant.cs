using System;
using System.Collections.Generic;

namespace NightClub
{
    public class Attendant
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Here is a list of our current drink and their prices.");
            Console.WriteLine("1 : Drink Name : Andre --Price : 1000");
            Console.WriteLine("2 : Drink Name : smenorf --Price : 2000");
            Console.WriteLine("3 : Drink Name : beer --Price : 3000");
            Console.WriteLine("4 : Drink Name : don-Simon --Price : 4000");
            Console.WriteLine();
        }

        public static void ShowVipMenu()
        {
            Console.WriteLine("Here is a list of our current drink and their prices.");
            Console.WriteLine("1 : Drink Name : Andre --Price : 1000");
            Console.WriteLine("2 : Drink Name : smenorf --Price : 2000");
            Console.WriteLine("3 : Drink Name : beer --Price : 3000");
            Console.WriteLine("4 : Drink Name : don-Simon --Price : 4000");
            Console.WriteLine("5 : Shisha Available : --Price : 1000");
            Console.WriteLine("6 : Cocaine Available per 1kg : --Price : 5000");
            Console.WriteLine();
        }
        public static void PresentBillToCustomer()
        {
            BarMan.PresentCalculatedPrice();
        }

        public static void GettingOrderFromCustomer(int choice)
        {
            BarMan.GetCalculatedPrice(choice);

        }
    }
}