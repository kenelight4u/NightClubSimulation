using System.Collections.Generic;

namespace NightClub
{
    public class Staff : Person
    {
        public bool StaffId { get; set; }

        private List<string> ids = new List<string>() {"STF001", "STF002", "STF003", "STF004", "STF005", "STF006", "STF007", "STF008"};

        public Staff(string name, string id)
        {
            Name = name;
            StaffId = ids.Contains(id);
        }
    }

}