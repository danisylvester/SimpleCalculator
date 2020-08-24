using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition questions & printing sum             
            Console.WriteLine("Enter a number to add.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number to add.");
            int num2 = int.Parse(Console.ReadLine());
            
            int sum = Sum(num1, num2, 5);
            Console.WriteLine($"The sum is {sum}.");

            // Multiplication question & printing product
            Console.WriteLine("Enter a number to multiply.");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number to multiply.");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is {product}.");

        }

        // addition method - added params keyword to allow for as many paramaters as we want.
        public static int Sum(params int[] list) 
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        // multiplication method
        public static int Multiply(int x, int y)
        {
            return x * y;
        }


        
    }
}
