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
            Console.Write("Enter your first number ");
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
        public static void MyMethod2()
        {
            //throw new NotImplementedException();
            Console.WriteLine("method 2");
        }
    }
}
