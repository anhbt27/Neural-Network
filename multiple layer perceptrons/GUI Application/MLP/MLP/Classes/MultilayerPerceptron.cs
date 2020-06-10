using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Classes
{
    class MultilayerPerceptron
    {
        public InputLayer inputLayer;
        public HiddenLayer[] hiddenLayers;
        public OutputLayer outputLayer;

        public MultilayerPerceptron(int[] numberOfPperceptrons, int inputLength, int outputLength)
        {
            int numberOfWeights;
            Perceptron per;
            List<Perceptron> perceptrons;
            inputLayer = new InputLayer();

            HiddenLayer hidden;
            hiddenLayers = new HiddenLayer[numberOfPperceptrons.Length];
            for (int i = 0; i < numberOfPperceptrons.Length; i++)
            {
                numberOfWeights = i == 0 ? inputLength : numberOfPperceptrons[i - 1];
                hidden = new HiddenLayer();
                perceptrons = new List<Perceptron>();
                for(int j = 0; j < numberOfPperceptrons[i]; j++)
                {
                    per = new Perceptron(numberOfWeights);
                    perceptrons.Add(per);
                }
                hidden.Perceptrons = perceptrons;
                hiddenLayers[i] = hidden;
            }

            outputLayer = new OutputLayer();
            numberOfWeights = numberOfPperceptrons[numberOfPperceptrons.Length - 1];
            perceptrons = new List<Perceptron>();
            for (int i = 0; i < outputLength; i++)
            {
                per = new Perceptron(numberOfWeights);
                perceptrons.Add(per);
            }
            outputLayer.Perceptrons = perceptrons;

            inputLayer.NextLayer = hiddenLayers[0];
            for (int i = 0; i < hiddenLayers.Length - 1; i++)
            {
                hiddenLayers[i].NextLayer = hiddenLayers[i + 1];
            }

            hiddenLayers[hiddenLayers.Length - 1].NextLayer = outputLayer;
        }

        public void FeedForward(double[,] input)
        {
            inputLayer.FeedForward(input);
        }

        public double[,] Output()
        {
            return outputLayer.Output;
        }

        public void Train(double[,] error, double learningRate)
        {
            //Matrix.ShowMatrix(error);
            outputLayer.Error = error;
            outputLayer.Train(learningRate);
            for(int i= hiddenLayers.Length - 1; i >= 0; i--)
            {
                hiddenLayers[i].Train(learningRate);
            }
        }

        public void ShowWeight()
        {
            List<Perceptron> perceps;
            for (int i = 0; i < hiddenLayers.Count(); i++)
            {
                Console.WriteLine($"Hidden layer {i + 1}");
                perceps = hiddenLayers[i].Perceptrons;
                for (int j = 0; j < perceps.Count(); j++)
                {
                    Console.WriteLine($"Perceptron {j + 1}");
                    Console.Write($"Bias: {perceps[j].Bias} ");
                    for (int k = 0; k < perceps[j].Weights.Count(); k++)
                    {
                        Console.Write($"Weight: {perceps[j].Weights[k]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Output Layer: ");
            perceps = outputLayer.Perceptrons;
            for (int j = 0; j < perceps.Count(); j++)
            {
                Console.WriteLine($"Perceptron {j + 1}");
                Console.Write($"Bias: {perceps[j].Bias} ");
                for (int k = 0; k < perceps[j].Weights.Count(); k++)
                {
                    Console.Write($"Weight: {perceps[j].Weights[k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
