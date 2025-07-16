public class Outdoor : Event
{
    private string _weatherStatement;

    public Outdoor(string title, string description, DateOnly date, TimeOnly time, string address) : base(title, description, date, time, address)
    {
        DetermineWeather(GetEventDate());
        SetEventType("Outdoor Gathering", $"{_weatherStatement}");
    }


    // I made a creative bit for the weather message. I based the message on the season the date of the event occurs.
    public void DetermineWeather(DateOnly date)
    {
        if (date.Month >= 01 && date.Month < 03)
        {
            _weatherStatement = "Bring a warm jacket, it's cold outside!";
        }
        if (date.Month >= 04 && date.Month < 06)
        {
            _weatherStatement = "Bring a light sweater and maybe an umbrella, it's spring!";
        }
        if (date.Month >= 07 && date.Month < 09)
        {
            _weatherStatement = "It's summertime! Dress cool.";
        }
        if (date.Month >= 10 && date.Month <= 12)
        {
            _weatherStatement = "Bring a heavy coat and gloves, it's cold with a chance of snow.";
        }
    }
}