class Program
{
    static void Main(string[] args)
    {
       
        Address address1 = new Address { Street = "123 Main St", City = "Anytown", State = "CA", Country = "USA" };
        Address address2 = new Address { Street = "456 Elm St", City = "Otherville", State = "TX", Country = "USA" };

  
        Customer customer1 = new Customer { Name = "John Doe", Address = address1 };
        Customer customer2 = new Customer { Name = "Jane Smith", Address = address2 };


        Product product1 = new Product { Id = 1, Name = "Product 1", Price = 10, Quantity = 2 };
        Product product2 = new Product { Id = 2, Name = "Product 2", Price = 20, Quantity = 1 };
        Product product3 = new Product { Id = 3, Name = "Product 3", Price = 15, Quantity = 3 };

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

    
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost()}");
    }
}