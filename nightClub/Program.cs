using System;

namespace nightClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Night Club..\nPlease Provide Your details.");
            Console.WriteLine("Full Name");
            string fullName = Console.ReadLine();      
            Console.WriteLine("Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you wearing the complete outfit?\nYes or No");
            string checkIsOutfitComplete = Console.ReadLine().ToLower();
            bool isOutfitComplete = false;
            if(checkIsOutfitComplete == "yes")
            {
                isOutfitComplete = true;
            }        
            Console.WriteLine("Are you a staff?\nYes or NO");
            string checkIsStaff = Console.ReadLine().ToLower();
            bool isStaff = false;
            if (checkIsStaff == "yes")
            {
                isStaff = true;
            }
            Console.WriteLine("Do you have a ticket?\nYes or No");
            string checkhasTicket = Console.ReadLine();
            bool hasTicket = false;
            if(checkhasTicket == "yes")
            {
                hasTicket = true;
            }

            //Person person = new Person(fullName, age, isOutfitComplete, isStaff, hasTicket);
            Bouncer.GetBouncerCheckResult(fullName, age, isOutfitComplete, isStaff, hasTicket);
            
            //Console.WriteLine($"Name : {person.Name} age : {person.Age} isOutfitComplete : {person.IsOutfitComplete} isStaff : {person.IsStaff} hasTicket : {person.HasTicket}");
        }
    }
}
