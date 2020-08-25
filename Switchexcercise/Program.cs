using System;

namespace Switchexcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
           
            var userSubject = (Console.ReadLine());

            //use a switch statement - to handle various scenarios that could occur

            
        }

        public static void subjectResponses(string userSubject)
        {
            switch (userSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("Good to know");
                    break;
                case "math":
                    Console.WriteLine("You like numbers eh? Sweet.");
                    break;
                case "social Sciences":
                    Console.WriteLine("They still teach that? Good for you.");
                    break;
                case "history":
                    Console.WriteLine("If you don't know where you came from how do you know where your goin?" +
                        "And you're doomed to repeat.");
                    break;
                case "science":
                    Console.WriteLine("Yee of little faith");
                    break;
                default:
                    Console.WriteLine("You got some odd interests");
                    break;
            }
        }
    }
}
