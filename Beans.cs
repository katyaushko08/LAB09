using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Beans : Product
    {
        public string BeanType { get; set; }
        public bool Organic { get; set; }

        public Beans(
            string name,
            double pricePerKg,
            double quantityKg,
            bool isVegeterian,
            string beanType,
            bool organic
            ) : base(name, pricePerKg, quantityKg, isVegeterian)
        {
            BeanType = beanType;
            Organic = organic;
        }
    }
}
