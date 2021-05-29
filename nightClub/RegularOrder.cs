using System;

namespace NightClub
{
    public class RegularOrder : Order
    {
        public override void MakeOrder()
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

        public override void Paybill()
        {
           Attendant.PresentBillToCustomer();
        }
    }
}