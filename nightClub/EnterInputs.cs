using System;

namespace NightClub
{
    public class EnterInputs
    {
        public static void VerifyIfStaffOrCustomer()
        {

            bool programStarts = true;

            while (programStarts)
            {
                Console.Clear();
                Console.WriteLine("Welcome To The Night Club..\nStaff or Guest\nExit to Leave the Club Premises");
                string input = Console.ReadLine().ToLower();
                string validateInput = Validation.IsStringStaffGuestQuit(input);

                switch (validateInput)
                {
                    case "guest":
                        AcceptUserInput();
                        break;
                    case "staff":
                        Dj.GetCurrentMusic();
                        Console.WriteLine();
                        Console.WriteLine("Enter your NAME: ");
                        string staffName = Console.ReadLine().ToUpper();
                        string validateStaffName = Validation.ValidateAllStringInput(staffName);

                        Console.WriteLine("Enter your STAFF ID: ");
                        string staffId = "STF"+Console.ReadLine().ToUpper();
                        Staff id = new Staff(validateStaffName, staffId);

                        switch (id.StaffId)
                        {
                            case true:
                                Console.WriteLine("Which Department?");
                                string department = Console.ReadLine();
                                Console.WriteLine($"Hello {validateStaffName} Welcome\nplease report to {department} Department!!!!");
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("ARRESTED!!!");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case "exit":
                        programStarts = false;
                        break;
                }
            }

        }

        public static void AcceptUserInput()
        {
            Console.Clear();
            Dj.GetCurrentMusic();
            Console.WriteLine();
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