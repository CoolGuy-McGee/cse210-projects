public class Reception : Event
{
    private string _emailRSVP;

    public Reception(string title, string description, DateOnly date, TimeOnly time, string address, string email) : base(title, description, date, time, address)
    {
        _emailRSVP = email;
        SetEventType("Reception", $"Please make sure to RSVP: {_emailRSVP}");
    }
}