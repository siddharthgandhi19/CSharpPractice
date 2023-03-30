using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class ConditionalStatementifelse
    {
        public static void Statements1()
        {
            Console.WriteLine("Enter First Number");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int value2 = Convert.ToInt32(Console.ReadLine());

            if (value1 == value2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
        }

        public static void Statements2()
        {
            Console.WriteLine("Enter Number");
            int value1 = Convert.ToInt32(Console.ReadLine());

            if (value1 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void Statements3()
        {
            Console.WriteLine("Enter Number");
            int value1 = Convert.ToInt32(Console.ReadLine());

            if (value1 > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else
            {
                Console.WriteLine("Negative Number");
            }
        }

        public static void Statements4()
        {
            Console.WriteLine("Enter Number");
            int value = Convert.ToInt32(Console.ReadLine());



            //if ((value % 400) == 0) 
            //{
            //    Console.WriteLine("Leap Year");
            //}
            //else if ((value % 100) == 0)
            //{
            //    Console.WriteLine("Not a Leap Year");
            //}
            //else if ((value % 4) == 0){
            //    Console.WriteLine("Leap Year");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Leap Year");
            //}


            if (value % 4 == 0 && value % 400 == 0 || value % 100 != 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
        public static void Statements5()
        {
            int votingAge = 18;

            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= votingAge)
            {
                Console.WriteLine("You are eligible for vote");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
        public static void Statements6()
        {
            Console.WriteLine("Enter M Value");
            int m = Convert.ToInt32(Console.ReadLine());


            if (m > 0)
            {
                Console.WriteLine(" Value of N is 1 ");
            }
            else if (m < 0)
            {
                Console.WriteLine(" Value of N is -1 ");
            }
            else if (m == 0)
            {
                Console.WriteLine(" Value of N is 0 ");
            }
        }
        public static void Statements7()
        {
            Console.WriteLine("Enter Your Height (in cms) to Know Your Category");
            int personHeight = Convert.ToInt32(Console.ReadLine());

            if (personHeight < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (personHeight>150 && personHeight < 165)
            {
                Console.WriteLine("Average Height");
            }
            else if (personHeight>165 && personHeight < 195)
            { 
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }

        }

        public static void Statements8()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2&& num1>num3)
            {
                Console.WriteLine("First Number have Largest Value");
            }
            else if (num2>num3 && num2>num1)
            {
                Console.WriteLine("Second Number have Largest Value");
            }
            else
            {
                Console.WriteLine("Third Number have Largest Value");
            }

        }
        public static void Statements9()
        {
            Console.WriteLine("Input the value for X coordinate");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the value for Y coordinate");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate point" + (x,y) + "lies in the First quadrant.");
            }
            else if (x<0 && y>0)
            {
                Console.WriteLine("The coordinate point" + (x, y) + "lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point" + (x, y) + "lies in the Third quadrant.");
            }
            else
            {
                Console.WriteLine("The coordinate point" + (x, y) + "lies in the Fourth quadrant.");
            }
        }
        public static void Statements10()
        {
            //Marks in Maths >= 65
            //Marks in Phy >= 55
            //Marks in Chem >= 50
            //Total in all three subject >=180

            Console.WriteLine("Enter Marks Obtained in Maths");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks Obtained in Physics");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks Obtained in Chemistry");
            int Chem = Convert.ToInt32(Console.ReadLine());

            if(maths >= 65 && physics >= 55 && Chem>=50 && (maths+ physics+ Chem >=180) ||(maths + physics >=140) )
            {
                Console.WriteLine("You are eligible for admission");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }

        }
    }
}




