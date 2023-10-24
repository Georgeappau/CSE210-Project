using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("#5 Boye St", "Adenta", "NY", "USA");
        Address address2 = new Address("#39 Oxford St", "Ottawa", "CN", "Canada");

        // Create customers
        Customer customer1 = new Customer("Clifford Ashong", address1);
        Customer customer2 = new Customer("Kevin Amevor", address2);

        // Create products
        Product product1 = new Product("Car wash soap", "BP70", 10.0m, 2);
        Product product2 = new Product("Brown sugar", "MN12", 15.0m, 3);
        Product product3 = new Product("Detergent", "XY45", 20.0m, 1);

        // Create orders
        Order firstOrder = new Order(customer1);
        Order secondOrder = new Order(customer2);

        firstOrder.AddProduct(product1);
        firstOrder.AddProduct(product2);
        secondOrder.AddProduct(product2);
        secondOrder.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(firstOrder.GetPackingLabel());
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${firstOrder.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(secondOrder.GetPackingLabel());
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${secondOrder.CalculateTotalCost()}");
    }
}
