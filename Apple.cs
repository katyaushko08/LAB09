using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Apple : Product
    {
       public string Variety {  get; set; }
       public string Country { get; set; }

        public Apple(
            string name, 
            double pricePerKg, 
            double quantityKg, 
            bool isVegeterian,
            string variety,
            string country
            ) : base(name, pricePerKg, quantityKg, isVegeterian)
        {
            Variety = variety;
            Country = country;
        }
    }
}
