public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void performActivity()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        int numItemsListed = 0;
        Console.WriteLine($"List as many responses you can to the following prompt:\n");
        Console.Write($" --- {_prompts[number]} --- \n\n");
        Console.Write("You may begin in: ");
        pauseWithCountdown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (DateTime.Compare(currentTime, futureTime) < 0)
        {
            Console.ReadLine();
            numItemsListed++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {numItemsListed} items!");
        _finalDuration = calculateFinalDuration(startTime);
    }
}