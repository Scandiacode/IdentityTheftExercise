using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Identity Stealer!");
            
            Console.WriteLine("Can you give me your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Can you also give me your hometown?");
            string town = Console.ReadLine();

            Console.WriteLine("Lastly can you give me your favorite food?");
            string favfood = Console.ReadLine();

            Console.WriteLine($"Your name is {name}. Your age is {age}. Your hometown is {town}. Your favorite food is {favfood}.");
        }
    }
}
