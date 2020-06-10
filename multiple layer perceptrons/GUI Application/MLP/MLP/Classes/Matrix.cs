using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Classes
{
    class Matrix
    {
        public static Random rd = new Random();
        public static double GetRandomValue(double min, double max)
        {
            return rd.NextDouble()*(max - min) + min;
        }
        public static double[,] Transpose(double[,] matrix)
        {
            double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[j,i] = matrix[i,j];
                }
            }
            return result;
        }

        public static double[,] MultiplyAsScalar(double[,] matrix, double[,] matrix2)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] * matrix2[i, j];
                }
            }
            return result;
        }

        public static double[,] Scalar(double[,] matrix, double scalar)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }

        public static double[,] Multiply(double[,] matrix, double[,] matrix2)
        {
            double[,] result = new double[matrix.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        result[i, j] = result[i, j] + matrix[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        public static double[,] Subtract(double[,] matrix, double[,] matrix2)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public static double[,] Add(double[,] matrix, double[,] matrix2)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        public static double[,] Sigmoid(double[,] matrix)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = 1 / (1 + Math.Exp(-matrix[i, j]));
                }
            }
            return result;
        }

        public static double[,] DSigmoid(double[,] matrix)
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] * (1 - matrix[i, j]);
                }
            }
            return result;
        }

        public static double[,] FromArrayToVector(double[] array)
        {
            double[,] result = new double[array.Length, 1];
            for (int i = 0; i < array.Length; i++){
                result[i, 0] = array[i];
            }
            return result;
        }
    }
}
