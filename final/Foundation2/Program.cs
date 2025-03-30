using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Product product1 = new Product("Potato", 1, 1.5, 15);
        Product product2 = new Product("Apple", 2, 3, 20);
        Product product3 = new Product("Strawberry", 3, 5, 100);
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        Address address = new Address("123 cherry st", "Rexburg", "ID", "USA");
        Customer customer = new Customer("Sally B", address);
        Order order1 = new Order(products, customer);
        products = new List<Product>();
        product1 = new Product("Cookie", 4, 2, 7);
        product2 = new Product("Cake", 5, 10, 2);
        product3 = new Product("Lemonade", 6, 4, 5);
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        address = new Address("456 blossom st", "Mocari", "Monteverde", "Colombia");
        customer = new Customer("Mark W", address);
        Order order2 = new Order(products, customer);
        System.Console.WriteLine($"{order1.PackingLabel()}${order1.CalcTotalCost()}\n{order1.ShippingLabel()} \n");
        System.Console.WriteLine($"{order2.PackingLabel()}${order2.CalcTotalCost()}\n{order2.ShippingLabel()}");
    }
}