using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class Multiplicationofthree
    {
        public void MultiplicationofthreeNumber()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int value = number1 * number2 * number3;
            Console.WriteLine("Multiplication Value: " + value);

        }
    }
}
