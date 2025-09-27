using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        {
            Address addr1 = new Address("123 Elm St", "Springfield", "IL", "USA");
            Customer cust1 = new Customer("John Doe", addr1);
            Order order1 = new Order(cust1);
            order1.AddProduct(new Product("Widget", "W123", 10.0, 2));
            order1.AddProduct(new Product("Gadget", "G456", 15.0, 1));

            Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
            Customer cust2 = new Customer("Jane Smith", addr2);
            Order order2 = new Order(cust2);
            order2.AddProduct(new Product("Thingamajig", "T789", 20.0, 3));
            order2.AddProduct(new Product("Doohickey", "D012", 5.0, 5));

            DisplayOrder(order1);
            Console.WriteLine("\n----------------------\n");
            DisplayOrder(order2);
        }

        static void DisplayOrder(Order order)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("\nShipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice():0.00}");
        }
    }
}