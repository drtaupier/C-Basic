using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public static class BasicProblems
    {
        public static void SumTwoNumbers()
        {
            //Enter the first number
            Console.Write("Enter your first number:");
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out int num1);

            //Enter the second number
            Console.Write("Enter your second number ");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out int num2);

            //Display result
            var result = num1 + num2; 
            Console.WriteLine($"The result is: {result}" );
        }
        public static void MultiplyTwoNumbers()
        {
            //Enter the first number
            Console.Write("Enter your firs number: ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int numero1);

            //Enter the second number
            Console.Write("Enter your second number: ");
            inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int numero2);

            //Display result
            var result = numero1 * numero2;
            Console.WriteLine($"The result is: {result}");
        }
        public static void Saludo()
        {
            //Enter the name
            Console.Write("Hello, what's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
        public static void GiveMeANumber()
        {
            //Enter the first number between 1 to 10
            Console.Write("Hey!, give me a number between 1 to 10: ");
            var input1 = Console.ReadLine();
            int.TryParse(input1, out int num1);

            if(num1 < 0 || num1 > 10)
            {
                Console.WriteLine("Please, the number should be between 1 to 10");
            }
            else
            {
            //Enter the second number between 1 to 10
            Console.Write("now, give me a second number between 1 to 10: ");
            input1 = Console.ReadLine();
            int.TryParse(input1, out int num2);
                if(num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Please, the number should be between 1 to 10");
                }
                else
                {
                    var result = num1 + num2;
                    Console.WriteLine($"The result is: {result}");
                }
            }

        }
    }
}
