using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Apple : Product, IDiscountable
    {
       public string Variety {  get; set; }
       public string Country { get; set; }

        public Apple(
            string name, 
            double pricePerKg, 
            double quantityKg, 
            string variety,
            string country
            ) : base(name, pricePerKg, quantityKg, true)
        {
            Variety = variety;
            Country = country;
        }

        public double GetDiscount()
        {
            if(QuantityKg >= 3)
            {
                return 0.20;
            }
            else if (QuantityKg >= 2)
            {
                return 0.10;
            }
            else
            {
                return 0.5;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", сорт: {Variety}, страна: {Country}, скидка: {GetDiscount() * 100}%";
        }
    }
}
