namespace Animals
{
    abstract class Fish : Animal  // Mark as abstract to indicate it's a base class
    {
        public string ScaleColor { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the fish makes a bubbling sound.");
        }

        public virtual void Swim()
        {
            Console.WriteLine($"{Name} the fish is swimming.");
        }
    }
}
