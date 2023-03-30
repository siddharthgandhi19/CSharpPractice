using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class DeclareVariables
    {
        public void DeclareVariable() //this non static method //void is return type
        {
            int myValue = 5;
            string myName = "Sid";
            Console.WriteLine("My Value Is :" + myValue);
            Console.WriteLine(myName);
        }
        public static void DeclareVariable1() //this static method
        {
            int myValue = 5;
            string myName = "Sid";
            Console.WriteLine("My Value Is :" + myValue);
            Console.WriteLine(myName);
        }
    }
}
