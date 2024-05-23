using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void Run();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the " + _name + " Activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }
}
