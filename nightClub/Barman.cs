using System;
using System.Collections.Generic;

namespace nightClub
{
    public class BarMan
    {
        private static decimal ScanToGetPrice(Products brand)
        {
            if (brand.QrCode != null)
            {
                return Convert.ToDecimal(brand.Price);
            }
            throw new Exception("INVALID QRCODE");
        }

        public static decimal GetTotalPricesOfGood(List<Products> brands)
        {
            decimal totalPrice = 0.0M;
            foreach (var item in brands)
            {
                totalPrice += Convert.ToDecimal(ScanToGetPrice(item));
                // totalPrice += Convert.ToDecimal(item.Price);
            }            
            return totalPrice;
        }


    }
}