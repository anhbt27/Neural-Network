using System.Windows.Forms;

namespace HopfieldNetwork
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.BuildPage = new System.Windows.Forms.TabPage();
            this.typeVector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TestPage = new System.Windows.Forms.TabPage();
            this.testResult = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.inputTestVector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weightMatrixResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.BuildPage.SuspendLayout();
            this.TestPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "By File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "By Hand";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "How do you want to input matrix?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.BuildPage);
            this.TabControl.Controls.Add(this.TestPage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(505, 442);
            this.TabControl.TabIndex = 3;
            // 
            // BuildPage
            // 
            this.BuildPage.AutoScroll = true;
            this.BuildPage.Controls.Add(this.typeVector);
            this.BuildPage.Controls.Add(this.label3);
            this.BuildPage.Controls.Add(this.button1);
            this.BuildPage.Controls.Add(this.label1);
            this.BuildPage.Controls.Add(this.button2);
            this.BuildPage.Location = new System.Drawing.Point(4, 25);
            this.BuildPage.Name = "BuildPage";
            this.BuildPage.Padding = new System.Windows.Forms.Padding(3);
            this.BuildPage.Size = new System.Drawing.Size(497, 413);
            this.BuildPage.TabIndex = 0;
            this.BuildPage.Text = "Buil Network";
            this.BuildPage.UseVisualStyleBackColor = true;
            this.BuildPage.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // typeVector
            // 
            this.typeVector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeVector.FormattingEnabled = true;
            this.typeVector.Items.AddRange(new object[] {
            "Unipolar",
            "Bipolar"});
            this.typeVector.Location = new System.Drawing.Point(154, 60);
            this.typeVector.Name = "typeVector";
            this.typeVector.Size = new System.Drawing.Size(121, 24);
            this.typeVector.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type of vector";
            // 
            // TestPage
            // 
            this.TestPage.Controls.Add(this.testResult);
            this.TestPage.Controls.Add(this.testBtn);
            this.TestPage.Controls.Add(this.inputTestVector);
            this.TestPage.Controls.Add(this.label2);
            this.TestPage.Location = new System.Drawing.Point(4, 25);
            this.TestPage.Name = "TestPage";
            this.TestPage.Padding = new System.Windows.Forms.Padding(3);
            this.TestPage.Size = new System.Drawing.Size(497, 413);
            this.TestPage.TabIndex = 1;
            this.TestPage.Text = "Test";
            this.TestPage.UseVisualStyleBackColor = true;
            // 
            // testResult
            // 
            this.testResult.Location = new System.Drawing.Point(45, 128);
            this.testResult.Multiline = true;
            this.testResult.Name = "testResult";
            this.testResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testResult.Size = new System.Drawing.Size(415, 207);
            this.testResult.TabIndex = 3;
            this.testResult.ReadOnly = true;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(192, 78);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(122, 43);
            this.testBtn.TabIndex = 2;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // inputTestVector
            // 
            this.inputTestVector.Location = new System.Drawing.Point(127, 40);
            this.inputTestVector.Name = "inputTestVector";
            this.inputTestVector.Size = new System.Drawing.Size(333, 22);
            this.inputTestVector.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Vector";
            // 
            // weightMatrixResult
            // 
            this.weightMatrixResult.Location = new System.Drawing.Point(524, 84);
            this.weightMatrixResult.Multiline = true;
            this.weightMatrixResult.Name = "weightMatrixResult";
            this.weightMatrixResult.Size = new System.Drawing.Size(371, 366);
            this.weightMatrixResult.TabIndex = 4;
            this.weightMatrixResult.ScrollBars = ScrollBars.Both;
            this.weightMatrixResult.ReadOnly = true;
            this.weightMatrixResult.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightMatrixResult);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Initializing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.BuildPage.ResumeLayout(false);
            this.BuildPage.PerformLayout();
            this.TestPage.ResumeLayout(false);
            this.TestPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage BuildPage;
        private System.Windows.Forms.TabPage TestPage;
        private System.Windows.Forms.TextBox inputTestVector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testResult;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.ComboBox typeVector;
        private System.Windows.Forms.Label label3;
        private TextBox weightMatrixResult;
        private Label label4;
    }
}

