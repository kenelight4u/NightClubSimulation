using System;
using System.Collections.Generic;

namespace nightClub
{
    public class customer
    {
         

        public static void MakeOrder()
        {       Console.Clear();
                Console.WriteLine("How many drinks would u like to order");    
                int choice = Int32.Parse(Console.ReadLine());
                choice--;
                Attendant.ShowMenu();
                for(int i = 0; i <= choice; i++)
                {
                    int customerChoice = Int32.Parse(Console.ReadLine());
                    Attendant.GettingOrderFromCustomer(customerChoice);        
                }
                Console.Clear();
                Console.WriteLine("Are you done for the night?\nYes Or No");
                string reply = Console.ReadLine().ToLower();
                if(reply == "yes")
                {
                    paybill();      
                }
                else
                {
                    MakeOrder();
                }
                
        }
        public static void paybill()
        {
             Attendant.PresentBillToCustomer();
            
            //calls the method presentBillToCustomer()
            //Then picks the variable total cost from that method 
            //then sets the the amount to be paid 
            //and process finalizing..to exit.
        }
    }
}