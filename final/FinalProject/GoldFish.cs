class Goldfish : Fish
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the goldfish makes a gentle bubbling sound.");
    }

    public new void Swim()  // Use the 'new' keyword to hide the inherited member
    {
        Console.WriteLine($"{Name} the goldfish is swimming.");
    }
}
