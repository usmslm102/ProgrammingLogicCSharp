using System;

//Write a program to print area of a circle and Triangle.
namespace _3_AreaOfCircleTriangle
{
    public class Program
    {
        static double r, PI = 3.14, h, b;
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("---------Calculate the are of Triangle or Circle------------");
            Console.WriteLine("Enter your choice\n1-Circle\n2-Triangle\n");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CalculateCircle();
                    break;
                case 2:
                    CalculateTriangle();
                    break;
                default:
                    Console.WriteLine("Wrong Choice!");
                    break;
            }

        }
        public static void CalculateTriangle()
        {
            Console.WriteLine("Enter height:");
            Program.h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Base:");
            Program.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(0.5 * h * b);
            Console.ReadKey();
        }

        private static void CalculateCircle()
        {
            Console.WriteLine("Enter radius:");
            Program.r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(PI * r * r);
            Console.ReadKey();
        }
    }
}
