using System;
using System.Collections.Generic;
using System.Text;

namespace LAB09
{
    public class Cart
    {
        public int MaxAmount { get; set; } = 5;
        private List<Product> products = new List<Product>();
        public List<Product> Products => products;            //для чтения

        public void AddToCart(Product p)
        {
            if(products.Count >= MaxAmount)
            {
                Console.WriteLine("Корзина заполнена! ");
                return;                                                  //return для выхода(завершает метод), чтобы нельзя было добавить больше 5 товаров
            }

            products.Add(p);
            Console.WriteLine($"Товар {p.Name} добавлен в корзину. ");
        }

        public void DeleteFromCart(Product p)
        {
            if (products.Remove(p))            //удаляет по ссылке
            {
                Console.WriteLine($"Товар {p.Name} удален из корзины. ");
            }
            else
            {
                Console.WriteLine("Товар не найден. ");
            }
        }

        public double CalculateTotalCost()
        {
            double total = 0;

            foreach (Product p in products)
            {
                total += p.GetCost();
            }

            return total;
        }

        public double CalculateDiscountedCost()    //////разобрать
        {
            double total = 0;

            foreach (Product p in products)
            {
                double discount = 0;

                if(p is IDiscountable d)
                {
                    discount = d.GetDiscount();
                }

                total += p.GetCost() * (1 - discount);
            }

            return total;
        }

        public double CalculateAvgVegeterianCost()
        {
            double sum = 0;
            int count = 0;

            foreach(Product p in products)
            {
                if (p.IsVegetarian)
                {
                    sum += p.GetCost();
                    count++;
                }
            }

             if(count == 0)
            {
                return 0;
            }

             return sum / count;    
        }

        public static bool operator ==(Cart c1, Cart c2)           
        {
            return Math.Round(c1.CalculateDiscountedCost(), 2) == Math.Round(c2.CalculateDiscountedCost(), 2);
        }

        public static bool operator !=(Cart c1, Cart c2)
        {
            return !(c1 == c2);
        }
    }
}
