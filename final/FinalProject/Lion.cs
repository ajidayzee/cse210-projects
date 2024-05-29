namespace Animals
{
    class Lion : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the lion roars");
        }

        public override void GiveBirth()
        {
            Console.WriteLine($"{Name} the lion is giving birth.");
        }
    }
}