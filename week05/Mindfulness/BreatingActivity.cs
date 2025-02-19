public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            ShowCountDown(3);
            elapsed += 3;

            if (elapsed >= _duration) break;

            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
            ShowCountDown(3);
            elapsed += 3;
        }
    }
}