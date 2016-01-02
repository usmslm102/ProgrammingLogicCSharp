using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program to accept values of two numbers and print their addition,subtraction,multiplication,division
namespace _2_AddSubDivMulOfTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, choice;
            Console.WriteLine("Enter the first Number!");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number!");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice\n1-Addition\n2-Subtraction\n3-Multiplication\n4-Division\n");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition of {0} and {1} is: {2}", a, b, a + b);
                    break;
                case 2:
                    Console.WriteLine("Subtraction of {0} and {1} is: {2}", a, b, a - b);
                    break;
                case 3:
                    Console.WriteLine("Multiplication of {0} and {1} is: {2}", a, b, a * b);
                    break;
                case 4:
                    Console.WriteLine("Division of {0} and {1} is: {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("You Entered wrong choice!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
