public class BreathingActivity : Activity
{
    public BreathingActivity(string name = "Breathing", string desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, desc)
    {

    }

    public void Breathing()
    {
        StartActivity();
        int duration = _duration - 7;
        while (duration > 0)
        {
            System.Console.WriteLine("Breathe in...");
            DisplayAnimation(3);
            System.Console.WriteLine("Breathe out...");
            DisplayAnimation(3);
            duration -= 6;
        }
        EndActivity();
    }
}