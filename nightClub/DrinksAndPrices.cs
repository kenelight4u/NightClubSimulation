using System.Collections.Generic;

namespace NightClub
{
    public class Drinks
    {
        public decimal Andre { get; private set; }
        public decimal Smenorf { get; private set; }
        public decimal Beer { get; private set; }
        public decimal Don_Simon { get; private set; }
        public decimal Shisha { get; private set; }
        public decimal Cocaine { get; private set; }

        public Drinks()
        {
            this.Andre = 1000;
            this.Smenorf = 2000;
            this.Beer = 3000;
            this.Don_Simon = 4000;
            this.Shisha = 1000;
            this.Cocaine = 5000;
        }
    }

}