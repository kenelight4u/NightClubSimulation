using System;
using System.Collections.Generic;
using System.Linq;

namespace NightClub
{
    public class BarMan
    {
        private static List<decimal> priceOfDrinksPurchased = new List<decimal>();

        public static void PresentCalculatedPrice()
        {

            Console.WriteLine($"Total Price of all drinks Bought : {priceOfDrinksPurchased.Sum()}");
        }

        private static void CalculatePrice(int choice)
        {
            Drinks drinks = new Drinks();
            decimal price = 0;
            switch (choice)
            {
                case 1:
                    price = drinks.Andre;
                    break;
                case 2:
                    price = drinks.Smenorf;
                    break;
                case 3:
                    price = drinks.Beer;
                    break;
                case 4:
                    price = drinks.Don_Simon;
                    break;
                case 5:
                    price = drinks.Shisha;
                    break;
                case 6:
                    price = drinks.Cocaine;
                    break;
            }
            priceOfDrinksPurchased.Add(price);

            //Has the calculations for all the drinks ordered by the customer.
        }

        public static void GetCalculatedPrice(int choice)
        {
            CalculatePrice(choice);
        }
    }
}