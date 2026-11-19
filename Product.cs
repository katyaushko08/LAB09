using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Product
    {
        private double pricePerKg;
        private double quantityKg;
        public string Name { get; set; }
        public double PricePerKg 
        { 
            get {  return pricePerKg; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Цена не может быть отрицательной!");
                }
                pricePerKg = value;
            }
        }
        public double QuantityKg
        {
            get { return quantityKg; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Цена не может быть отрицательной!");
                }
                quantityKg = value;
            }
        }
        public bool IsVegetarian { get; set; }

        public Product(string name, double pricePerKg, double quantityKg, bool isVegetarian)
        {
            Name = name;
            PricePerKg = pricePerKg;
            QuantityKg = quantityKg;
            IsVegetarian = isVegetarian;
        }

        public double GetCost()
        {
            return PricePerKg * QuantityKg;
        }

        public override string ToString()
        {
            return $"{Name}: количество: {QuantityKg}кг, стоимость за кг: {PricePerKg}BYN, стоимость: {GetCost()}BYN";
        }
    }
}
