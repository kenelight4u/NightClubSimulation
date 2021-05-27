using System.Security.AccessControl;
using System;

namespace nightClub
{
    public class AttendantEquiry
    {
        public static void GetEnquiryFromCustomer()
        {
            Attendant enquiry = new Attendant();
            // Customer customer = new Customer();

            bool stillAddingItems = true;

            while (stillAddingItems)
            {
                // Console.Clear();
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("Type 'add' to add an item.");
                Console.WriteLine("Type 'show' to show your list.");
                Console.WriteLine("Type 'sum' to Calculate the Bill");
                Console.WriteLine("Type 'clear' to delete all items from list.");
                Console.WriteLine("Type 'quit' to quit.");
                string response = Console.ReadLine().ToLower();
                Console.Clear();

                switch (response)
                {
                    case "add":
                        {
                            //Use this to display our drints brands and prices
                            System.Console.WriteLine("How many Items you wanted to add?");
                            int number = int.Parse(Console.ReadLine());

                            for (int i = 0; i < number; i++)
                            {
                                Console.Write("What item would you like to add? ");
                                string whatTheUserTyped = Console.ReadLine();
                                enquiry.SaveOrderFromCustomer(whatTheUserTyped);
                            }

                            break;
                        }
                    case "quit":
                        {
                            stillAddingItems = false;
                            break;
                        }
                    case "show":
                        {
                            foreach (string itemName in enquiry.GetSaveOrderFromCustomer())
                            {
                                Console.WriteLine(itemName);
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case "sum":
                        {
                            enquiry.PayBill();
                            // customer.Paybill();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                    case "clear":
                        {
                            enquiry.Clear();
                            break;
                        }
                }
            }
        }


    }
}