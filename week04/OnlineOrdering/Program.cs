using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address("123 Maple Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Sarah Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "A101", 25.00, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "A102", 75.00, 1));
        order1.AddProduct(new Product("USB-C Hub", "A103", 30.00, 1));

        // Order 2 - Non-USA customer
        Address address2 = new Address("45 King Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Liam Chen", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Desk Lamp", "B201", 20.00, 3));
        order2.AddProduct(new Product("Notebook Set", "B202", 12.50, 4));

        // Display Order 1
        Console.WriteLine("Order 1");
        Console.WriteLine("-------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("Order 2");
        Console.WriteLine("-------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():0.00}");
    }
}