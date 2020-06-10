using MLP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLP
{
    public partial class Form1 : Form
    {
        List<double[]> allData;
        List<double[]> testSet;
        List<double[]> trainningSet;
        List<double[]> validationSet;
        List<String> labels;
        MultilayerPerceptron mlp;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buildModel_Click(object sender, EventArgs e)
        {
            try
            {
                int numberLabels = int.Parse(numberOfLabels.Text);
                int numberAttr = int.Parse(numberOfAttribute.Text);
                int numberLayer = int.Parse(numberOfHiddenLayer.Text);
                string[] numberWStr = numberOfPerceptrons.Text.Split(' ');
                if(numberWStr.Length != numberLayer)
                {
                    System.Windows.Forms.MessageBox.Show("Invalid number of perceptrons or number of weights each perceptron. Please check agian!");
                    return;
                }
                int[] numberW = new int[numberWStr.Length];
                for(int i=0 ; i < numberWStr.Length; i++)
                {
                    numberW[i] = int.Parse(numberWStr[i]);
                }

                mlp = new MultilayerPerceptron(numberW, numberAttr, numberLabels);
                System.Windows.Forms.MessageBox.Show("Build Success!");
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Invalid input data, Please check again! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int labelInd = int.Parse(labelIndex.Text);
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    testSet = new List<double[]>();
                    trainningSet = new List<double[]>();
                    validationSet = new List<double[]>();
                    labels = new List<String>();
                    allData = new List<double[]>();
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    String line = "";
                    double[] min = null;
                    double[] max = null;
                    while ((line=sr.ReadLine()) != null && !line.Equals(""))
                    {
                        string[] str = line.Split(',');
                        if (min == null)
                        {
                            min = new double[str.Length - 1];
                            max = new double[str.Length - 1];
                        }
                        double[] record = new double[str.Length];
                        if (!labels.Contains(str[labelInd - 1])) labels.Add(str[labelInd - 1]);
                        int count = 0;
                        int index = 0;
                        while(count < str.Length)
                        {
                            if (count + 1 != labelInd)
                            {
                                record[index] = double.Parse(str[count]);
                                if (record[index] >= max[index])
                                {
                                    max[index] = record[index];
                                }
                                if (record[index] < min[index])
                                {
                                    min[index] = record[index];
                                }
                                index++;
                            }
                            count++;
                        }
                        record[index] = labels.IndexOf(str[labelInd - 1]);
                        allData.Add(record);
                    }

                    NormalizeData(allData, min, max);

                    int[] numberOfRecord = new int[labels.Count];
                    List<double[]>[] recordsFollowType = new List<double[]>[labels.Count];
                    for (int i = 0; i < labels.Count; i++)
                    {
                        recordsFollowType[i] = new List<double[]>();
                    }
                    for (int i = 0; i < allData.Count; i++)
                    {
                        for(int j = 0; j < labels.Count; j++)
                        {
                            if(allData[i][allData[i].Length - 1] == j)
                            {
                                numberOfRecord[j]++;
                                recordsFollowType[j].Add(allData[i]);
                            }
                        }
                    }
                    string outputResult = "Total Records: " + allData.Count + "\r\n";
                    outputResult = outputResult + "Total Label: " + labels.Count + "\r\n";
                    for (int i = 0; i < labels.Count; i++)
                    {
                        outputResult = outputResult + "Class " + labels[i] + ": \r\n";
                        int testNumber = (int)(0.2 * numberOfRecord[i]);
                        int trainNumber = numberOfRecord[i] - testNumber;
                        int validationNumber = (int)(trainNumber * 0.2);
                        trainNumber = trainNumber - validationNumber;
                        outputResult = outputResult + "Training Records: " + trainNumber + "\r\n";
                        outputResult = outputResult + "Validation Records: " + validationNumber + "\r\n";
                        outputResult = outputResult + "Test Records: " + testNumber + "\r\n";
                        for (int j = 0; j < trainNumber; j++)
                        {
                            trainningSet.Add(recordsFollowType[i][j]);
                        }

                        for (int j = trainNumber; j < trainNumber + validationNumber; j++)
                        {
                            validationSet.Add(recordsFollowType[i][j]);
                        }

                        for (int j = trainNumber + validationNumber; j < numberOfRecord[i]; j++)
                        {
                            testSet.Add(recordsFollowType[i][j]);
                        }
                    }

                    readFileOutput.Text = outputResult;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Invalid input data, Please check again!");
            }
        }

        public void ShuffleList(List<double[]> DataSet)
        {
            Random random = new Random();
            int n = DataSet.Count;

            for (int i = DataSet.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                double[] value = DataSet[rnd];
                DataSet[rnd] = DataSet[i];
                DataSet[i] = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trainingOutputTB.Text = "";
            double[,] input;
            double[,] target;
            int count = 0;
            ShuffleList(trainningSet);
            double validationAccuracy = 0;
            double learningR = 0;
            try
            {
                learningR = double.Parse(learningRateTB.Text);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Invalid input data, Please check again! ");
            }
            while (count < 1000)
            {
                for (int i = 0; i < trainningSet.Count; i++)
                {
                    input = new double[trainningSet[i].Length - 1, 1];
                    for (int j = 0; j < input.GetLength(0); j++)
                    {
                        input[j, 0] = trainningSet[i][j];
                    }
                    target = new double[labels.Count, 1];
                    int labbIndex = (int)trainningSet[i][trainningSet[i].Length - 1];
                    for (int j = 0; j < target.GetLength(0); j++)
                    {
                        target[j, 0] = 0;
                    }
                    target[labbIndex, 0] = 1;
                    mlp.FeedForward(input);
                    double[,] output = mlp.Output();
                    double[,] error = Matrix.Subtract(target, output);

                    mlp.Train(error, learningR);
                }
                if (count > 0 && count % 10 == 0)
                {
                    int countValidation = 0;
                    int countTraining = 0;
                    for (int i = 0; i < validationSet.Count; i++)
                    {
                        input = new double[validationSet[i].Length - 1, 1];
                        for (int j = 0; j < input.GetLength(0); j++)
                        {
                            input[j, 0] = validationSet[i][j];
                        }
                        mlp.FeedForward(input);
                        double[,] result = mlp.Output();

                        if (GetMaxIndex(result) == validationSet[i][input.Length]) countValidation++;
                    }

                    for (int i = 0; i < trainningSet.Count; i++)
                    {
                        input = new double[trainningSet[i].Length - 1, 1];
                        for (int j = 0; j < input.GetLength(0); j++)
                        {
                            input[j, 0] = trainningSet[i][j];
                        }
                        mlp.FeedForward(input);
                        double[,] result = mlp.Output();

                        if (GetMaxIndex(result) == trainningSet[i][input.Length]) countTraining++;
                    }
                    double tempValidation = countValidation * 100 / validationSet.Count;
                    double tempTraining = countTraining * 100 / trainningSet.Count;
                    trainingOutputTB.Text = trainingOutputTB.Text + $"Training accuracy: {tempTraining}, Validation accuracy:{tempValidation}\r\n";
                    if (tempValidation >= validationAccuracy)
                    {
                        validationAccuracy = tempValidation;
                    } else
                    {
                        break;
                    }
                }
                count++;
            }
            System.Windows.Forms.MessageBox.Show("Build Success!");
        }

        public int GetMaxIndex(double[,] matrix)
        {
            int maxIndex = 0;
            double temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] >= temp)
                {
                    temp = matrix[i, 0];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void TestModel_Click(object sender, EventArgs e)
        {
            string resultTe = "";
            testAccResultTB.Text = "";
            int countTest = 0;
            double[,] input;
            for (int i = 0; i < testSet.Count; i++)
            {
                input = new double[testSet[i].Length - 1, 1];
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    input[j, 0] = testSet[i][j];
                }
                mlp.FeedForward(input);
                double[,] result = mlp.Output();
                if (GetMaxIndex(result) == testSet[i][input.Length]) countTest++;
            }
            double accuracy = 100 * countTest / testSet.Count;
            resultTe = resultTe + $"Test accuracy: { accuracy}";
            testAccResultTB.Text = resultTe;
        }

        private void NormalizeData(List<double[]> data, double[] min, double[] max)
        {
            for(int i = 0; i < data.Count; i++)
            {
                for(int j = 0; j < data[i].Length - 1; j++)
                {
                    data[i][j] = (data[i][j] - min[j]) / (max[j] - min[j]);
                }
            }
        }
    }
}
