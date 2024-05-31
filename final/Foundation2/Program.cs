using System;

class Program
{
    static void Main()
    {

        Address address1 = new Address("16 Dagbreek St", "Dawn Park", "Gauteng", "SA");
        Address address2 = new Address("4 Oak St", "Sommerset west", "Western Cape", "SA");


        Customer customer1 = new Customer("Tumisang Msiza", address1);
        Customer customer2 = new Customer("Langelihle Ndebele", address2);

        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Mouse", "P002", 49.99m, 2);
        Product product3 = new Product("Monitor", "P003", 199.99m, 1);
        Product product4 = new Product("Keyboard", "P004", 89.99m, 1);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
