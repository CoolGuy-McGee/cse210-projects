public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void performActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        string status = "running";
        while (status == "running")
        {
            DateTime currentTime = DateTime.Now;
            if (DateTime.Compare(currentTime, futureTime) < 0)
            {
                Console.Write("Breathe in... ");
                breatheInAnimation(4);
                Console.WriteLine();
                Console.Write("Breathe out... ");
                breatheOutAnimation(6);
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                status = "finished";
            }
        }
        _finalDuration = calculateFinalDuration(startTime);
    }

    // I created a more meaningful breathing animation that shows a period growing into an uppercase "O" to simulate inflating lungs.
    public void breatheInAnimation(int seconds)
    {
        seconds = seconds * 1000;
        seconds = seconds / 3;
        Console.Write(".");
        Thread.Sleep(seconds);

        Console.Write("\b \b");
        Console.Write("o");
        Thread.Sleep(seconds);

        Console.Write("\b \b");
        Console.Write("O");
        Thread.Sleep(seconds);
        Console.Write("\b \b");
    }

// I created a more meaningful breathing animation that shows an uppercase "O' shrinking into a period to simulate inflating lungs.
    public void breatheOutAnimation(int seconds)
    {
        seconds = seconds * 1000;
        seconds = seconds / 3;
        Console.Write("O");
        Thread.Sleep(seconds);

        Console.Write("\b \b");
        Console.Write("o");
        Thread.Sleep(seconds);

        Console.Write("\b \b");
        Console.Write(".");
        Thread.Sleep(seconds);
        Console.Write("\b \b");
    }
}