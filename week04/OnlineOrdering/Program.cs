using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1 Rhodesia Cottage", "Ascot", "Berkshire", "England");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP1", 657.00, 1));
        order1.AddProduct(new Product("Keyboard", "KB5", 50.50, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.GetTotalCost():0.00}\n");

        Address address2 = new Address("123 Main St", "Salt Lake City", "Utah", "USA");
        Customer customer2 = new Customer("Marry Sue", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book", "BK576", 15.00, 4));
        order2.AddProduct(new Product("Pen", "PN004", 50.50, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.GetTotalCost():0.00}");
    }
}