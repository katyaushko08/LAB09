using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Product
    {
        public string Name { get; set; }
        public double PricePerKg { get; set; }
        public double QuantityKg { get; set; }
        public bool IsVegeterian { get; set; }

        public Product(string name, double pricePerKg, double quantityKg, bool isVegeterian)
        {
            Name = name;
            PricePerKg = pricePerKg;
            QuantityKg = quantityKg;
            IsVegeterian = isVegeterian;
        }

        public double GetCost()
        {
            return PricePerKg * QuantityKg;
        }

        public override string ToString()
        {
            return $"{Name}, Стоимость за кг: {PricePerKg}, Количество кг: {QuantityKg}, Вегетарианскмй: {IsVegeterian}";
        }
    }
}
