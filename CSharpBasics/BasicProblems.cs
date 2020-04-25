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
            Console.Write("Enter your first number: ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int num1);

            //Enter the second number
            Console.Write("Enter your second number: ");
            inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int num2);

            //Display result
            var result = num1 * num2;
            Console.WriteLine($"The result is: {result}");
        }
        public static void Greeting()
        {
            //Enter the name
            Console.Write("Hello, what's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
        public static void multiple_numbers()
        {
            Console.Write("Hey!, tell me how many times do you want to enter numbers to this operation between 1 to 10 times:  ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int times);
            var sum = 0;
            
            //Validation
            if(times < 1 || times > 10){
                Console.WriteLine("The number should be between number 1 to 10, please, try again");
            }
            else
            {
                for (var i = 1; i <= times; i++){
                    Console.Write("Please, enter a number: ");
                    var numberCase = Console.ReadLine();
                    int.TryParse(numberCase, out int num1);
                    sum += num1;
                }
                Console.WriteLine($"The result is: {sum}");
            }            
        }
    }
}
