public class Customer
{
    private string _name;
    private Address _address;
    private bool _american;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _american = _address.USACheck();
    }

    public bool IsAmerican()
    {
        return _american;
    }

    public string GetAddress()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }
}