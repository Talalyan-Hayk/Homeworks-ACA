using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber v1 = new ComplexNumber(1.2, 2.0);
            ComplexNumber v2 = new ComplexNumber(1, 3.0);
            ComplexNumber v3 = v1 + v2;
            Console.WriteLine(v3.re);
            Console.WriteLine(v3.im);
            Console.ReadKey();
        }
    }
}
