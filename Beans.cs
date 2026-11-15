using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Beans : Product, IDiscountable
    {
        public string BeanType { get; set; }
        public bool Organic { get; set; }

        public Beans(
            string name,
            double pricePerKg,
            double quantityKg,
            string beanType,
            bool organic
            ) : base(name, pricePerKg, quantityKg, true)
        {
            BeanType = beanType;
            Organic = organic;
        }

        public double GetDiscount()
        {
            if (Organic)
            {
                if(QuantityKg < 3)
                {
                    return 0.5;
                }
                else 
                {
                    return 0.10;
                }
            }
            else
            {
                if (QuantityKg < 3)
                {
                    return 0.10;
                }
                else 
                {
                    return 0.15;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", вид: {BeanType}, органический: {Organic}, скидка: {GetDiscount() * 100}%";
        
        }
    }
}
