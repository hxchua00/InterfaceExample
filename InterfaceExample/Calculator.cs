using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Calculator : ISimpleMath
    {
        public void addSum(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public void subtract(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Subtraction: " + (a - b));
            }
            else { Console.WriteLine("Subtraction: " + (b - a)); }
        }

        public void mult(double a, double b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }

        public void divide(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Division: " + (a / b));
            }
            else { Console.WriteLine("Division: " + (b / a)); }
        }
    }
}
