using System.ComponentModel;

namespace OperatorExercise
{
    internal class Exercise1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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
        }
    }
}