using System;

public class Order {
    private List<Product> _products;
    private Customer _customers;

    public Order(List<Product> product, Customer customer) {
        _products = product;
        _customers = customer;
    }

    public double TotalCostOrder() {
        double sum = 0;
        foreach (var productCost in _products){
            sum += productCost.TotalCost();
            // Console.WriteLine(productCost.TotalCost());
        }
        return sum;
    }
    public string PackingLabel() {
        string label = "";
        foreach (Product item in _products)
        {
            label += $"(#{item.GetProductId()}): {item.GetName()} ({item.GetQty()})- ${item.GetPrice()}\n";
        }
        return label;
    }
    public string ShippingLabel() {
        return $"Name: {_customers.GetName()}\nAddress: {_customers.GetAddress()}\n";
    }
    
    public double ShippingCost() {
        if (_customers.LivesInUSA() == true) {
            return (double) 5.00;
        } else {
            return (double) 35.00;
        }
    }
    public double TotalPrice() {
        return TotalCostOrder() + ShippingCost();
    }
}