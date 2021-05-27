using System;

namespace nightClub
{
    public class Products
    {
        public int Id { get; private set; }

        public string BrandName { get; set; }

        public double Price { get; private set; }

        public string QrCode { get; private set; }

        public Products(int id, string name)
        {
            Id = id;
            BrandName = name;

            Random randomGen = new Random();
            this.QrCode = "QR" + randomGen.Next(1, 100).ToString();
            this.Price = 100 * randomGen.NextDouble();
        }   
    }
}