using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3); // Countdown for 3 seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(3); // Countdown for 3 seconds
        }

        DisplayEndingMessage();
    }
}
