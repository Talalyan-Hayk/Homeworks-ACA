using System;

namespace Matrix_simple_class
{
    class Program
    {
        private static bool isOctogonal;

        static void Main(string[] args)
        {
            uint row, column;
            bool a, b;

            // Generating first matrix while input sizes are correct
            do
            {
                Console.WriteLine("Enter rows and columns of matrix");
                Console.Write("Rows=");
                a = uint.TryParse(Console.ReadLine(), out row);
                Console.Write("Columns=");
                b = uint.TryParse(Console.ReadLine(), out column);
                if (!(a && b) || row == 0 || column == 0)
                {
                    Console.WriteLine("not correct input data");
                }
            } while (!(a && b) || row == 0 || column == 0);

            Matrix matrix1 = new Matrix(row, column);
            Console.WriteLine("First random generated matrix");
            matrix1.RandomGenerateMatrixElements();
            matrix1.ShowMatrix();
            Console.Write("Max element:" + matrix1.Max() + "\tMin element:" + matrix1.Min());
            

            //Generating second matrix 
            Console.WriteLine("\n--------------------------------------");
            do
            {
                Console.WriteLine("Enter rows and columns of matrix");
                Console.Write("Rows=");
                a = uint.TryParse(Console.ReadLine(), out row);
                Console.Write("Columns=");
                b = uint.TryParse(Console.ReadLine(), out column);
                if (!(a && b) || row == 0 || column == 0)
                {
                    Console.WriteLine("not correct input data");
                }
            } while (!(a && b) || row == 0 || column == 0);

            Matrix matrix2 = new Matrix(row, column);
            Console.WriteLine("Second random generated matrix");
            matrix2.RandomGenerateMatrixElements();
            matrix2.ShowMatrix();
            Console.Write("Max element:" + matrix2.Max() + "\tMin element:" + matrix2.Min());
           

            //show how to add two matrixes
            Console.WriteLine("\n**************************************");
            if (matrix1.Row == matrix2.Row && matrix1.Column == matrix2.Column)
            {
                Console.WriteLine("Addition of two matrixes equals");
                matrix1.Add(matrix2).ShowMatrix();
            }
            else
            {
                Console.WriteLine("Impossible to add this matrixes because of different resolution");
            }
            

            //Multiply operation of matrix by a number
            Console.WriteLine("**************************************");
            Console.Write("Please input a number: n=");
            double n;
            a = double.TryParse(Console.ReadLine(), out n);
            if (a)
            {
                Console.WriteLine("Multiply of first matrix by number n is");
                matrix1.Multiply(n).ShowMatrix();
            }
            else
            {
                Console.WriteLine("n is not a number");
            }
            

            //Multiply operation with two matrixes
            Console.WriteLine("**************************************");
            if (matrix1.Column == matrix2.Row)
            {
                Console.WriteLine("Multiply of first and second matrixes is");
                matrix1.Multiply(matrix2).ShowMatrix();
            }
            else
            {
                Console.WriteLine("Impossible multiply this two matrixes because of resolution");
            }
            

            //Transpose first matrix
            Console.WriteLine("**************************************");
            Console.WriteLine("Transpose of first matrix equals");
            matrix1.Transpose().ShowMatrix();
            Console.ReadKey();

            // Checking if the matrixes ar ortogonal
            Console.WriteLine("**************************************");
            if(isOctogonal)
            {
                Console.WriteLine("They are octogonal");
            }
        }
    }

}
   
