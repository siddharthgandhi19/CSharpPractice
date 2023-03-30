using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class Calculator
    {
        public void Addition()
        {
            Console.WriteLine("Enter Value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of b");
            int b = Convert.ToInt32(Console.ReadLine()); ;


            Console.WriteLine("Final Value is "+  (a+b));
        }

        public void Substraction()
        {
            Console.WriteLine("Enter Value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of b");
            int b = Convert.ToInt32(Console.ReadLine()); ;


            Console.WriteLine("Final Value is " + (a-b));
        }
        public void Multiplication()
        {
            Console.WriteLine("Enter Value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of b");
            int b = Convert.ToInt32(Console.ReadLine()); ;


            Console.WriteLine("Final Value is " + (a*b));
        }
        public void Division()
        {
            Console.WriteLine("Enter Value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of b");
            int b = Convert.ToInt32(Console.ReadLine()); ;


            Console.WriteLine("Final Value is " + (a/b));
        }
    }
}
