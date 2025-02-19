public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation(3);
            elapsed += 3;

            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            ShowAnimation(3);
            elapsed += 3;
        }
    }
}