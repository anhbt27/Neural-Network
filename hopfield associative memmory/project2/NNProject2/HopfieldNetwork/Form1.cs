using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopfieldNetwork
{
    public partial class Form1 : Form
    {
        Label vectorSizeLb = new Label();
        Label numberOfVectorLb = new Label();
        Button generateInputBtn = new Button();
        List<TextBox> inputVectorList = new List<TextBox>();
        List<Label> inputVectorLb = new List<Label>();
        int[,] inputMatrix;
        int[,] weight;
        bool isBuilt = false;
        int numberOfVector, vectorSize;
        TextBox fileDetail = new TextBox();
        Button generateNetworkBtn = new Button();
        TextBox columns = new TextBox();
        TextBox rows = new TextBox();
        bool isByFile = false;
        public Form1()
        {
            InitializeComponent();
            fileDetail.Multiline = true;
            fileDetail.Height = 150;
            fileDetail.Width = 280;
            fileDetail.WordWrap = false;
            fileDetail.ReadOnly = true;
            fileDetail.ScrollBars = ScrollBars.Both;
            fileDetail.Location = new Point(38, 130);

            generateNetworkBtn.Text = "Build Network";
            generateNetworkBtn.Click += new System.EventHandler(generateNetworkBtn_Click);
            generateNetworkBtn.Name = "generateNetworkBtn";
            generateNetworkBtn.TextAlign = ContentAlignment.MiddleCenter;
            generateNetworkBtn.Width = 100;

            generateInputBtn.Click += new System.EventHandler(generateInputBtn_Click);

            columns.Name = "columnNumber";
            rows.Name = "rowNumber";

            this.typeVector.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                isByFile = true;
                isBuilt = false;
                this.BuildPage.Controls.Remove(fileDetail);
                this.BuildPage.Controls.Remove(generateNetworkBtn);
                this.BuildPage.Controls.Remove(numberOfVectorLb);
                this.BuildPage.Controls.Remove(vectorSizeLb);
                this.BuildPage.Controls.Remove(columns);
                this.BuildPage.Controls.Remove(rows);
                this.BuildPage.Controls.Remove(generateInputBtn);
                this.weightMatrixResult.Text = "";
                for (int i = 0; i < inputVectorLb.Count; i++)
                {
                    this.BuildPage.Controls.Remove(inputVectorLb[i]);
                }

                for (int i = 0; i < inputVectorList.Count; i++)
                {
                    this.BuildPage.Controls.Remove(inputVectorList[i]);
                }

                inputVectorLb.Clear();
                inputVectorList.Clear();
                string fileExt = System.IO.Path.GetExtension(openFileDialog1.FileName);
                if (!fileExt.Equals(".txt"))
                {
                    MessageBox.Show($"{fileExt} is not supported. System supports only txt file!");
                    return;
                }
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    fileDetail.Text = "Input Matrix:\r\n" + sr.ReadToEnd();
                    sr.Close();
                    generateNetworkBtn.Location = new Point(128, 290);
                    this.BuildPage.Controls.Add(fileDetail);
                    this.BuildPage.Controls.Add(generateNetworkBtn);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isByFile = false;
            isBuilt = false;
            this.BuildPage.Controls.Remove(fileDetail);
            this.BuildPage.Controls.Remove(generateNetworkBtn);
            this.BuildPage.Controls.Remove(numberOfVectorLb);
            this.BuildPage.Controls.Remove(vectorSizeLb);
            this.BuildPage.Controls.Remove(columns);
            this.BuildPage.Controls.Remove(rows);
            this.BuildPage.Controls.Remove(generateInputBtn);
            this.weightMatrixResult.Text = "";
            for(int i = 0; i < inputVectorLb.Count; i++)
            {
                this.BuildPage.Controls.Remove(inputVectorLb[i]);
            }

            for (int i = 0; i < inputVectorList.Count; i++)
            {
                this.BuildPage.Controls.Remove(inputVectorList[i]);
            }

            inputVectorLb.Clear();
            inputVectorList.Clear();

            numberOfVectorLb.Text = "Number of vector: ";
            numberOfVectorLb.Location = new Point(38, 135);
            this.BuildPage.Controls.Add(numberOfVectorLb);

            vectorSizeLb.Text = "Vector size: ";
            vectorSizeLb.Location = new Point(38, 175);
            this.BuildPage.Controls.Add(vectorSizeLb);

            rows.Location = new Point(138, 130);
            columns.Location = new Point(138, 170);
            this.BuildPage.Controls.Add(rows);
            this.BuildPage.Controls.Add(columns);

            generateInputBtn.Text = "Generate Input Form";
            generateInputBtn.Width = 70;
            generateInputBtn.Height = 60;
            generateInputBtn.Location = new Point(270, 130);
            this.BuildPage.Controls.Add(generateInputBtn);
        }

        private void generateInputBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inputVectorLb.Count; i++)
            {
                this.BuildPage.Controls.Remove(inputVectorLb[i]);
            }

            for (int i = 0; i < inputVectorList.Count; i++)
            {
                this.BuildPage.Controls.Remove(inputVectorList[i]);
            }
            inputVectorLb.Clear();
            inputVectorList.Clear();

            try
            {
                numberOfVector = int.Parse(rows.Text);
                vectorSize = int.Parse(columns.Text);
                int startY = 205;
                for(int i = 0; i < numberOfVector; i++)
                {
                    Label label = new Label();
                    TextBox vectorTextBox = new TextBox();
                    label.Text = "Vector " + (i+1);
                    label.Location = new Point(38, startY + i*30);
                    vectorTextBox.Location = new Point(138, startY + i * 30);
                    inputVectorList.Add(vectorTextBox);
                    inputVectorLb.Add(label);
                    this.BuildPage.Controls.Add(label);
                    this.BuildPage.Controls.Add(vectorTextBox);
                }

                generateNetworkBtn.Location = new Point(128, startY + numberOfVector * 30);
                this.BuildPage.Controls.Add(generateNetworkBtn);
            } catch(Exception ex)
            {
                MessageBox.Show("Invalid number of vector or length of vector! Please check again!");
            }

        }

        private void generateNetworkBtn_Click(object sender, EventArgs e)
        {
            if (isByFile)
            {
                generateByFile();
            } else
            {
                generateByHand();
            }
        }

        private void disPlayWeightResult()
        {
            int index = vectorSize;
            string result = "Weight Matrix: a*W. W is a matrix, a is a scalar.\r\n";
            result = result + "a = 1/" + index + "\r\n";
            result = result + "W = \r\n";
            for(int i = 0; i < vectorSize; i++)
            {
                for(int j = 0; j < vectorSize; j++)
                {
                    result = result + weight[i, j] + " ";
                }
                result = result + "\r\n";
            }
            this.weightMatrixResult.Text = result;
        }

        private void generateByFile()
        {
            var sr = new StreamReader(openFileDialog1.FileName);
            try
            {
                numberOfVector = int.Parse(sr.ReadLine());
                vectorSize = int.Parse(sr.ReadLine());
                inputMatrix = new int[numberOfVector,vectorSize];
                string line = "";
                int rowIndex = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if(rowIndex > numberOfVector)
                    {
                        MessageBox.Show("Invalid input matrix. please check again. Details: \r\n Invalid Number Of Vector");
                        sr.Close();
                        return;
                    }
                    string[] split = line.Trim().Split(' ');
                    if (split.Length != vectorSize)
                    {
                        MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors has invalid length");
                        sr.Close();
                        return;
                    }
                    for (int i = 0; i < split.Length; i++)
                    {
                        int value = int.Parse(split[i]);
                        if (this.typeVector.SelectedIndex == 0)
                        {
                            if(value != 1 && value != 0)
                            {
                                MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors is not unipolar");
                                sr.Close();
                                return;
                            }
                        } else
                        {
                            if(value != 1 && value != -1)
                            {
                                MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors is not bipolar");
                                sr.Close();
                                return;
                            }
                        }
                        inputMatrix[rowIndex, i] = value == 1 ? value : value == 0 ? -1 : value;
                    }
                    rowIndex++;
                }

                if (rowIndex < numberOfVector)
                {
                    MessageBox.Show("Invalid input matrix. please check again. Details: \r\n Invalid Number Of Vector");
                    sr.Close();
                    return;
                }

                weight = buildWeightMatrix();
                
                isBuilt = true;
                disPlayWeightResult();
                sr.Close();
                MessageBox.Show("Network is Built! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input matrix. please check again. Details: \r\n" + ex.Message);
                sr.Close();
                return;
            }
        }

        private void generateByHand()
        {
            try
            {
                string line = "";
                inputMatrix = new int[numberOfVector, vectorSize];
                for (int i = 0; i < inputVectorList.Count; i++)
                {
                    line = inputVectorList[i].Text.Trim();
                    if (line == null || line.Length == 0)
                    {
                        MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors has invalid length");
                        return;
                    }
                    string[] str = line.Split(' ');
                    if (str.Length != vectorSize)
                    {
                        MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors has invalid length");
                        return;
                    }
                    for (int j = 0; j < vectorSize; j++)
                    {
                        int value = int.Parse(str[j]);
                        if (this.typeVector.SelectedIndex == 0)
                        {
                            if (value != 1 && value != 0)
                            {
                                MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors is not unipolar");
                                return;
                            }
                        }
                        else
                        {
                            if (value != 1 && value != -1)
                            {
                                MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors is not bipolar");
                                return;
                            }
                        }
                        inputMatrix[i, j] = value == 1 ? value : value == 0 ? -1 : value;
                    }
                }
                weight = buildWeightMatrix();

                isBuilt = true;
                disPlayWeightResult();
                MessageBox.Show("Network is Built! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input matrix. please check again. Details: \r\n" + ex.Message);
                return;
            }
        }
        private int[,] buildWeightMatrix()
        {
            int[,] result = new int[vectorSize, vectorSize];
            for (int i = 0; i < vectorSize; i++)
            {
                for (int j = 0; j < vectorSize; j++)
                {
                    result[i, j] = 0;
                }
            }
            for (int i = 0; i < vectorSize - 1; i++)
            {
                for (int j = i + 1; j < vectorSize; j++)
                {
                    for (int k = 0; k < numberOfVector; k++)
                    {
                        result[i, j] = result[i, j] + (inputMatrix[k, i] * inputMatrix[k, j]);
                    }
                    result[j, i] = result[i, j];
                }
            }
            return result;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            this.testResult.Text = "";
            if (!isBuilt)
            {
                MessageBox.Show("Can not test because network is not built!");
                return;
            }
            string inputValue = this.inputTestVector.Text.Trim();
            string[] split = inputValue.Split(' ');
            int[] testVector = new int[vectorSize];
            if(split.Length != vectorSize)
            {
                MessageBox.Show("Test vector has invalid length. It should be " + vectorSize);
                return;
            }
            try
            {
                for (int i = 0; i < split.Length; i++)
                {
                    testVector[i] = int.Parse(split[i]);
                    if (this.typeVector.SelectedIndex == 0)
                    {
                        if (testVector[i] != 1 && testVector[i] != 0)
                        {
                            MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors is not unipolar");
                            return;
                        }
                    }
                    else
                    {
                        if (testVector[i] != 1 && testVector[i] != -1)
                        {
                            MessageBox.Show("Invalid input matrix. please check again. Details: \r\n One of input vectors is not bipolar");
                            return;
                        }
                    }
                }
                string result = testInputVector(testVector);
                this.testResult.Text = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Test vector has invalid value. Details: \r\n" + ex.Message);
                return;
            }
        }

        private string testInputVector(int[] testVector)
        {
            List<string> list1 = new List<string>();
            string result = "";
            int[] resultVector;
            List<int[]> resultList = new List<int[]>();
            for(int i = 0; i < testVector.Length; i++)
            {
                testVector[i] = testVector[i] == 1 ? 1 : testVector[i] == 0 ? -1 : testVector[i];
            }
            resultList.Add(testVector);
            int index = 1;
            while (true)
            {
                result = result + "Iterator " + (index) + ":\r\n";
                resultVector = new int[vectorSize];
                for(int i = 0; i < vectorSize; i++)
                {
                    for(int k = 0; k < vectorSize; k++)
                    {
                        resultVector[i] = resultVector[i] + resultList[index-1][k] * weight[i,k];
                    }
                    double resultInDouble = resultVector[i];
                    resultVector[i] = (resultInDouble/vectorSize) <= 0 ? -1 : 1;
                }
                string iteratorResult = "(";
                for(int i = 0; i < vectorSize; i++)
                {
                    iteratorResult = iteratorResult + (resultVector[i] + " ");
                }
                iteratorResult = iteratorResult.Trim();
                iteratorResult = iteratorResult + ") ";
                if (this.typeVector.SelectedIndex == 0)
                {
                    iteratorResult = iteratorResult.Replace("-1","0");
                }
                list1.Add(iteratorResult);
                result = result + iteratorResult;
                resultList.Add(resultVector);
                if(compareVector(resultList[index],resultList[index-1]))
                {
                    result = result + "-> Quit iterator. Final result is :" + iteratorResult;
                    break;
                }
                if(index >= 2 && compareVector(resultList[index], resultList[index-2]))
                {
                    result = result + "-> Quit Iterator because of cycle loop. Final results are :" + list1[index-1] + ", " + list1[index-2];
                    break;
                }
                result = result + "\r\n";
                index++;
            }
            return result;
        }

        private bool compareVector(int[] vector1, int[] vector2)
        {
            for(int i = 0; i < vector1.Length; i++)
            {
                if (vector1[i] != vector2[i]) return false;
            }
            return true;
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
