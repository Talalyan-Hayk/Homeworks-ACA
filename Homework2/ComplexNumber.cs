using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework2
{
    class ComplexNumber
    {
        public ComplexNumber(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        //Binary Operator + 
        public static ComplexNumber operator +(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.re + arg2.re, arg1.im + arg2.im));
        }

        //Unary operator -
        public static ComplexNumber operator -(ComplexNumber arg1)
        {
            return (new ComplexNumber(-arg1.re, -arg1.im));
        }

        //Binary operator -
        public static ComplexNumber operator -(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.re - arg2.re, arg1.im - arg2.im));
        }

        // Operator *
        public static ComplexNumber operator *(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.re * arg2.re - arg1.im * arg2.im, arg1.re * arg2.im + arg2.re * arg1.im));
        }

        //Operator /
        public static ComplexNumber operator /(ComplexNumber arg1, ComplexNumber arg2)
        {
            double c1, c2, d;
            d = arg2.re * arg2.re + arg2.im * arg2.im;
            if(d == 0)
            {
                return (new ComplexNumber(0, 0));
            }
            c1 = arg1.re * arg2.re + arg1.im * arg2.im;
            c2 = arg1.im * arg2.re + arg1.re * arg2.im;
            return (new ComplexNumber(c1 / d, c2 / d));
        }

        public double Abs()
        {
            return (Math.Sqrt(re * re + im * im));
        }

        public double re;
        public double im;


    }
}
