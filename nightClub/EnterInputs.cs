using System;

namespace nightClub
{
    public class PersonInput
    {
        public static void AcceptUserInput()
        {
            Person person = new Person();
            Console.WriteLine("Welcome To The Night Club..\nPlease Provide Your details.");
            Console.WriteLine("Full Name");
            person.Name = Console.ReadLine();     
            Console.WriteLine("Your Age");
            person.Age = Int32.Parse(Console.ReadLine());        
            Console.WriteLine("Are you wearing the complete outfit?\nYes or No");
            string checkIsOutfitComplete = Console.ReadLine().ToLower();
            person.IsOutfitComplete = false;
            if(checkIsOutfitComplete == "yes")
            {
               person.IsOutfitComplete = true;
            }        
            Console.WriteLine("Are you a staff?\nYes or NO");
            string checkIsStaff = Console.ReadLine().ToLower();
            person.IsStaff = false;
            if (checkIsStaff == "yes")
            {
                person.IsStaff = true;
            }
            Console.WriteLine("Do you have a ticket?\nYes or No");
            string checkhasTicket = Console.ReadLine();
            person.HasTicket = false;
            if(checkhasTicket == "yes")
            {
                person.HasTicket = true;
            }

            Bouncer.GetBouncerCheckResult(person.Name,person.Age,person.IsOutfitComplete,person.IsStaff,person.HasTicket);
            
        }
    }
    
}