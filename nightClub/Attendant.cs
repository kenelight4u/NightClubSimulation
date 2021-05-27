using System;
using System.Collections.Generic;

namespace nightClub
{
    public class Attendant
    {
        private List<Products> brands;

       public Attendant()
       {
           brands = new List<Products>();
       }

        public List<Products> GetBrands()
        {
            return this.brands;
        }

        public string SaveOrderFromCustomer(string brandName)
        {
            Products product = new Products(brands.Count + 1, $"{brandName}  ");
            brands.Add(product);
            return product.BrandName;
        }

        public IEnumerable<string> GetSaveOrderFromCustomer()
        {
            foreach (var item in brands)
            {
                yield return item.BrandName + item.QrCode; 
            }
        }
        //Call for Bill Calculation
        public void PayBill()
        {
            decimal totalPriceOfItemsPurchased = PresentBillToCustomer(this.brands);
            Console.WriteLine($"{totalPriceOfItemsPurchased}");
        }

        //Calls BarMan to GetTotalPrice method
        private static decimal PresentBillToCustomer(List<Products> itemsPurchased)
        {
            decimal totalBill = BarMan.GetTotalPricesOfGood(itemsPurchased);
            return totalBill;
        }

        public void Clear()
        {
            brands.Clear();
        }
    }
}