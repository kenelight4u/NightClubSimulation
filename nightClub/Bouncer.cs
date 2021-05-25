using System;

namespace nightClub
{
    public class Bouncer
    {
        
        private static void BouncerCheck(string name, int age, bool checkOutfit, bool checkIsStaff, bool checkHasTicket)
        {
            if (age >= 18 && checkOutfit == true && checkIsStaff == false && checkHasTicket == true)
            {
                Console.WriteLine("Welcome to the Club");
                //customer class that has private makeOrder() method
                //that also has public givingOrder() method that
                // (calls) [attendant method gettingOrder]
                
            }
            else if (age >= 18 && checkOutfit == true && checkIsStaff == true && checkHasTicket == false)
            {
                Console.WriteLine("Which Department?");
                string department = Console.ReadLine();
                System.Console.WriteLine($"Hello {name} Welcome\nplease report to {department} Department!!!!");
            }
        }

        public static void GetBouncerCheckResult(string name, int age, bool checkOutfit, bool checkIsStaff, bool checkHasTicket)
        {
            BouncerCheck(name, age, checkOutfit, checkIsStaff, checkHasTicket);
        }
    }
    
}