using System;
using static System.Int32;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter case (-1 to exit): ");
                var userInput = Console.ReadLine();
                TryParse(userInput, out var selection);

                if (selection > 0)
                {
                    switch (selection)
                    {
                        case 1:
                            BasicProblems.SumTwoNumbers();
                            break;
                        case 2:
                            BasicProblems.MultiplyTwoNumbers();
                            break;
                        case 3:
                            BasicProblems.Greeting();
                            break;
                        case 4:
                            BasicProblems.Multiple_numbers();
                            break;
                        case 5:
                            BasicProblems.IsEvenOrOdd();
                            break;
                        case 6:
                            BasicProblems.WhatIsYourAge();
                            break;
                        case 7:
                            BasicProblems.WhatIsYourAge();
                            break;
                        default:
                            Console.WriteLine("Nothing to do.");
                            break;
                    }
                }
                else if (selection == -1)
                {
                    Console.WriteLine("Exiting. Bye!");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
