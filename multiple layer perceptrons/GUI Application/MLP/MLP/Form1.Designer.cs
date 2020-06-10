namespace MLP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buildModel = new System.Windows.Forms.Button();
            this.numberOfPerceptrons = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfHiddenLayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfAttribute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfLabels = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.learningRateTB = new System.Windows.Forms.TextBox();
            this.readFileOutput = new System.Windows.Forms.TextBox();
            this.trainingOutputTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TestModel = new System.Windows.Forms.Button();
            this.testAccResultTB = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buildModel);
            this.tabPage1.Controls.Add(this.numberOfPerceptrons);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numberOfHiddenLayer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numberOfAttribute);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numberOfLabels);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(829, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Build Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buildModel
            // 
            this.buildModel.Location = new System.Drawing.Point(339, 293);
            this.buildModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildModel.Name = "buildModel";
            this.buildModel.Size = new System.Drawing.Size(171, 54);
            this.buildModel.TabIndex = 8;
            this.buildModel.Text = "Build Model";
            this.buildModel.UseVisualStyleBackColor = true;
            this.buildModel.Click += new System.EventHandler(this.buildModel_Click);
            // 
            // numberOfPerceptrons
            // 
            this.numberOfPerceptrons.Location = new System.Drawing.Point(423, 245);
            this.numberOfPerceptrons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfPerceptrons.Name = "numberOfPerceptrons";
            this.numberOfPerceptrons.Size = new System.Drawing.Size(100, 22);
            this.numberOfPerceptrons.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of perceptrons";
            // 
            // numberOfHiddenLayer
            // 
            this.numberOfHiddenLayer.Location = new System.Drawing.Point(423, 197);
            this.numberOfHiddenLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfHiddenLayer.Name = "numberOfHiddenLayer";
            this.numberOfHiddenLayer.Size = new System.Drawing.Size(100, 22);
            this.numberOfHiddenLayer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of hidden layer";
            // 
            // numberOfAttribute
            // 
            this.numberOfAttribute.Location = new System.Drawing.Point(423, 142);
            this.numberOfAttribute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfAttribute.Name = "numberOfAttribute";
            this.numberOfAttribute.Size = new System.Drawing.Size(100, 22);
            this.numberOfAttribute.TabIndex = 3;
            this.numberOfAttribute.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Attribute";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numberOfLabels
            // 
            this.numberOfLabels.Location = new System.Drawing.Point(423, 85);
            this.numberOfLabels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfLabels.Name = "numberOfLabels";
            this.numberOfLabels.Size = new System.Drawing.Size(100, 22);
            this.numberOfLabels.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of labels";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.learningRateTB);
            this.tabPage2.Controls.Add(this.readFileOutput);
            this.tabPage2.Controls.Add(this.trainingOutputTB);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.labelIndex);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(829, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Train";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Learning Rate";
            // 
            // learningRateTB
            // 
            this.learningRateTB.Location = new System.Drawing.Point(117, 117);
            this.learningRateTB.Margin = new System.Windows.Forms.Padding(4);
            this.learningRateTB.Name = "learningRateTB";
            this.learningRateTB.Size = new System.Drawing.Size(133, 22);
            this.learningRateTB.TabIndex = 6;
            // 
            // readFileOutput
            // 
            this.readFileOutput.Location = new System.Drawing.Point(13, 173);
            this.readFileOutput.Multiline = true;
            this.readFileOutput.Name = "readFileOutput";
            this.readFileOutput.ReadOnly = true;
            this.readFileOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.readFileOutput.Size = new System.Drawing.Size(383, 245);
            this.readFileOutput.TabIndex = 5;
            // 
            // trainingOutputTB
            // 
            this.trainingOutputTB.Location = new System.Drawing.Point(423, 7);
            this.trainingOutputTB.Multiline = true;
            this.trainingOutputTB.Name = "trainingOutputTB";
            this.trainingOutputTB.ReadOnly = true;
            this.trainingOutputTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.trainingOutputTB.Size = new System.Drawing.Size(400, 413);
            this.trainingOutputTB.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Train Model";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choose File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.Location = new System.Drawing.Point(117, 33);
            this.labelIndex.Margin = new System.Windows.Forms.Padding(4);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(132, 22);
            this.labelIndex.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Label Index";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TestModel);
            this.tabPage3.Controls.Add(this.testAccResultTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(829, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // TestModel
            // 
            this.TestModel.Location = new System.Drawing.Point(52, 154);
            this.TestModel.Name = "TestModel";
            this.TestModel.Size = new System.Drawing.Size(228, 58);
            this.TestModel.TabIndex = 3;
            this.TestModel.Text = "Test On Test Set";
            this.TestModel.UseVisualStyleBackColor = true;
            this.TestModel.Click += new System.EventHandler(this.TestModel_Click);
            // 
            // testAccResultTB
            // 
            this.testAccResultTB.Location = new System.Drawing.Point(362, 19);
            this.testAccResultTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testAccResultTB.Multiline = true;
            this.testAccResultTB.Name = "testAccResultTB";
            this.testAccResultTB.ReadOnly = true;
            this.testAccResultTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testAccResultTB.Size = new System.Drawing.Size(437, 400);
            this.testAccResultTB.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 475);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Multi Layer Perceptrons";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfAttribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOfLabels;
        private System.Windows.Forms.TextBox numberOfPerceptrons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfHiddenLayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buildModel;
        private System.Windows.Forms.TextBox testAccResultTB;
        private System.Windows.Forms.TextBox labelIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox trainingOutputTB;
        private System.Windows.Forms.TextBox readFileOutput;
        private System.Windows.Forms.Button TestModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox learningRateTB;
    }
}

