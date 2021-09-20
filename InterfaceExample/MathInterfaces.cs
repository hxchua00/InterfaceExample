using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IMoreMath
    {
        void mult(double a, double b);
        void divide(int a, int b);
    }

    interface ISimpleMath : IMoreMath
    {
        void subtract(int a, int b);
        void addSum(int a, int b);
    }
}
