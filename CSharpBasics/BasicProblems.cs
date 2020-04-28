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
            Console.WriteLine($"The result is: {result}");
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

        public static void Multiple_numbers()
        {
            Console.Write("Hey!, tell me how many times do you want to enter numbers to this operation between 1 to 10 times:  ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int times);
            var sum = 0;

            //Validation
            if (times < 1 || times > 10)
            {
                Console.WriteLine("The number should be between number 1 to 10, please, try again");
            }
            else
            {
                for (var i = 1; i <= times; i++)
                {
                    Console.Write("Please, enter a number: ");
                    var numberCase = Console.ReadLine();
                    int.TryParse(numberCase, out int num1);
                    sum += num1;
                }
                Console.WriteLine($"The result is: {sum}");
            }
        }

        public static void IsEvenOrOdd()
        {
            //First number
            Console.Write("Please, enter a number: ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int num1);

            if (num1 % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }

        public static void WhatIsYourAge()
        {
            //Year
            Console.Write("What is your year of birth?: ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int yearOfBirth);
            //Month
            Console.Write("Could you tell me in numbers what month were you born?: ");
            inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int monthOfBirth);
            //Day
            Console.Write("what day were you born?: ");
            inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int dayOfBirth);

            //Today:
            DateTime today = DateTime.Today;
            //Get year
            int yearNow = today.Year;
            //Get month
            int monthNow = today.Month;
            //Get day
            int dayNow = today.Day;
            //subtracting years
            var age = yearNow - yearOfBirth;
            if (monthOfBirth > monthNow || monthOfBirth == monthNow && dayOfBirth > dayNow)
            {
                Console.WriteLine($"The age is: {age - 1}");
            }
            else
            {
                Console.WriteLine($"The age is: {age}");
            }
        }

        public static void average()
        {
            Console.Write("Hi, how many numbers do you want to enter: ");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out int times);
            //
            double sum = 0;
            for(var i = 1; i<=times; i++)
            {
                Console.Write("Please, enter a number: ");
                var numberCase = Console.ReadLine();
                double.TryParse(numberCase, out double num);
                sum += num;
            }
            Console.WriteLine($"The result is: {sum / times}");
        }
    }
}
