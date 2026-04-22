using System;

namespace Experment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            Console.WriteLine("Experiment 1: Basic Arithmetic Operations");
            Console.WriteLine("A = " + a + ", B = " + b);
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
        }
    }
}
