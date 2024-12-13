public class Product {
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int qty) {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = qty;
    }

    public string GetName()
    {
        return _name;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQty()
    {
        return _quantity;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public double TotalCost() {
        return (double)_price * _quantity;
    }
}