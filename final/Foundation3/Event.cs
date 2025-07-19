using System.ComponentModel;

public class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;
    private string _type;
    private string _typeMessage;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetEventType(string type, string typeMessage)
    {
        _type = type;
        _typeMessage = typeMessage;
    }

    public DateOnly GetEventDate()
    {
        return _date;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"\nYou are invited! - {_title}");
        Console.WriteLine($"What - {_description} ");
        Console.WriteLine($"When - {_date} at {_time}");
        Console.WriteLine($"Where - {_address.GetAddress()}");
    }

    public void FullDetails()
    {
        Console.WriteLine($"\nYou are invited! - {_title} {_type}");
        Console.WriteLine($"What - {_description} {_typeMessage} ");
        Console.WriteLine($"When - {_date} at {_time}");
        Console.WriteLine($"Where - {_address.GetAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}