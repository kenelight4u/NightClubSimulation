namespace NightClub
{
    public class VipCustomer : Person
    {
        public int Age { get; set; }
        public bool IsOutfitComplete { get; set; }
        public bool HasTicket { get; set; }
        public string TicketType { get; set; }

        public VipCustomer(string name, int age, bool isOutfitComplete, bool hasTicket, string ticketType)
        {
            Name = name;
            Age = age;
            IsOutfitComplete = isOutfitComplete;
            HasTicket = hasTicket;
            TicketType = ticketType;
        }
    }
}