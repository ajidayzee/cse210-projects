using System;

namespace Animals
{
    // Define the base class for all animals
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();
    }
}
