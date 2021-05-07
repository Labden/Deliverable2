using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse;
            string pastResponse = null;
            do
            {
                Console.WriteLine("What would you like to say to the bot?");

                Console.WriteLine("hello");
                Console.WriteLine("bye");
                Console.WriteLine("sup");
                Console.WriteLine("hello there");

                userResponse = Console.ReadLine().ToLower();

                if (userResponse == pastResponse)
                {
                    Console.WriteLine("I'm sorry but you have already said that"); 
                }
                else if (userResponse == "hello")
                {
                    Console.WriteLine("Hi good to see you");
                    pastResponse = "hello";
                }
                else if (userResponse == "bye")
                {
                    Console.WriteLine("Goodbye");
                }
                else if (userResponse == "sup")
                {
                    Console.WriteLine("I am good");
                    pastResponse = "sup";
                }
                else if (userResponse == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                    pastResponse = "hello there";
                }
            } while (userResponse != "bye");
        }
    }
}