using LAB09;

Cart cart1 = new Cart();

cart1.AddToCart(new Meat("Говядина", 26.34, 3.2, 18, "Говядина"));
cart1.AddToCart(new Meat("Куриное филе", 23.34, 1, 5, "Курица"));
cart1.AddToCart(new Beans("Чечевица", 6, 1.2, "Чечевица", false));
cart1.AddToCart(new Beans("Красная фасоль", 5.50, 2, "Красная фасоль", true));
cart1.AddToCart(new Apple("Яблоко Голден", 7, 3, "Голден", "Польша"));
Console.WriteLine();

Cart cart2 = new Cart();

cart2.AddToCart(new Meat("Свинина", 22.34, 4.2, 22, "Свинина"));
cart2.AddToCart(new Meat("Индейка", 30, 3, 7, "Индейка"));
cart2.AddToCart(new Beans("Горох", 5, 1.7, "Горох", false));
cart2.AddToCart(new Beans("Нут", 9.50, 1.9, "Нут", true));
cart2.AddToCart(new Apple("Яблоко Гала", 8, 4, "Гала", "Беларусь"));
Console.WriteLine();

Console.WriteLine("Корзина 1: ");
foreach(Product p in cart1.Products)
{
    Console.WriteLine(p);
}
Console.WriteLine($"Стоимость без скидки: {cart1.CalculateTotalCost():F2}BYN. ");
Console.WriteLine($"Стоимость со скидкой: {cart1.CalculateDiscountedCost():F2}BYN. ");
Console.WriteLine($"Средняя стоимость вегетарианских товаров: {cart1.CalculateAvgVegeterianCost():F2}BYN. ");
Console.WriteLine();

Console.WriteLine("Корзина 2: ");
foreach (Product p in cart2.Products)
{
    Console.WriteLine(p);
}
Console.WriteLine($"Стоимость без скидки: {cart2.CalculateTotalCost():F2}BYN. ");
Console.WriteLine($"Стоимость со скидкой: {cart2.CalculateDiscountedCost():F2}BYN. ");
Console.WriteLine($"Средняя стоимость вегетарианских товаров: {cart2.CalculateAvgVegeterianCost():F2}BYN. ");
Console.WriteLine();

Console.WriteLine("Сравнение корзин: ");
if(cart1 == cart2)
{
    Console.WriteLine("Корзины равны по стоимости. ");
}
else
{
    Console.WriteLine("Корзины не равны по стоимости. ");
}
Console.WriteLine();

cart1.DeleteFromCart(cart1.Products[0]);
foreach (Product p in cart1.Products)
{
    Console.WriteLine(p);
}

