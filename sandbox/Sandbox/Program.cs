using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#");

        int number = 5;
        number = 8;
        number = number +3;
        Console.WriteLine($"Number is {number}");

        string color = "blue";
        Console.WriteLine($"The colour of my clothe is {color}");
        Console.WriteLine("The colour of my clothe is" + " " + color);

        Console.WriteLine("What is your Name?");
        string name = Console.ReadLine();
        Console.WriteLine($"My name is {name}");
        Console.WriteLine("My name is" + " " + name );

        if (number > 3)
        {
            Console.WriteLine($"Number is greater");
            Console.WriteLine("");
        }
    }
}