using System;

namespace NightClub
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterInputs callToVerify = new EnterInputs();
            callToVerify.VerifyIfStaffOrCustomer();
        }
    }
}
