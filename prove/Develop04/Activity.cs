public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected double _finalDuration;

    public Activity()
    {
        _name = "Default string";
        _description = "Default String  ";
    }

    public void welcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Get ready... ");
        pauseWithSpinner(3);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    public void goodbye()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"You did a great job! ");
        pauseWithSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"Completed {_name} Activity in {_finalDuration} seconds.");
        pauseWithSpinner(5);
        Console.Clear();
    }

    public void pauseWithSpinner(int seconds)
    {
        //Thread.Sleep(3000);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        string status = "running";
        while (status == "running")
        {
            DateTime currentTime = DateTime.Now;
            if (DateTime.Compare(currentTime, futureTime) < 0)
            {
                Console.Write("|");
                Thread.Sleep(500);

                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(500);

                Console.Write("\b \b");
                Console.Write("--");
                Thread.Sleep(500);

                Console.Write("\b \b\b");
                Console.Write("\\");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            else
            {
                status = "finished";
            }
        }
    }

    public void pauseWithCountdown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {

            Console.Write($"{seconds - i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        //Console.Write("\b \b");
        Console.Write(0);
        Thread.Sleep(500);
        Console.Write("\b \b");
    }

    public double calculateFinalDuration(DateTime startTime)
    {
        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;
        return Math.Round(duration.TotalSeconds, 2);
    }
}