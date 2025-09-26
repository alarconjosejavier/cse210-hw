using System;

class Program
{
    static void Main(string[] args)
    {
        //creating address for first customer
        Address address1 = new("5267 Landswood Lane", "Herriman", "Utah", "United States");
        // adding address to customer1
        Customer customer1 = new Customer("Jose Alarcon", address1);


        // creating order for customer 1
        Order order1 = new Order(customer1);
        // creating product 1
        Product product1 = new Product("iPhone 17", "52445", 699.99m, 2);
        // creating product 2
        Product product2 = new Product("iPhone 17 pro", "52445", 1000m, 1);
        // adding product1 to customer1
        order1.AddProduct(product1);
        // adding product2 to customer1
        order1.AddProduct(product2);

        // creating second order for customer1
        Order order2 = new Order(customer1);
        Product product3 = new Product("iPhone 15", "52445", 499.99m, 1);
        // creating product 2
        Product product4 = new Product("iPhone 15 pro", "52445", 800m, 1);
        // adding product3 to customer1
        order2.AddProduct(product3);
        // adding product4 to customer1
        order2.AddProduct(product4);

        // obtaining results
        string label1 = order1.GetPackingLabel();
        string shipping1 = order1.GetShippingLabel();
        decimal price1 = order1.GetTotalCost();

        // obtaining results
        string label2 = order2.GetPackingLabel();
        string shipping2 = order2.GetShippingLabel();
        decimal price2 = order2.GetTotalCost();

        // printing results
        Console.WriteLine($"{label1}{shipping1} \n{price1}");

        // printing results
        Console.WriteLine($"{label2}{shipping2} \n{price2}");




    }
}