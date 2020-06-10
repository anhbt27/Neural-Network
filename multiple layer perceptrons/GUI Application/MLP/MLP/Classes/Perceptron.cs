using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Classes
{
    class Perceptron
    {
        public double[] Weights { get; set; }
        public double Bias;
        public Perceptron(int inputNumber)
        {
            double max = 4 * Math.Sqrt(6 / (inputNumber + 1));
            double min = -4 * Math.Sqrt(6 / (inputNumber + 1));
            Weights = new double[inputNumber];
            for(int i = 0; i < Weights.Length; i++)
            {
                Weights[i] = Matrix.GetRandomValue(min, max);
            }
            Bias = 0;
        }
    }
}
