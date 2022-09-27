using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    internal class Program
    {
            static void Main(string[] args)
        {
            //Initial two variables.
            int a = 17;
            int b = 4;

            //Variables created from the initial two variables.
            int quotient = a / b;
            int remainder = a % b;

            //If statement:
            if (a == 17 && b == 4)

            //Expected result: 17 / 4 is 4 remainder 1
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            static double AreaOfCircle(double radius)
            {
                {
                    return Math.PI * radius * radius;
                }
            }

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
    }
}