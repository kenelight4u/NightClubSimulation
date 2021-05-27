using System;

namespace nightClub
{
    public class Bouncer
    {
        private static void BouncerCheck(string name, int age, bool checkOutfit, bool checkIsStaff, bool checkHasTicket)
        {
            if (age >= 18 && checkOutfit == true && checkIsStaff == false && checkHasTicket == true)
            {
                Console.WriteLine($"Welcome to the Club {name}\nWould you like to make an Order?\nYes Or No");
                string reply = Console.ReadLine().ToLower();
                if(reply == "yes")
                {
                    customer.MakeOrder();
                }
                else
                {
                    Console.WriteLine("Enjoy the music\nThank you.");

                }              
            }
            else if (age >= 18 && checkOutfit == true && checkIsStaff == true && checkHasTicket == false)
            {
                Console.WriteLine("Which Department?");
                string department = Console.ReadLine();
                System.Console.WriteLine($"Hello {name} Welcome\nplease report to {department} Department!!!!");
            }
            else if (age >= 18 && checkOutfit == true && checkIsStaff == false && checkHasTicket == false)
            {
                Console.WriteLine("Please get a tciket if you not a Staff.");
                //i was thinking we create a feature here that alllows the person buy a ticket...
            }
             else if (age >= 18 && checkOutfit == false && checkIsStaff == true && checkHasTicket == false)
             {
                 Console.WriteLine("Please put on the complete outfit before we can grant you access to the club\nThanks.");
             }
             else if(age < 18 && checkOutfit == true && checkIsStaff == false && checkHasTicket == true)
             {
                 Console.WriteLine("You are too young to enter the Night Club.\nPlease go back home to your mommy.");
             }
        }

        public static void GetBouncerCheckResult(string name, int age, bool checkOutfit, bool checkIsStaff, bool checkHasTicket)
        {
            BouncerCheck(name, age, checkOutfit, checkIsStaff, checkHasTicket);
        }

        public static void vipOrRegular()
        {
            throw new NotImplementedException();
        }
    }
    
}