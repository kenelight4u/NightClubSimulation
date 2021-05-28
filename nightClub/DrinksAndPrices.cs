using System.Collections.Generic;

namespace NightClub
{
    public class Drinks
    {
        public decimal Andre { get; private set; }
        public decimal Smenorf { get; private set; }
        public decimal Beer { get; private set; }
        public decimal Don_Simon { get; private set; }

        public Drinks()
        {
            this.Andre = 1000;
            this.Smenorf = 2000;
            this.Beer = 3000;
            this.Don_Simon = 4000;
        }
    }

}