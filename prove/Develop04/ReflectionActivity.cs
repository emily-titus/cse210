public class ReflectionActivity : Activity
{
    private List<string> _promptList;
    private List<string> _reflectionList;

    public ReflectionActivity(string name = "Reflection", string desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, desc)
    {
        _promptList = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _reflectionList = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }
    public void Reflection()
    {
        StartActivity();
        int duration = _duration - 7;
        Random rand = new Random();
        System.Console.WriteLine(_promptList.ElementAt(rand.Next(_promptList.Count)));
        DisplayAnimation(3);
        duration -= 3;
        while (duration > 0)
        {
            int i = 0;
            System.Console.WriteLine(_reflectionList.ElementAt(i));
            i++;
            DisplayAnimation(5);
            duration -= 5;
        }
        EndActivity();

    }


}