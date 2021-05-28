using System;

namespace NightClub
{
    public class Bouncer
    {
        private static void BouncerCheck(string name, int age, bool checkOutfit, bool checkHasTicket)
        {
            if (age >= 18 && checkOutfit == true && checkHasTicket == true)
            {
                Console.WriteLine($"Welcome to the Club {name}\nWould you like to make an Order?\nYes Or No");
                string reply = Console.ReadLine().ToLower();

              string validateReply = Validation.IsStringYesOrNo(reply);
                if (validateReply == "yes")
                {
                    Customer.MakeOrder();    
                }
                else if (validateReply == "no")
                {
                    Console.WriteLine("Enjoy the music\nThank you.");
                    Console.ReadKey();
                }
            }
            else if (age >= 18 && checkOutfit == true && checkHasTicket == false)
            {
                Console.WriteLine("Please get a tciket if you not a Staff.");
                //i was thinking we create a feature here that alllows the person buy a ticket...
            }
             else if (age >= 18 && checkOutfit == false && checkHasTicket == false)
             {
                 Console.WriteLine("Please put on the complete outfit before we can grant you access to the club\nThanks.");
             }
             else if(age < 18 && checkOutfit == true && checkHasTicket == true)
             {
                 Console.WriteLine("You are too young to enter the Night Club.\nPlease go back home to your mommy.");
             }
        }

        public static void GetBouncerCheckResult(string name, int age, bool checkOutfit, bool checkHasTicket)
        {
            BouncerCheck(name, age, checkOutfit, checkHasTicket);
        }

        public static void vipOrRegular()
        {
            throw new NotImplementedException();
        }
    }
    
}