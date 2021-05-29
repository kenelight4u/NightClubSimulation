using System;

namespace NightClub
{
    public class EnterInputs
    {
        Bouncer bouncer = new Bouncer();
        public void VerifyIfStaffOrCustomer()
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

        public void AcceptUserInput()
        {
            RegularCustomer customer = new RegularCustomer();

            Console.Clear();
            Dj.GetCurrentMusic();
            Console.WriteLine();
            Console.WriteLine("Welcome To The Night Club..\nPlease Provide Your details.");
            Console.WriteLine("Full Name");
            string name = Console.ReadLine();
            string validateName = Validation.ValidateAllStringInput(name);
            customer.Name = validateName;

            Console.WriteLine("Your Age");
            string age = Console.ReadLine();
            int validateAge = Validation.ValidateAllIntInput(age);
            customer.Age = validateAge;

            Console.WriteLine("Are you wearing the complete outfit?\nYes or No");
            string responseForCompleteOutfit = Console.ReadLine().ToLower();
            string validateResponseForCompleteOutfit = Validation.IsStringYesOrNo(responseForCompleteOutfit);
            bool checkIfOutfitComplete = Validation.IsItYesOrNo(validateResponseForCompleteOutfit);
            customer.IsOutfitComplete = checkIfOutfitComplete;

            Console.WriteLine("Do you have a ticket?\nYes or No");
            string responseForTicket = Console.ReadLine().ToLower();
            string validateResponseForTicket = Validation.IsStringYesOrNo(responseForTicket);
            bool checkHasTicket = Validation.IsItYesOrNo(validateResponseForTicket);
            customer.HasTicket = checkHasTicket;

            if (checkHasTicket == true)
            {
                Console.WriteLine("Ticket Type?\nV for VIP or R for REGULAR");
                string responseForTicketType = Console.ReadLine().ToLower();
                string validateResponseForTcketType = Validation.CheckForVipOrRegular(responseForTicketType);

                VipCustomer vipCustomer = new VipCustomer(validateName, validateAge, checkIfOutfitComplete, checkHasTicket, validateResponseForTcketType);
                RegularCustomer regCustomer = new RegularCustomer(validateName, validateAge, checkIfOutfitComplete, checkHasTicket);
                if (validateResponseForTcketType == "v")
                {
                    bouncer.GetBouncerForVipCheck(vipCustomer.Name, vipCustomer.Age, vipCustomer.IsOutfitComplete, vipCustomer.HasTicket, vipCustomer.TicketType);
                }
                else if(validateResponseForTcketType == "r")
                {
                    bouncer.GetBouncerCheckResult (regCustomer.Name, regCustomer.Age, regCustomer.IsOutfitComplete, regCustomer.HasTicket);
                }
               
            }
            else if(checkHasTicket == false)
            {
                bouncer.GetBouncerCheckResult(customer.Name, customer.Age, customer.IsOutfitComplete, customer.HasTicket);
            }
            
            
                
            
            
            

        }
    }

}