using System;
using System.Collections.Generic;

namespace NightClub
{
    public class RegularCustomer : Person
    {
        public int Age { get; set; }
        public bool IsOutfitComplete { get; set; }
        public bool HasTicket { get; set; }

        public RegularCustomer()
        {
            
        }

        public RegularCustomer(string name, int age, bool isOutfitComplete, bool hasTicket)
        {
            Name = name;
            Age = age;
            IsOutfitComplete = isOutfitComplete;
            HasTicket = hasTicket;
        }

        
    }
}