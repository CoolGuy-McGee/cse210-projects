using System.Security.Cryptography;

public class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void performActivity()
    {
        Random randomGenerator = new Random();
        List<string> tempWordsList = _questions;  // I created a seperate list for this activity so I could remove questions after they have been printed.
        int number = randomGenerator.Next(0, 4);
        int i = 9;
        Console.WriteLine($"Consider the following prompt:\n");
        Console.Write($" --- {_prompts[number]} --- \n\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        pauseWithCountdown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (DateTime.Compare(currentTime, futureTime) < 0)
        {
            if (i == 0)
            {
                break;
            }
            else
            {
                number = randomGenerator.Next(0, i);
            }
            number = randomGenerator.Next(0, i);
            i--;
            Console.Write($"{tempWordsList[number]} ");  // Removes the question from my temporary list, but keeps the master list intact.
            tempWordsList.RemoveAt(number);
            pauseWithSpinner(5);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        _finalDuration = calculateFinalDuration(startTime);
    }
}