// Program Execution
class Program
{
    static void Main()
    {
        // Create Addresses
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Address address2 = new Address("456 Pine St", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("James Smith", address1);
        Customer customer2 = new Customer("Rachel Johnson", address2);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 25.50m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KEY789", 45.75m, 1));
        order2.AddProduct(new Product("Monitor", "MON321", 200.00m, 1));

        // Display Order Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
