using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Easy St", "Springfield", "OR", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Hard Rd", "Whistler", "BC", "CA");
        Customer customer2 = new Customer("Pierre Merchant", address2);

        Product product1 = new Product("Ream of Paper", 34, 7.99, 6);
        Product product2 = new Product("Stapler", 23, 14.99, 3);
        Product product3 = new Product("Rolodex", 127, 24.99, 1);
        Product product4 = new Product("Desk Phone", 6, 79.99, 2);
        Product product5 = new Product("Sticky Notes", 9, 2.39, 10);
        Product product6 = new Product("Stapler", 23, 14.99, 7);

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.PackingLabel();
        Console.WriteLine($"Shipping: ${order1.GetShipCost()}");
        Console.WriteLine($"Total: ${Math.Round(order1.CalcTotal(), 2)}\n");
        order1.ShippingLabel();

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        order2.PackingLabel();
        Console.WriteLine($"Shipping: ${order2.GetShipCost()}");
        Console.WriteLine($"Total: ${Math.Round(order2.CalcTotal(), 2)}\n");
        order2.ShippingLabel();
    }
}