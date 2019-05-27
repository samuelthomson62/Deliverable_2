using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPlacesToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer1, answer2;
            bool loop = true;
            int answer2int;

            Console.WriteLine("Hey, what do you want to do today?");
            Console.WriteLine("Are you in the mood for...");
            Console.WriteLine("1 Action");
            Console.WriteLine("2 Chilling");
            Console.WriteLine("3 Danger");
            Console.WriteLine("4 Good Food");

            while (loop == true)
            {
                answer1 = Console.ReadLine();

                if (answer1 == "1" || answer1 == "1)")
                {
                    Console.WriteLine("Okay, you should go Stock Car Racing!");
                    loop = false;
                }
                else if (answer1 == "2" || answer1 == "2)")
                {
                    Console.WriteLine("Okay, you should go Hiking!");
                    loop = false;
                }
                else if (answer1 == "3" || answer1 == "3)")
                {
                    Console.WriteLine("Okay, you should go Skydiving!");
                    loop = false;
                }
                else if (answer1 == "4" || answer1 == "4)")
                {
                    Console.WriteLine("Okay, you should go to Taco Bell!");
                    loop = false;
                }
                else
                {
                    loop = true;
                    Console.WriteLine("Sorry I don't understand. Please try answering that again.");
                }
            }

            while (loop == false)
            {
                Console.WriteLine("How many people are you bringing with you?");
                answer2 = Console.ReadLine();
                int.TryParse(answer2, out answer2int);

                if (answer2 == "0")
                {
                    Console.WriteLine("You should travel in sneakers.");
                    loop = true;
                }
                else if (answer2 == "1" || answer2 == "2" || answer2 == "3" || answer2 == "4")
                {
                    Console.WriteLine("You should travel in a sedan.");
                    loop = true;
                }
                else if (answer2 == "5" || answer2 == "6" || answer2 == "7" || answer2 == "8" || answer2 == "9" || answer2 == "10")
                {
                    Console.WriteLine("You should travel in a Volkswagen bus.");
                    loop = true;
                }
                else if (answer2int > 10)
                {
                    Console.WriteLine("You should travel in an airplane.");
                    loop = true;
                }
                else
                {
                    Console.WriteLine("I don't understand. Please try answering that again.");
                }
            }
            Console.WriteLine("Have fun! Goodbye.");
            Console.ReadKey();
        }
    }
}