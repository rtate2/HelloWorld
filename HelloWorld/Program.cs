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
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter parameter values.", "Canadian English", "North American English", "Australian English");
                Console.Read();
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + Environment.NewLine);
                }
                Console.Read();
            }

            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey();

            var a = 10;
            var b = 3;

            Console.WriteLine(a > b);
            
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
                    Console.ReadKey();
                }
            }
        }
    }
}
