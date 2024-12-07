using System;

class Program
{
    static void Main(string[] args)
    {
        // Product product1 = new Product("Pen", 33442234, 50.00, 5);

        // Console.WriteLine(product1.TotalCost());

        // Address(string street, string city, string state, string country)
        Address addr1 = new Address("9 magboro", "magboro", "Ogun", "Nigeria");
        Address addr2 = new Address("10 Walkyire", "Washington DC", "Washington", "USA");
        // Console.WriteLine(addr.DisplayAddress());

        // Customer(string name, Address addr)
        Customer cust1 = new Customer("John Adebayo", addr1);
        Customer cust2 = new Customer("John Adebayo", addr2);

        // Product(string name, int id, double price, int qty)
        Product product1 = new Product("Pen", 35343, 500.00, 3);
        Product product2 = new Product("Pencil", 53453, 200.00, 10);
        Product product3 = new Product("Mouse", 43533, 230.00, 30);
        Product product4 = new Product("Laptop", 63433, 12430.00, 1);

        // Console.WriteLine(product2.TotalCost());
        //  Order(List<Product> product, Customer customer) 
        Order order1 = new Order(new List<Product>{ product1, product2}, cust1);
        Order order2 = new Order(new List<Product>{ product1, product3, product4}, cust2);
        
        Console.Clear();
        DisplayToScreen(order1);
        DisplayToScreen(order2);



        void DisplayToScreen(Order order) {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"Total: ${order.TotalCostOrder()}");

            Console.WriteLine("================================================================================\n");
            Console.WriteLine($"Shipping Fee: ${order.ShippingCost()}");
            Console.WriteLine($"Total: ${order.TotalPrice()}");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }
    }
}