public class Order
{
    private Customer _customer;
    private bool _isAmerican;
    private List<Product> _products = new List<Product>();
    private int _shipCost;
    private double _total;

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
        _isAmerican = customer.IsAmerican();
        SetShipCost();
    }

    public void SetShipCost()
    {
        if (_isAmerican)
        {
            _shipCost = 5;
        }
        else
        {
            _shipCost = 35;
        }
    }

    public int GetShipCost()
    {
        return _shipCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalcSubTotal()
    {
        double subTotal = 0;
        foreach (var product in _products)
        {
            subTotal = subTotal + product.ProductCost();
        }
        return subTotal;
    }

    public double CalcTotal()
    {
        _total = CalcSubTotal() + _shipCost;
        return _total;
    }

    public void PackingLabel()
    {
        Console.WriteLine();
        foreach (var product in _products)
        {
            string name = product.GetName();
            int id = product.GetId();
            int quantity = product.GetQuantity();
            Console.WriteLine($"Item {id} - {name} x {quantity}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetAddress());
    }
}