using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a scripture instance
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

            // Displaying the complete scripture
            Console.WriteLine("Complete Scripture:");
            Console.WriteLine(scripture.GetFullScripture());

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            while (input != "quit")
            {
                // Clear the console
                Console.Clear();

                // Hide a few random words
                scripture.HideRandomWords();

                // Display the scripture with hidden words
                Console.WriteLine("Hidden Scripture:");
                Console.WriteLine(scripture.GetHiddenScripture());

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                input = Console.ReadLine();
            }
        }
    }

    class Scripture
    {
        private string reference;
        private List<Word> words;

        public Scripture(string reference, string text)
        {
            this.reference = reference;
            InitializeWords(text);
        }

        private void InitializeWords(string text)
        {
            string[] wordArray = text.Split(' ');
            words = new List<Word>();
            foreach (string word in wordArray)
            {
                words.Add(new Word(word));
            }
        }

        public string GetFullScripture()
        {
            return $"{reference}: {string.Join(" ", words.Select(w => w.Text))}";
        }

        public string GetHiddenScripture()
        {
            return $"{reference}: {string.Join(" ", words.Select(w => w.IsHidden ? "_____" : w.Text))}";
        }

        public void HideRandomWords()
        {
            Random rand = new Random();
            int wordsToHide = rand.Next(1, words.Count / 2); // Hide up to half of the words
            for (int i = 0; i < wordsToHide; i++)
            {
                int index = rand.Next(words.Count);
                words[index].IsHidden = true;
            }
        }

        public bool AllWordsHidden()
        {
            return words.All(w => w.IsHidden);
        }
    }

    class Word
    {
        public string Text { get; }
        public bool IsHidden { get; set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }
    }
}
