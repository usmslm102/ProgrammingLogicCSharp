using System;

//Write a program to print simple interest
namespace _4_SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, r, t; //Priciple Amount, Rate % , Time in years
            Console.WriteLine("Enter Priciple Amount!");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate% per annum!");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time in years!");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Principle Amount is " +  (p*r*t)/100);
            Console.ReadKey();

            
        }
    }
}
