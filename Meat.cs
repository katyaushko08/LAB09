using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Meat : Product, IDiscountable
    {
        public double FatPercent { get; set; }
        public string MeatType { get; set; }

        public Meat(
            string name,
            double pricePerKg,
            double quantityKg,
            double fatPercent,
            string meatType
            ) : base(name, pricePerKg, quantityKg, false)
        {
            FatPercent = fatPercent;
            MeatType = meatType;
        }

        public double GetDiscount()
        {
            if (QuantityKg >= 3)
            {
                return 0.15;
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
            return base.ToString() + $", жирность: {FatPercent}%, вид мяса: {MeatType}, Скидка: {GetDiscount() * 100}%";
        }
    }
}
