using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which dialect would you like?");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            var answer = Console.ReadLine().ToLower().Trim();

            switch (answer)
            {
                case "south african":
                    Console.WriteLine("Hallo!");
                    break;
                case "west african":
                    Console.WriteLine("Aweh!");
                    break;
                default:
                    Console.WriteLine("Howdy, y'all!");
                    break;
            }

            Console.WriteLine("Please enter your full name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, thanks for using this app.");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Bird" };
            
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (var animal in animals)
            {
                var numberOfVowels = 0;
                foreach (var animalChar in animal)
                {
                    foreach (var vowel in vowels)
                    {
                        if (vowel == animalChar)
                        {
                            numberOfVowels++;
                        }
                    }
                }
                if (numberOfVowels >= 2)
                {
                    Console.WriteLine(animal);
                    //Console.ReadKey();
                }
            }

            var random = new Random();
            var randomAnimal = random.Next(0, animals.Length);

            Console.WriteLine("Please enter your favorite color.");
            var faveColor = Console.ReadLine();
            Console.WriteLine($"Would you like to have a {faveColor.ToLower()} {animals[randomAnimal].ToLower()}?");
        }
    }
}
