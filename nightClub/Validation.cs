using System;

namespace NightClub
{
    public class Validation
    {
        public static int ValidateAllIntInput(string inputtedNumber)
        {
            int number;

            while (!int.TryParse(inputtedNumber, out number))
            {
                Console.WriteLine("Enter a Number: ");
                inputtedNumber = Console.ReadLine();
            }
            return number;
        }
        public static string ValidateAllStringInput(string fileName)
        {
            while (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Enter a Name: ");
                fileName = Console.ReadLine();
            }
            return fileName;
        }

        public static string IsStringYesOrNo(string checkIsOutfitComplete )
        {
            while (checkIsOutfitComplete != "yes" && checkIsOutfitComplete != "no")
            {
                Console.WriteLine($"Invalid option");
                Console.WriteLine("Enter Yes or No ");
                checkIsOutfitComplete = Console.ReadLine().ToLower();
            }

            return checkIsOutfitComplete;
        }

        public static bool IsItYesOrNo(string check)
        {
            if(check == "yes")
            {
               return true;
            }
            else
            {
                return false;
            }

        }
    }
}