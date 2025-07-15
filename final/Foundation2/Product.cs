public class Product
{
    private string _name;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public double ProductCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}