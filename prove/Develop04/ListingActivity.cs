using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have a few seconds to think and list...");
        ShowSpinner(_duration); // Show spinner for the specified duration

        Console.WriteLine("Time's up!");
        Console.WriteLine("Enter the number of items you listed:");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine($"You listed {count} items.");

        DisplayEndingMessage();
    }
}
