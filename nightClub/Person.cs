namespace nightClub
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsOutfitComplete { get; set; }
        public bool IsStaff { get; set; }
        public bool HasTicket { get; set; }

        public Person(){}
        public Person(string fullName, int age, bool isOutfitComplete, bool isStaff, bool hasTicket)
        {
            Name = fullName;
            Age = age;
            IsOutfitComplete = isOutfitComplete;
            IsStaff = isStaff;
            HasTicket = hasTicket;            
        }
    }    
}