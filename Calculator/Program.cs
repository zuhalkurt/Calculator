// See https://aka.ms/new-console-template for more information

using System;

namespace Calculator
{
    class  Program 
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            Console.Write("Enter your first number: ");
            string myFirstNumber = Console.ReadLine();
            
            Console.Write("Enter your second number: ");
            string mySecondNumber = Console.ReadLine();

            Console.WriteLine("The answer is: " + int.Parse(myFirstNumber) * int.Parse(mySecondNumber));
            Console.ReadLine();

        }
        
    }
}