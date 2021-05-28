using System;

namespace NightClub
{
    public class EnterInputs
    {
        public static void VerifyIfStaffOrCustomer()
        {
            Console.WriteLine("Welcome To The Night Club..\nStaff or Guest");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "guest":
                    AcceptUserInput();
                    break;
                case "staff":
                    Console.WriteLine("Enter your NAME: ");
                    string staffName = Console.ReadLine().ToUpper();
                    Console.WriteLine("Enter your STAFF ID: ");
                    string staffId = Console.ReadLine().ToUpper();
                    Staff id = new Staff(staffName, staffId);
                    
                    while (!id.StaffId)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Response\n You're not a Staff");
                        VerifyIfStaffOrCustomer();
                    }
                    Console.WriteLine("Which Department?");
                    string department = Console.ReadLine();
                    Console.WriteLine($"Hello {staffName} Welcome\nplease report to {department} Department!!!!");
                    Console.ReadLine();
                    Console.Clear();
                    VerifyIfStaffOrCustomer();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Response");
                    VerifyIfStaffOrCustomer();
                    break;
            }
            

            // if (input == "guest")
            // {
            //     AcceptUserInput();
            // }
            // else if(input == "staff")
            // {
            //     Console.WriteLine("Enter your STAFF ID: ");
            //     string staffId = Console.ReadLine().ToUpper();
            //     Staff id = new Staff(staffId);
                
            //     while (!id.StaffId)
            //     {
            //         Console.Clear();
            //         Console.WriteLine("Invalid Response\n You're not a Staff");
            //         VerifyIfStaffOrCustomer();
            //     }
            //     Console.WriteLine("Which Department?");
            //     string department = Console.ReadLine();
            //     Console.WriteLine($"Hello {staffId} Welcome\nplease report to {department} Department!!!!");
            //     Console.ReadLine();
            //     Console.Clear();
            //     VerifyIfStaffOrCustomer();
            // }
            // else
            // {
            //     Console.Clear();
            //     Console.WriteLine("Invalid Response");
            //     VerifyIfStaffOrCustomer();
            // }
        }

        public static void AcceptUserInput()
        {
            Console.Clear();
            Console.WriteLine("Welcome To The Night Club..\nPlease Provide Your details.");
            Console.WriteLine("Full Name");
            string name = Console.ReadLine();
            string validateName = Validation.ValidateAllStringInput(name);  

            Console.WriteLine("Your Age");
            string age = Console.ReadLine();
            int validateAge = Validation.ValidateAllIntInput(age); 

            Console.WriteLine("Are you wearing the complete outfit?\nYes or No");
            string responseForCompleteOutfit = Console.ReadLine().ToLower();
            string validateResponseForCompleteOutfit = Validation.IsStringYesOrNo(responseForCompleteOutfit);
            bool checkIfOutfitComplete = Validation.IsItYesOrNo(validateResponseForCompleteOutfit);
                  
            Console.WriteLine("Do you have a ticket?\nYes or No");
            string responseForTicket = Console.ReadLine().ToLower();
            string validateResponseForTicket = Validation.IsStringYesOrNo(responseForTicket);
            bool checkHasTicket = Validation.IsItYesOrNo(validateResponseForTicket);

            Customer customer = new Customer(validateName, validateAge, checkIfOutfitComplete, checkHasTicket);
                      
            Bouncer.GetBouncerCheckResult(customer.Name, customer.Age, customer.IsOutfitComplete, customer.HasTicket);
            
        }
    }
    
}