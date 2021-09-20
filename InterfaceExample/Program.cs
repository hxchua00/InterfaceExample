using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator math = new Calculator();

            math.addSum(2, 5);
            math.mult(5.0, 5.0);
            math.mult(6, 3);
            math.divide(9, 4);

            Console.ReadLine();
        }
    }
}
