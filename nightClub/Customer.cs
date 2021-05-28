using System;
using System.Collections.Generic;

namespace NightClub
{
    public class Customer : Person
    {
        public int Age { get; set; }
        public bool IsOutfitComplete { get; set; }
        public bool HasTicket { get; set; }

        public Customer(string name, int age, bool isOutfitComplete, bool hasTicket)
        {
            Name = name;
            Age = age;
            IsOutfitComplete = isOutfitComplete;
            HasTicket = hasTicket;
        }

        public static void MakeOrder()
        {
            Console.Clear();
            Attendant.ShowMenu();
            Console.WriteLine("How many drinks would u like to order");
            string choice = Console.ReadLine();
            int validateChoice = Validation.ValidateAllIntInput(choice);

            Console.WriteLine("select 1,2,3 or 4 to make your order.");
            for (int i = 1; i <= validateChoice; i++)
            {
                Console.Write("Enter your Choice: ");
                string customerChoice = Console.ReadLine();
                int validateCustomerChoice = Validation.ValidateAllIntInput(customerChoice);
                Attendant.GettingOrderFromCustomer(validateCustomerChoice);
            }
            Console.Clear();
            Console.WriteLine("Are you done for the night?\nYes Or No");
            string reply = Console.ReadLine().ToLower();
            string validateReply = Validation.IsStringYesOrNo(reply);
            if (validateReply == "yes")
            {
                Dj.GetCurrentMusic();
                Console.WriteLine();
                Paybill();
                Console.ReadKey();
            }
            else if (validateReply == "no")
            {
                MakeOrder();
            }
        }
        public static void Paybill()
        {
            Attendant.PresentBillToCustomer();

            //calls the method presentBillToCustomer()
            //Then picks the variable total cost from that method 
            //then sets the the amount to be paid 
            //and process finalizing..to exit.
        }
    }
}