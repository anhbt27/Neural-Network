using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Classes
{
    class HiddenLayer : ILayer
    {
        public ILayer NextLayer { get; set; }
        public List<Perceptron> Perceptrons { get; set; }
        public double[,] Output { get; set; }
        public double[,] Input { get; set; }
        public double[,] Error { get; set; }
        public void FeedForward(double[,] input)
        {
            Input = input;
            Output = Matrix.Multiply(getWeighMatrix(),Input);
            Output = Matrix.Add(Output, getBias());
            Output = Matrix.Sigmoid(Output);
            if (NextLayer != null)
            {
                NextLayer.FeedForward(Output);
            }
        }
        public double[,] getWeighMatrix()
        {
            double[,] result = new double[Perceptrons.Count, Perceptrons[0].Weights.Length];
            for (int i = 0; i < Perceptrons.Count; i++)
            {
                for(int j = 0; j < Perceptrons[0].Weights.Length; j++)
                {
                    result[i, j] = Perceptrons[i].Weights[j];
                }
            }
            return result;
        }
        public double[,] getBias()
        {
            double[,] result = new double[Perceptrons.Count, 1];
            for (int i = 0; i < Perceptrons.Count; i++)
            {
                result[i, 0] = Perceptrons[i].Bias;
            }
            return result;
        }

        public void Train(double learningRate)
        {
            Error = Matrix.Multiply(Matrix.Transpose(NextLayer.getWeighMatrix()), NextLayer.Error);
            double[,] gradient = Matrix.DSigmoid(Output);
            gradient = Matrix.MultiplyAsScalar(Error, gradient);
            gradient = Matrix.Scalar(gradient, learningRate);
            double[,] deltaWeight = Matrix.Multiply(gradient, Matrix.Transpose(Input));
            for (int i = 0; i < Perceptrons.Count; i++)
            {
                Perceptrons[i].Bias = Perceptrons[i].Bias + gradient[i, 0];
                for (int j = 0; j < Perceptrons[0].Weights.Length; j++)
                {
                    Perceptrons[i].Weights[j] = Perceptrons[i].Weights[j] + deltaWeight[i, j];
                }
            }
        }
    }
}
