using System;
using Animals;
using System.Collections.Generic;

namespace ZooApp
{
    class Program
    {
        static void Main()
        {
            Lion lion = new Lion { Name = "Burna", Age = 3, FurColor = "Golden" };
            Sparrow sparrow = new Sparrow { Name = "Twe-Twe", Age = 1, FeatherColor = "Brown" };
            Goldfish goldfish = new Goldfish { Name = "Wizzy", Age = 2, ScaleColor = "Orange" };
            Snake snake = new Snake { Name = "Sule", Age = 5, SkinType = "Scales" };

            Zoo myZoo = new Zoo();
            myZoo.AddAnimal(lion);
            myZoo.AddAnimal(sparrow);
            myZoo.AddAnimal(goldfish);
            myZoo.AddAnimal(snake);

            int choice;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Make all animals in the zoo make a sound");
                Console.WriteLine("2. Perform additional behaviors");
                Console.WriteLine("3. List all animals in the zoo");
                Console.WriteLine("4. Add a new animal to the zoo");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1, 2, 3, 4, or 5): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            myZoo.MakeAllSounds();
                            break;
                        case 2:
                            PerformAdditionalBehaviors(lion, sparrow, goldfish, snake);
                            break;
                        case 3:
                            ListAllAnimals(myZoo);
                            break;
                        case 4:
                            AddNewAnimal(myZoo);
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, or 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (choice != 5);
        }

        static void PerformAdditionalBehaviors(Lion lion, Sparrow sparrow, Goldfish goldfish, Snake snake)
        {
            int choice;

            do
            {
                Console.WriteLine("Performing additional behaviors:");
                Console.WriteLine("1. Lion gives birth");
                Console.WriteLine("2. Sparrow builds a nest");
                Console.WriteLine("3. Goldfish swims");
                Console.WriteLine("4. Snake hisses");
                Console.WriteLine("5. Return to main menu");
                Console.Write("Enter your choice (1, 2, 3, 4, or 5): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            lion.GiveBirth();
                            break;
                        case 2:
                            sparrow.BuildNest();
                            break;
                        case 3:
                            goldfish.Swim();
                            break;
                        case 4:
                            snake.MakeSound();
                            break;
                        case 5:
                            Console.WriteLine("Returning to the main menu.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, or 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (choice != 5);
        }

        static void ListAllAnimals(Zoo zoo)
        {
            Console.WriteLine("Listing all animals in the zoo:");
            foreach (var animal in zoo.GetAnimals())
            {
                Console.WriteLine($"{animal.Name}, {animal.GetType().Name}");
            }
        }

        static void AddNewAnimal(Zoo zoo)
        {
            Console.WriteLine("Adding a new animal to the zoo:");
            Console.Write("Enter the name of the new animal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the age of the new animal: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Choose the type of the new animal:");
                Console.WriteLine("1. Mammal");
                Console.WriteLine("2. Bird");
                Console.WriteLine("3. Fish");
                Console.WriteLine("4. Reptile");
                Console.Write("Enter your choice (1, 2, 3, or 4): ");

                if (int.TryParse(Console.ReadLine(), out int typeChoice))
                {
                    switch (typeChoice)
                    {
                        case 1:
                            Console.Write("Enter the fur color of the mammal: ");
                            string furColor = Console.ReadLine();
                            Mammal newMammal = new Mammal { Name = name, Age = age, FurColor = furColor };
                            zoo.AddAnimal(newMammal);
                            break;
                        case 2:
                            Console.Write("Enter the feather color of the bird: ");
                            string featherColor = Console.ReadLine();
                            Bird newBird = new Bird { Name = name, Age = age, FeatherColor = featherColor };
                            zoo.AddAnimal(newBird);
                            break;
                        case 3:
                            Console.Write("Enter the scale color of the fish: ");
                            string scaleColor = Console.ReadLine();
                            Fish newFish = new Goldfish { Name = name, Age = age, ScaleColor = scaleColor };
                            zoo.AddAnimal(newFish);
                            break;
                        case 4:
                            Console.Write("Enter the skin type of the reptile: ");
                            string skinType = Console.ReadLine();
                            Reptile newReptile = new Reptile { Name = name, Age = age, SkinType = skinType };
                            zoo.AddAnimal(newReptile);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Animal not added.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Animal not added.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Animal not added.");
            }
        }
    }
}
