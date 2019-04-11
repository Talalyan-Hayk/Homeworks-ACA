using System;
using System.Text.RegularExpressions;

namespace Matrix_simple_class
{
    public class Matrix
    {
        public double[,] Mat { get; set; }
        public readonly uint Row;
        public readonly uint Column;

        /// <summary>
        /// Matrix class constructor
        /// </summary>
        /// <param name="row">Number of rows</param>
        /// <param name="column">Number of columns</param>
        public Matrix(uint row, uint column)
        {
            this.Mat = new double[row, column];
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Deafault constructor
        /// </summary>
        public Matrix() { }


        /// <summary>
        /// Checking if the matrix is square
        /// </summary>
        /// <returns>If it is, it will return true, if no then false</returns>
        public Boolean IsSquare()
        {
            return (Row == Column);
        }

        /// <summary>
        /// Method for matrix generation
        /// </summary>
        public void RandomGenerateMatrixElements()
        {
            Random rd = new Random();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    this.Mat[i, j] = rd.Next(-30, 31); // ... +rd.NextDouble();
            }
        }

        /// <summary>
        /// Method for printing the matrix
        /// </summary>
        public void ShowMatrix()
        {
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    Console.Write(this.Mat[i, j] + "\t");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method for finding the maximum 
        /// </summary>
        /// <returns></returns>
        public double Max()
        {
            double max = this.Mat[0, 0];
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    if (max < this.Mat[i, j])
                    {
                        max = this.Mat[i, j];
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// Method for finding the minimum 
        /// </summary>
        /// <returns></returns>
        public double Min()
        {
            double min = this.Mat[0, 0];
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    if (min > this.Mat[i, j])
                    {
                        min = this.Mat[i, j];
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Method for adding matrix with similar rows and columns
        /// </summary>
        /// <param name="second">Getting as a parameter another matrix</param>
        /// <returns>Return the result of adding or null if not possible</returns>
        public Matrix Add(Matrix second)
        {
            if (this.Row == second.Row && this.Column == second.Column)
            {
                Matrix result = new Matrix(this.Row, this.Column);
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < this.Column; j++)
                    {
                        result.Mat[i, j] = this.Mat[i, j] + second.Mat[i, j];
                    }
                }
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method for multiplyig a matrix by a number
        /// </summary>
        /// <param name="n">Give a number as a parameter</param>
        /// <returns>Returns the result of multiplying</returns>
        public Matrix Multiply(double n)
        {
            Matrix result = new Matrix(this.Row, this.Column);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    result.Mat[i, j] = n * this.Mat[i, j];
            }
            return result;
        }

        /// <summary>
        /// Method for multiplying a matrix by another matrix
        /// </summary>
        /// <param name="second">Give another matrix as parameter</param>
        /// <returns>Returns the result of multiplying</returns>
        public Matrix Multiply(Matrix second)
        {
            if (this.Column == second.Row)
            {
                Matrix result = new Matrix(this.Row, second.Column);
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < second.Column; j++)
                    {
                        for (int k = 0; k < this.Column; k++)
                        {
                            result.Mat[i, j] += this.Mat[i, k] * second.Mat[k, j];
                        }
                    }
                }
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// A method for matrix inversing
        /// </summary>
        /// <returns></returns>
        public Matrix Inverse()
        {
            Matrix result = new Matrix(this.Row, this.Column);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {


                }
            }
            return result;
        }

        /// <summary>
        /// A method for matrix transposing
        /// </summary>
        /// <returns></returns>
        public Matrix Transpose()
        {
            Matrix result = new Matrix(this.Column, this.Row);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    result.Mat[j, i] = this.Mat[i, j];
            }
            return result;
        }

        /// <summary>
        /// A method to check if matrix is ortogonal
        /// </summary>
        /// <returns></returns>
        public bool isOrtogonal()
        {
            bool ortogonal = true;
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    if (this.Inverse().Mat[i, j] != this.Transpose().Mat[i, j])
                    {
                        ortogonal = false;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return ortogonal;
        }
    }


}

