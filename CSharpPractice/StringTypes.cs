using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class StringTypes
    {
        public void StringType()
        {
            string myString = "acbvhjcbdshucbudsc";
            Console.WriteLine(myString + " " + myString.Length);
            Console.WriteLine(myString.ToUpper());
        }


        public void StringInterpolation()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            string fullName = $"Full Name Is: " + firstName + " " + lastName;

            Console.WriteLine(fullName);
        }

        public void StringAccess()
        {
            string value = "Siddharth";
            Console.WriteLine(value[0]);
            Console.WriteLine(value.IndexOf("d"));
        }
    }
}
