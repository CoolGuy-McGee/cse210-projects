public class PromptList
{   
    public List<string> _prompts = new List<string>
        {
            "What was the best part of my day?",
            "If I had one thing I could do over today, what would it be?",
            "What do I want to do better tomorrow?",
            "What goals did I accoplish today?",
            "How does today compare to yesterday?"
        };
    
    public string GeneratePrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        return _prompts[number];
    }
}