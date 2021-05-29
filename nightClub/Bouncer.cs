using System;

namespace NightClub
{
    public class Bouncer
    {
        RegularOrder regularOrder = new RegularOrder();
        VipOrder vipOrder = new VipOrder();

        private void BouncerCheck(string name, int age, bool checkOutfit, bool checkHasTicket)
        {
            if (age >= 18 && checkOutfit == true && checkHasTicket == true)
            {
                Console.WriteLine($"Welcome to the Club {name}\nWould you like to make an Order?\nYes Or No");
                string reply = Console.ReadLine().ToLower();

              string validateReply = Validation.IsStringYesOrNo(reply);
                if (validateReply == "yes")
                {
                    regularOrder.MakeOrder();
                }
                else if (validateReply == "no")
                {
                    Console.Clear();
                    Dj.GetCurrentMusic();
                    Console.WriteLine();
                    Console.WriteLine("Enjoy the music\nThank you.");
                    Console.ReadKey();
                }
            }
            else if (age >= 18 && checkOutfit == true && checkHasTicket == false)
            {
                Console.WriteLine("Please get a Ticket");
                Console.ReadKey();
            }
            else if (age >= 18 && checkOutfit == false && checkHasTicket == true)
            {
                Console.WriteLine("Please put on the complete outfit before we can grant you access to the club\nThanks.");
                Console.ReadKey();
            }
            else if (age >= 18 && checkOutfit == false && checkHasTicket == false)
            {
                Console.WriteLine("Please put on the complete Outfit and get a Ticket before we can grant you access to the club\nThanks.");
                Console.ReadKey();
            }
            else if (age < 18 && checkOutfit == true && checkHasTicket == true)
            {
                Console.WriteLine("You are too young to enter the Night Club.\nPlease go back home to your mommy.");
                Console.ReadKey();
            }
            else if (age < 18 && checkOutfit == false && checkHasTicket == true)
            {
                Console.WriteLine("You are too Young and your Dressing is Unfit to enter the Night Club.\nPlease go back home to your mommy.");
                Console.ReadKey();
            }
        }
          
        private void BouncerCheck(string name, int age, bool checkOutfit, bool checkHasTicket, string ticketType)
        {    
            if (age >= 18 && checkOutfit == true && checkHasTicket == true && ticketType == "v")
            {
                Console.WriteLine($"Welcome to the Club {name}\nWould you like to make an Order?\nYes Or No");
                string reply = Console.ReadLine().ToLower();

                string validateReply = Validation.IsStringYesOrNo(reply);
                if (validateReply == "yes")
                {
                    vipOrder.MakeOrder();
                }
                else if (validateReply == "no")
                {
                    Console.Clear();
                    Dj.GetCurrentMusic();
                    Console.WriteLine();
                    Console.WriteLine("Enjoy the music\nThank you.");
                    Console.ReadKey();
                }
            }
            else if (age >= 18 && checkOutfit == false && checkHasTicket == true && ticketType == "v")
            {
                Console.WriteLine("Please put on the complete outfit before we can grant you access to the club\nThanks.");
                Console.ReadKey();
            }
            else if (age < 18 && checkOutfit == true && checkHasTicket == true && ticketType == "v")
            {
                Console.WriteLine("You are too young to enter the Night Club.\nPlease go back home to your mommy.");
                Console.ReadKey();
            }
            else if (age < 18 && checkOutfit == false && checkHasTicket == true && ticketType == "v")
            {
                Console.WriteLine("You are too Young and your Dressing is Unfit to enter the Night Club.\nPlease go back home to your mommy.");
                Console.ReadKey();
            }
            
        }

        public void GetBouncerCheckResult(string name, int age, bool checkOutfit, bool checkHasTicket)
        {
            BouncerCheck(name, age, checkOutfit, checkHasTicket);
        }

        public void GetBouncerForVipCheck(string name, int age, bool checkOutfit, bool checkHasTicket, string ticketType)
        {
           BouncerCheck(name, age, checkOutfit, checkHasTicket, ticketType);
        }
    }

}