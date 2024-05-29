namespace Animals
{
    class Goldfish : Fish
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the goldfish makes a gentle bubbling sound.");
        }

        public override void Swim()
        {
            Console.WriteLine($"{Name} the goldfish is swimming.");
        }
    }
}
