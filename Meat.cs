using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Meat : Product
    {
        public double FatPercent { get; set; }
        public string MeatType { get; set; }

        public Meat(
            string name,
            double pricePerKg,
            double quantityKg,
            bool isVegeterian,
            double fatPercent,
            string meatType
            ) : base(name, pricePerKg, quantityKg, isVegeterian)
        {
            FatPercent = fatPercent;
            MeatType = meatType;
        }

        public double GetDiscount()
        {
            if (QuantityKg >= 3)
            {
                return 15;
            }
            else if (QuantityKg >= 2)
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Жирность: {FatPercent}, Вид мяса: {MeatType}, Скидка: {GetDiscount()}";
        }
    }
}
